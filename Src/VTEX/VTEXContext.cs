using VTEX.Health;

namespace VTEX
{
    using CrispyWaffle.Extensions;
    using CrispyWaffle.Log;
    using CrispyWaffle.Serialization;
    using DataEntities;
    using Enums;
    using Extensions;
    using GoodPractices;
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Diagnostics.Contracts;
    using System.Linq;
    using System.Threading;
    using System.Threading.Tasks;
    using Transport;

    /// <summary>
    /// A VTEX Context, that consumes the VTEX Wrapper
    /// </summary>
    /// <seealso cref="IDisposable" />
    public sealed class VTEXContext : IDisposable
    {
        #region Private fields

        /// <summary>
        /// The wrapper
        /// </summary>
        private readonly VTEXWrapper _wrapper;

        #endregion

        #region ~Ctor

        /// <summary>
        /// Initializes a new instance of the <see cref="VTEXContext"/> class.
        /// </summary>
        /// <param name="accountName">Name of the account.</param>
        /// <param name="appKey">The application key.</param>
        /// <param name="appToken">The application token.</param>
        /// <param name="cookie">The cookie.</param>
        /// <exception cref="System.ArgumentNullException">
        /// appKey
        /// or
        /// appToken
        /// </exception>
        public VTEXContext(string accountName, string appKey, string appToken, string cookie)
        {
            _wrapper = new VTEXWrapper(accountName);
            if (string.IsNullOrWhiteSpace(appKey))
                throw new ArgumentNullException(nameof(appKey));
            if (string.IsNullOrWhiteSpace(appToken))
                throw new ArgumentNullException(nameof(appToken));
            _wrapper.SetRestCredentials(appKey, appToken);
            if (string.IsNullOrWhiteSpace(cookie))
                return;
            _wrapper.SetVtexIdClientAuthCookie(cookie);
        }

        #endregion

        #region Private Methods

        /// <summary>
        /// Gets the orders internal.
        /// </summary>
        /// <param name="status">(Optional) The status.</param>
        /// <param name="startDate">(Optional) The start date.</param>
        /// <param name="endDate">(Optional) The end date.</param>
        /// <param name="salesChannel">(Optional) The sales channel.</param>
        /// <param name="affiliatedId">(Optional) The affiliated id</param>
        /// <param name="paymentSystemName">(Optional) Name of the payment system.</param>
        /// <param name="genericQuery">(Optional) The generic query.</param>
        /// <returns>OrdersList.</returns>
        private OrdersList GetOrdersListInternal(string status = null, DateTime? startDate = null, DateTime? endDate = null, string salesChannel = null, string affiliatedId = null, string paymentSystemName = null, string genericQuery = null)
        {
            OrdersList result = null;
            var currentPage = 1;
            var queryString = new Dictionary<string, string> { { @"page", @"0" }, { @"per_page", @"50" } };
            if (!string.IsNullOrWhiteSpace(status))
                queryString.Add(@"f_status", status);
            if (!string.IsNullOrWhiteSpace(salesChannel))
                queryString.Add(@"f_salesChannel", salesChannel);
            if (!string.IsNullOrWhiteSpace(affiliatedId))
                queryString.Add(@"f_affiliateId", affiliatedId);
            if (!string.IsNullOrWhiteSpace(paymentSystemName))
                queryString.Add(@"f_paymentNames", paymentSystemName);
            if (startDate.HasValue && endDate.HasValue)
                queryString.Add(@"f_creationDate", $@"creationDate:[{startDate.Value.ToUniversalTime():s}Z TO {endDate.Value.ToUniversalTime():s}Z]");
            if (!string.IsNullOrWhiteSpace(genericQuery))
                queryString.Add(@"q", genericQuery);
            queryString.Add(@"orderBy", @"creationDate,asc");
            while (GetOrderListsValueInternal(queryString, currentPage, ref result))
                currentPage++;
            LogConsumer.Info("{0} orders found", result.List.Length);
            return result;
        }

        /// <summary>
        /// Gets the order lists value internal.
        /// </summary>
        /// <param name="queryString">The query string.</param>
        /// <param name="currentPage">The current page.</param>
        /// <param name="result">The result.</param>
        /// <returns></returns>
        /// <exception cref="UnexpectedApiResponseException"></exception>
        private bool GetOrderListsValueInternal(
            Dictionary<string, string> queryString,
            int currentPage,
            ref OrdersList result)
        {
            var json = string.Empty;
            try
            {
                LogConsumer.Trace("Getting page {0} of orders list", currentPage);
                queryString[@"page"] = currentPage.ToString(StringExtensions.Culture);

                json = _wrapper.ServiceInvokerAsync(HttpRequestMethod.GET, PlatformConstants.OMS_ORDERS, CancellationToken.None, queryString).Result;
                var temp = SerializerFactory.GetSerializer<OrdersList>().Deserialize(json);
                if (result == null)
                    result = temp;
                else
                    result.List = result.List.Concat(temp.List).ToArray();
                if (temp.Paging.Pages == 1 || temp.Paging.CurrentPage >= temp.Paging.Pages)
                    return false;
                if (currentPage == 1)
                    LogConsumer.Trace("{0} pages of orders list", temp.Paging.Pages);
                return true;
            }
            catch (JsonSerializationException e)
            {
                throw new UnexpectedApiResponseException(json, e);
            }
        }

        /// <summary>
        /// Gets the orders by order's ids.
        /// </summary>
        /// <param name="ordersIds">The order's ids.</param>
        /// <returns>IEnumerable&lt;Order&gt;.</returns>
        private IEnumerable<Order> GetOrdersInternal(IEnumerable<string> ordersIds)
        {
            var list = new List<Order>();
            Parallel.ForEach(ordersIds, orderId => list.Add(GetOrder(orderId)));
            return list;

        }

        /// <summary>
        /// Get a order by order id
        /// </summary>
        /// <param name="orderId">The id of the order</param>
        /// <returns>Order.</returns>
        /// <exception cref="InvalidPaymentDataException"></exception>
        private Order GetOrderInternal(string orderId)
        {
            LogConsumer.Trace("Getting order {0}", orderId);
            var json = _wrapper.ServiceInvokerAsync(HttpRequestMethod.GET, $"{PlatformConstants.OMS_ORDERS}/{orderId}", CancellationToken.None).Result;
            if (json == null)
                return null;
            try
            {
                var order = SerializerFactory.GetSerializer<Order>().Deserialize(json);

                #region Payment

                var transaction = order.PaymentData.Transactions.First();
                var payment = transaction.Payments.FirstOrDefault();
                if (payment != null &&
                    payment.PaymentSystem == 0 &&
                    !string.IsNullOrWhiteSpace(order.AffiliateId))
                    LogConsumer.Info(@"Marketplace {0}", order.AffiliateId);
                else if (transaction.TransactionId != null && !transaction.TransactionId.Equals(@"NO-PAYMENT", StringExtensions.Comparison))
                    LogConsumer.Info(@"Bank bill {0}", order.Sequence);
                else if (order.Totals.Sum(t => t.Value) == 0)
                    LogConsumer.Warning("Promotion / discount coupon - order subsidized");
                else
                    throw new InvalidPaymentDataException(orderId);

                #endregion

                #region Email 

                if (!string.IsNullOrWhiteSpace(order.ClientProfileData.UserProfileId))
                {
                    var client = SearchAsync<Client>(@"userId", order.ClientProfileData.UserProfileId, CancellationToken.None).Result;
                    if (client != null &&
                        !string.IsNullOrWhiteSpace(client.Email))
                        order.ClientProfileData.Email = client.Email;
                    if (order.ClientProfileData.Email.IndexOf(@"ct.vtex", StringExtensions.Comparison) != -1)
                        order.ClientProfileData.Email = @"pedido@editorainovacao.com.br";
                }

                #endregion

                LogConsumer.Debug(order, $"vtex-order-{orderId}.js");
                var affiliated = string.IsNullOrWhiteSpace(order.AffiliateId)
                                     ? string.Empty
                                     : $" - Affiliated: {order.AffiliateId}";
                LogConsumer.Info("Order: {0} - Sequence: {1} - Status: {2} - Sales channel: {3}{4}",
                                 order.OrderId,
                                 order.Sequence,
                                 order.Status.GetHumanReadableValue(),
                                 order.SalesChannel,
                                 affiliated);
                return order;
            }
            catch (JsonSerializationException e)
            {
                throw new UnexpectedApiResponseException(json, e);
            }
        }

        #endregion

        #region Public Methods

        #region OMS        

        /// <summary>
        /// Gets the feed.
        /// </summary>
        /// <param name="maxLot">The maximum lot.</param>
        /// <returns></returns>
        public IEnumerable<OrderFeed> GetFeed(int maxLot = 20)
        {
            //VTEX limitation
            if (maxLot > 20)
                maxLot = 20;
            LogConsumer.Trace("Getting up to {0} events in order feed", maxLot);
            var json = _wrapper.ServiceInvokerAsync(
                    HttpRequestMethod.GET,
                    $"{PlatformConstants.OMS_FEED}",
                    CancellationToken.None,
                    new Dictionary<string, string> { { @"maxLot", maxLot.ToString() } })
                .Result;
            return SerializerFactory.GetSerializer<List<OrderFeed>>().Deserialize(json);
        }

        /// <summary>
        /// Commits the feed.
        /// </summary>
        /// <param name="feed">The feed.</param>
        public void CommitFeed(OrderFeed feed)
        {
            LogConsumer.Trace("Commiting feed of order {0}", feed.OrderId);
            var data = (string)new OrderFeedCommit { CommitToken = feed.CommitToken }.GetSerializer();
            _wrapper.ServiceInvokerAsync(
                HttpRequestMethod.POST,
                $"{PlatformConstants.OMS_FEED}confirm",
                CancellationToken.None,
                data: data).Wait();
        }

        /// <summary>
        /// Get a order by order id
        /// </summary>
        /// <param name="orderId">The id of the order</param>
        /// <returns>Order.</returns>
        /// <exception cref="InvalidPaymentDataException"></exception>
        public Order GetOrder(string orderId)
        {
            return GetOrderInternal(orderId);
        }

        /// <summary>
        /// Gets the orders list metadata.
        /// </summary>
        /// <param name="status">The status.</param>
        /// <returns>IEnumerable&lt;List&gt;.</returns>
        public IEnumerable<List> GetOrdersList(OrderStatus status)
        {
            LogConsumer.Warning("Getting orders with status {0}", status.GetHumanReadableValue());
            var orders = GetOrdersListInternal(status.GetInternalValue());
            return orders.List;
        }

        /// <summary>
        /// Get a Enumerable list of Order by status.
        /// </summary>
        /// <param name="status">The status of the orders to get</param>
        /// <returns>IEnumerable&lt;Order&gt;.</returns>
        public IEnumerable<Order> GetOrders(OrderStatus status)
        {
            var ordersIds = GetOrdersList(status).Select(order => order.OrderId).ToList();
            if (ordersIds.Any())
                return GetOrdersInternal(ordersIds);
            LogConsumer.Warning("No orders with status {0} found", status.GetHumanReadableValue());
            return new Order[0];
        }

        /// <summary>
        /// Gets the orders list by a date range of order's placed date.
        /// </summary>
        /// <param name="startDate">The start date of the range.</param>
        /// <param name="endDate">The end date of the range.</param>
        /// <returns>IEnumerable&lt;String&gt;.</returns>
        public IEnumerable<List> GetOrdersList(DateTime startDate, DateTime endDate)
        {
            LogConsumer.Warning("Getting orders between {0:G} and {1:G}", startDate, endDate);
            var orders = GetOrdersListInternal(startDate: startDate, endDate: endDate);
            return orders.List;
        }

        /// <summary>
        /// Get a Enumerable list of Order by a date range of order's placed date.
        /// </summary>
        /// <param name="startDate">The start date of the range</param>
        /// <param name="endDate">The end date of the range</param>
        /// <returns>IEnumerable&lt;Order&gt;.</returns>
        public IEnumerable<Order> GetOrders(DateTime startDate, DateTime endDate)
        {
            var ordersIds = GetOrdersList(startDate, endDate).Select(order => order.OrderId).ToList();
            if (ordersIds.Any())
                return GetOrdersInternal(ordersIds);
            LogConsumer.Warning("No orders between {0:G} and {1:G} found", startDate, endDate);
            return new Order[0];
        }

        /// <summary>
        /// Gets the orders list by status and date range of order's placed date.
        /// </summary>
        /// <param name="status">The status of orders to get.</param>
        /// <param name="startDate">The start date of the range.</param>
        /// <param name="endDate">The end date of the range.</param>
        /// <returns>IEnumerable&lt;String&gt;.</returns>
        public IEnumerable<List> GetOrdersList(OrderStatus status, DateTime startDate, DateTime endDate)
        {
            LogConsumer.Warning("Getting orders with status {0} between {1:G} and {2:G}", status.GetHumanReadableValue(), startDate, endDate);
            var orders = GetOrdersListInternal(status.GetInternalValue(), startDate, endDate);
            return orders.List;
        }

        /// <summary>
        /// Get a Enumerable list of Order by status and date range of order's placed date.
        /// </summary>
        /// <param name="status">The status of orders to get.</param>
        /// <param name="startDate">The start date of the range.</param>
        /// <param name="endDate">The end date of the range.</param>
        /// <returns>IEnumerable&lt;Order&gt;.</returns>
        public IEnumerable<Order> GetOrders(OrderStatus status, DateTime startDate, DateTime endDate)
        {
            var ordersIds = GetOrdersList(status, startDate, endDate).Select(order => order.OrderId).ToList();
            if (ordersIds.Any())
                return GetOrdersInternal(ordersIds);
            LogConsumer.Warning("No order with status {0} between {1:G} and {2:G} found", status.GetHumanReadableValue(), startDate, endDate);
            return new Order[0];
        }

        /// <summary>
        /// Gets the orders list by status and affiliated identifier (AKA marketplace).
        /// </summary>
        /// <param name="status">The status of orders to get.</param>
        /// <param name="affiliatedId">The affiliated identifier</param>
        /// <returns>IEnumerable&lt;String&gt;.</returns>
        public IEnumerable<List> GetOrdersList(OrderStatus status, string affiliatedId)
        {
            LogConsumer.Warning("Getting orders with status {0} and affiliated {1}", status.GetHumanReadableValue(), affiliatedId);
            var orders = GetOrdersListInternal(status.GetInternalValue(), affiliatedId: affiliatedId);
            return orders.List;
        }

        /// <summary>
        /// Get a Enumerable list of Order by status and affiliated identifier (AKA marketplace).
        /// </summary>
        /// <param name="status">The status of orders to get.</param>
        /// <param name="affiliatedId">The affiliated identifier</param>
        /// <returns>IEnumerable&lt;Order&gt;.</returns>
        public IEnumerable<Order> GetOrders(OrderStatus status, string affiliatedId)
        {
            var ordersIds = GetOrdersList(status, affiliatedId).Select(order => order.OrderId).ToList();
            if (ordersIds.Any())
                return GetOrdersInternal(ordersIds);
            LogConsumer.Warning("No order with status {0} and affiliated {1} found", status.GetHumanReadableValue(), affiliatedId);
            return new Order[0];
        }

        /// <summary>
        /// Gets the orders list by generic query (order id, client's document, sequence, etc).
        /// </summary>
        /// <param name="query">The query to lookup in orders.</param>
        /// <returns>IEnumerable&lt;String&gt;.</returns>
        public IEnumerable<List> GetOrdersList(string query)
        {
            LogConsumer.Warning("Getting orders with term '{0}'", query);
            var orders = GetOrdersListInternal(genericQuery: query);
            return orders.List;
        }

        /// <summary>
        /// Gets the orders by generic query (order identifier, client's document, sequence, etc).
        /// </summary>
        /// <param name="query">The query to lookup in orders.</param>
        /// <returns>IEnumerable&lt;Order&gt;.</returns>
        public IEnumerable<Order> GetOrders(string query)
        {
            var ordersIds = GetOrdersList(query).Select(order => order.OrderId).ToList();
            if (ordersIds.Any())
                return GetOrdersInternal(ordersIds);
            LogConsumer.Warning("No orders with term '{0}' found", query);
            return new Order[0];
        }

        /// <summary>
        /// Gets the orders by the array of orders identifiers
        /// </summary>
        /// <param name="ordersIds">The orders ids.</param>
        /// <returns></returns>
        public IEnumerable<Order> GetOrders(string[] ordersIds)
        {
            return GetOrdersInternal(ordersIds);
        }

        /// <summary>
        /// Cancels the order asynchronous.
        /// </summary>
        /// <param name="orderId">The order identifier.</param>
        /// <returns></returns>
        /// <exception cref="InvalidOperationException">Order {orderId} cannot be canceled because isn't in pending payment status on VTEX</exception>
        public async Task<string> CancelOrderAsync(string orderId)
        {
            try
            {
                LogConsumer.Warning("Cancelling order {0}", orderId);
                var source = new CancellationTokenSource(new TimeSpan(0, 5, 0));
                var order = GetOrder(orderId);
                if (order.Status == OrderStatus.CANCELED)
                    return string.Empty;
                if (order.Status != OrderStatus.PAYMENT_PENDING && order.Status != OrderStatus.AWAITING_AUTHORIZATION_TO_DISPATCH)
                    throw new InvalidOperationException(
                        $"Order {orderId} cannot be canceled because isn't in pending payment status on VTEX");
                var json = await _wrapper.ServiceInvokerAsync(HttpRequestMethod.POST, $"{PlatformConstants.OMS_ORDERS}/{orderId}/cancel", source.Token);
                var receipt = SerializerFactory.GetSerializer<OrderCancellation>().Deserialize(json);
                LogConsumer.Info("Order {0} successfully canceled. Receipt: {1}", order.Sequence, receipt.Receipt);
                return receipt.Receipt;
            }
            catch (Exception e)
            {
                LogConsumer.Handle(new CancelOrderException(orderId, e));
                return string.Empty;
            }
        }

        /// <summary>
        /// Changes the order status asynchronous.
        /// </summary>
        /// <param name="orderId">The order identifier.</param>
        /// <param name="newStatus">The new status.</param>
        /// <exception cref="ChangeStatusOrderException">
        /// </exception>
        public async Task ChangeOrderStatusAsync(string orderId, OrderStatus newStatus)
        {
            try
            {
                LogConsumer.Info("Changing order {0} status to {1}", orderId, newStatus.GetHumanReadableValue());
                var source = new CancellationTokenSource(new TimeSpan(0, 5, 0));
                var json = await _wrapper.ServiceInvokerAsync(HttpRequestMethod.POST, $"{PlatformConstants.OMS_ORDERS}/{orderId}/changestate/{newStatus.GetInternalValue()}", source.Token);
                LogConsumer.Info(json);
            }
            catch (AggregateException e)
            {
                var ae = e.InnerExceptions.First() ?? e.InnerException ?? e;
                throw new ChangeStatusOrderException(orderId, newStatus.GetHumanReadableValue(), ae);
            }
            catch (Exception e)
            {
                throw new ChangeStatusOrderException(orderId, newStatus.GetHumanReadableValue(), e);
            }
        }

        /// <summary>
        /// Notifies the order paid asynchronous.
        /// </summary>
        /// <param name="orderId">The order identifier.</param>
        public async Task NotifyOrderPaidAsync(string orderId)
        {
            try
            {
                LogConsumer.Info("Sending payment notification of order {0}", orderId);
                var source = new CancellationTokenSource(new TimeSpan(0, 5, 0));
                var order = GetOrder(orderId);
                if (order.Status != OrderStatus.PAYMENT_PENDING &&
                    order.Status != OrderStatus.AWAITING_AUTHORIZATION_TO_DISPATCH)
                    return;
                if (order.Status == OrderStatus.AWAITING_AUTHORIZATION_TO_DISPATCH)
                {
                    await ChangeOrderStatusAsync(order.OrderId, OrderStatus.AUTHORIZE_FULFILLMENT);
                    return;
                }
                var paymentId = order.PaymentData.Transactions.First().Payments.First().Id;
                _wrapper.ServiceInvokerAsync(HttpRequestMethod.POST,
                                             $"{PlatformConstants.OMS_ORDERS}/{order.OrderId}/payments/{paymentId}/payment-notification",
                                             source.Token).Wait(source.Token);

            }
            catch (Exception e)
            {
                LogConsumer.Handle(new PaymentNotificationOrderException(orderId, e));
            }
        }

        /// <summary>
        /// Notifies the order shipped.
        /// </summary>
        /// <param name="orderId">The order identifier.</param>
        /// <param name="notification">The notification.</param>
        /// <exception cref="ShippingNotificationOrderException"></exception>
        public void NotifyOrderShipped(string orderId, ShippingNotification notification)
        {
            NotifyOrderShippedAsync(orderId, notification, CancellationToken.None).Wait();
        }

        /// <summary>
        /// Notifies the order shipped async.
        /// </summary>
        /// <param name="orderId">The order identifier.</param>
        /// <param name="notification">The notification.</param>
        /// <param name="token">The token.</param>
        /// <returns></returns>
        /// <exception cref="ShippingNotificationOrderException">
        /// </exception>
        public async Task<string> NotifyOrderShippedAsync(
            string orderId,
            ShippingNotification notification,
            CancellationToken token)
        {
            try
            {
                LogConsumer.Info("Sending shipping notification of order {0}", orderId);
                LogConsumer.Debug(
                                  notification,
                                  $"vtex-shipping-notification-{orderId}-{notification.InvoiceNumber}.js");
                var json = await _wrapper.ServiceInvokerAsync(
                                                              HttpRequestMethod.POST,
                                                              $"{PlatformConstants.OMS_INVOICES}/{orderId}/invoice",
                                                              token,
                                                              data: (string)notification.GetSerializer())
                                         .ConfigureAwait(false);
                var receipt = SerializerFactory.GetSerializer<ResponseReceipt>().Deserialize(json);
                LogConsumer.Trace(receipt.Receipt);
                return receipt.Receipt;
            }
            catch (AggregateException e)
            {
                var ae = e.InnerExceptions.First() ?? e.InnerException ?? e;
                throw new ShippingNotificationOrderException(orderId, ae);
            }
            catch (Exception e)
            {
                throw new ShippingNotificationOrderException(orderId, e);
            }
        }

        /// <summary>
        /// Notifies the order delivered
        /// </summary>
        /// <param name="tracking"></param>
        public async ValueTask<string> NotifyOrderDelivered(Tracking tracking)
        {
            try
            {
                LogConsumer.Info("Sending tracking info of order {0}", tracking.OrderId);
                var source = new CancellationTokenSource(new TimeSpan(0, 5, 0));
                LogConsumer.Debug(tracking, $"vtex-tracking-info-{tracking.OrderId}-{tracking.InvoiceNumber}.js");
                var json = await _wrapper.ServiceInvokerAsync(HttpRequestMethod.PUT,
                                                        string.Format(PlatformConstants.OMS_TRACKING,
                                                                      tracking.OrderId,
                                                                      tracking.InvoiceNumber),
                                                        source.Token,
                                                        data: (string)tracking.GetSerializer());
                var receipt = SerializerFactory.GetSerializer<ResponseReceipt>().Deserialize(json);
                LogConsumer.Trace(receipt.Receipt);
                return receipt.Receipt;
            }
            catch (Exception e)
            {
                throw new TrackingNotificationOrderException(tracking.OrderId, e);
            }
        }

        /// <summary>
        /// Updates the order invoice.
        /// </summary>
        /// <param name="orderId">The order identifier.</param>
        /// <param name="invoiceId">The invoice identifier.</param>
        /// <param name="notification">The notification.</param>
        /// <exception cref="ShippingNotificationOrderException"></exception>
        public void UpdateOrderInvoice(string orderId, string invoiceId, ShippingNotificationPatch notification)
        {
            try
            {
                LogConsumer.Info("Patching fiscal invoice {1} of order {0}", orderId, invoiceId);
                var source = new CancellationTokenSource(new TimeSpan(0, 5, 0));
                LogConsumer.Debug(notification, $"vtex-shipping-notification-{orderId}-{invoiceId}.js");
                var json = _wrapper.ServiceInvokerAsync(HttpRequestMethod.PATCH,
                                                        $"{PlatformConstants.OMS_ORDERS}/{orderId}/invoice/{invoiceId}",
                                                        source.Token, data: (string)notification.GetSerializer()).Result;
                var receipt = SerializerFactory.GetSerializer<ResponseReceipt>().Deserialize(json);
                LogConsumer.Trace(receipt.Receipt);
            }
            catch (Exception e)
            {
                throw new ShippingNotificationOrderException(orderId, e);
            }
        }

        /// <summary>
        /// Changes the order.
        /// </summary>
        /// <param name="orderId">The order identifier.</param>
        /// <param name="change">The change.</param>
        /// <exception cref="ChangeOrderException"></exception>
        public void ChangeOrder(string orderId, ChangeOrder change)
        {
            try
            {
                LogConsumer.Info("Changing order {0}", orderId);
                LogConsumer.Debug(change, $"vtex-change-order-{orderId}.js");
                var json = _wrapper.ServiceInvokerAsync(
                                                        HttpRequestMethod.POST,
                                                        $"{PlatformConstants.OMS_ORDERS}/{orderId}/changes",
                                                        CancellationToken.None,
                                                        data: (string)change.GetSerializer()).Result;
                var receipt = SerializerFactory.GetSerializer<ResponseReceipt>().Deserialize(json);
                LogConsumer.Trace(receipt.Receipt);
            }
            catch (Exception e)
            {
                throw new ChangeOrderException(orderId, e);
            }
        }

        #endregion

        #region PCI Gateway

        /// <summary>
        /// Gets the transaction interactions.
        /// </summary>
        /// <param name="transactionId">The transaction identifier.</param>
        /// <returns></returns>
        /// <exception cref="TransactionException"></exception>
        [Pure]
        public IEnumerable<TransactionInteraction> GetTransactionInteractions(string transactionId)
        {
            try
            {
                LogConsumer.Info("Getting interactions of transaction {0}", transactionId);
                var json = _wrapper.ServiceInvokerAsync(HttpRequestMethod.GET,
                                                        $"{PlatformConstants.PCI_TRANSACTIONS}/{transactionId}/interactions",
                                                        CancellationToken.None,
                                                        restEndpoint: RequestEndpoint.PAYMENTS).Result;
                return SerializerFactory.GetSerializer<List<TransactionInteraction>>().Deserialize(json);
            }
            catch (Exception e)
            {
                throw new TransactionException(transactionId, e);
            }
        }

        #endregion

        #region Stock

        /// <summary>
        /// Gets the sku reservations.
        /// </summary>
        /// <param name="skuId">The sku identifier.</param>
        /// <param name="stock">The stock.</param>
        /// <returns>Int32.</returns>
        public async Task<int> GetSKUReservationsAsync(int skuId, Warehouse stock)
        {
            try
            {
                LogConsumer.Info("Getting reservations of SKU {0} in the warehouse {1}", skuId, stock.GetHumanReadableValue());
                var source = new CancellationTokenSource(new TimeSpan(0, 5, 0));
                var json = await _wrapper.ServiceInvokerAsync(
                                                              HttpRequestMethod.GET,
                                                              $"{PlatformConstants.LOG_RESERVATIONS}/{stock.GetInternalValue()}/{skuId}",
                                                              source.Token).ConfigureAwait(false);
                var reservations = SerializerFactory.GetSerializer<Reservations>().Deserialize(json);
                LogConsumer.Debug(reservations, $"vtex-sku-reservations-{skuId}.js");
                var total = !reservations.Items.Any() ? 0 : reservations.Items.Sum(r => r.Quantity);
                LogConsumer.Info("The SKU {0} has {1} units reserved in warehouse {2}", skuId, total, stock.GetHumanReadableValue());
                return total;
            }
            catch (Exception e)
            {
                LogConsumer.Handle(new ProductExportException(skuId, e));
                return 0;
            }
        }

        /// <summary>
        /// Gets the sku inventory.
        /// </summary>
        /// <param name="skuId">The sku identifier.</param>
        /// <returns>Inventory.</returns>
        public async Task<Inventory> GetSKUInventoryAsync(int skuId)
        {
            LogConsumer.Info("Getting inventory of SKU {0}", skuId);
            var source = new CancellationTokenSource(new TimeSpan(0, 5, 0));
            var json = await _wrapper.ServiceInvokerAsync(HttpRequestMethod.GET,
                                             $"{PlatformConstants.LOG_INVENTORY}/{skuId}",
                                             source.Token, restEndpoint: RequestEndpoint.LOGISTICS).ConfigureAwait(false);
            var inventory = SerializerFactory.GetSerializer<Inventory>().Deserialize(json);
            LogConsumer.Debug(inventory, $"vtex-sku-inventory-{skuId}.js");
            return inventory;
        }

        /// <summary>
        /// Updates the sku stock.
        /// </summary>
        /// <param name="stockInfo">The stock information.</param>
        /// <exception cref="UpdateStockInfoSKUException"></exception>

        public async Task UpdateSKUStockAsync(StockInfo stockInfo)
        {
            try
            {
                if (stockInfo.Quantity < 0)
                    stockInfo.Quantity = 0;
                stockInfo.DateUtcOnBalanceSystem = null;
                if (!stockInfo.UnlimitedQuantity)
                    stockInfo.Quantity += await GetSKUReservationsAsync(stockInfo.ItemId, stockInfo.WareHouseEnum).ConfigureAwait(false);
                LogConsumer.Info("Updating inventory of SKU {0} on warehouse {1} with {2} units",
                                    stockInfo.ItemId,
                                    stockInfo.WareHouseEnum.GetHumanReadableValue(),
                                    stockInfo.Quantity);
                var source = new CancellationTokenSource(new TimeSpan(0, 5, 0));
                var data = @"[" + (string)stockInfo.GetSerializer() + @"]";
                LogConsumer.Debug(stockInfo, $"vtex-sku-stock-{stockInfo.ItemId}.js");
                await _wrapper.ServiceInvokerAsync(HttpRequestMethod.POST,
                                                        PlatformConstants.LOG_WAREHOUSES,
                                                        source.Token,
                                                        data: data).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                throw new UpdateStockInfoSKUException(stockInfo.ItemId, e);
            }
        }

        #endregion

        #region Pricing

        /// <summary>
        /// Get the prices for an SKU.        
        ///It is possible that on the property "fixedPrices" exists a list of specific prices for Trade Policies and Minimum Quantities of the SKU.Fixed Prices may also be scheduled.
        /// </summary>
        /// <param name="skuId">The stock keeping unit identifier</param>
        /// <returns>A task of price</returns>
        public async Task<Price> GetPriceAsync(int skuId)
        {
            LogConsumer.Info("Getting the price of sku {0}", skuId);
            var source = new CancellationTokenSource(new TimeSpan(0, 5, 0));
            try
            {
                var json = await _wrapper.ServiceInvokerAsync(
                                                              HttpRequestMethod.GET,
                                                              $@"{PlatformConstants.PRICING}/{skuId}",
                                                              source.Token,
                                                              restEndpoint: RequestEndpoint.API)
                                         .ConfigureAwait(false);
                return SerializerFactory.GetSerializer<Price>().Deserialize(json);
            }
            catch (UnexpectedApiResponseException e)
            {
                if (e.StatusCode == 404)
                    return new Price();
                throw;
            }
        }

        /// <summary>
        /// This method will create or update an SKU Price.
        /// The property "basePrice" is the base selling price of the SKU.The property "fixedPrices" is an array where each item is a Fixed Price.
        /// The Fixed Price is the price of the SKU for an specific Trade Policy with an specific Minimum Quantity to be activated.
        /// A Fixed Price may optionally be scheduled by using the property dateRange.
        /// A Fixed Price may optionally overwrite the listPrice specified in the Base Price by using the inner property listPrice.
        /// If you don't have specific prices for different Trade Policies, you do not need to send the property fixedPrices.
        /// </summary>
        /// <param name="price">The price data</param>
        /// <param name="skuId">The stock keeping unit identifier</param>
        /// <param name="token">The cancellation token.</param>
        /// <returns></returns>
        public async Task UpdatePriceAsync(Price price, int skuId, CancellationToken token)
        {
            try
            {
                var oldPrice = await GetPriceAsync(skuId).ConfigureAwait(false);
                if (oldPrice?.FixedPrices != null &&
                    oldPrice.FixedPrices.Any())
                    await DeletePriceAsync(skuId, token).ConfigureAwait(false);
                LogConsumer.Info("Updating the price of sku {0} to {1} (list price: {2})",
                                 skuId,
                                 price.CostPrice.ToMonetary(),
                                 price.ListPrice.HasValue
                                     ? price.ListPrice.Value.ToMonetary()
                                     : "no");
                await _wrapper.ServiceInvokerAsync(
                                                   HttpRequestMethod.PUT,
                                                   $@"{PlatformConstants.PRICING}/{skuId}",
                                                   token,
                                                   data: (string)price.GetSerializer(),
                                                   restEndpoint: RequestEndpoint.API)
                              .ConfigureAwait(false);
            }
            catch (Exception e)
            {
                throw new UpdatePriceInfoSKUException(skuId, e);
            }
        }

        /// <summary>
        /// Removes an SKU price. 
        /// This action removes both Base Price and all available Fixed Prices for and SKU in all trade policies.
        /// </summary>
        /// <param name="skuId">The stock keeping unit identifier.</param>
        /// <param name="token">The cancellation token.</param>
        /// <returns>Task</returns>
        public async Task DeletePriceAsync(int skuId, CancellationToken token)
        {
            LogConsumer.Info("Deleting the price of sku {0}", skuId);
            await _wrapper.ServiceInvokerAsync(
                                               HttpRequestMethod.DELETE,
                                               $@"{PlatformConstants.PRICING}/{skuId}",
                                               token,
                                               restEndpoint: RequestEndpoint.API)
                          .ConfigureAwait(false);
        }

        #endregion

        #region Bridge

        /// <summary>
        /// Gets the bride facets.
        /// </summary>
        /// <param name="query">The query.</param>
        /// <param name="keywords">The keywords.</param>
        /// <returns>IEnumerable&lt;BridgeFacet&gt;.</returns>
        /// <exception cref="BridgeException"></exception>
        [Pure]
        public IEnumerable<BridgeFacet> GetBridgeFacets([Localizable(false)]string query, [Localizable(false)]string keywords = null)
        {
            try
            {
                LogConsumer.Info("Getting facets in bridge module that satisfy the condition '{0}'", query);
                var source = new CancellationTokenSource(new TimeSpan(0, 5, 0));
                var queryString = new Dictionary<string, string>
                {
                    {@"_facets", @"Origin,Status"},
                    {@"_where", query}
                };
                if (!string.IsNullOrWhiteSpace(keywords))
                    queryString.Add(@"_keywords", $@"*{keywords}*");
                var json = _wrapper.ServiceInvokerAsync(
                                                        HttpRequestMethod.GET,
                                                        $"{PlatformConstants.BRIDGE_SEARCH}/facets",
                                                        source.Token,
                                                        queryString,
                                                        restEndpoint: RequestEndpoint.BRIDGE).Result;
                return SerializerFactory.GetSerializer<List<BridgeFacet>>().Deserialize(json);
            }
            catch (Exception e)
            {
                throw new BridgeException(query, e);
            }
        }

        /// <summary>
        /// Gets the bridge items.
        /// </summary>
        /// <param name="query">The query.</param>
        /// <param name="sort">The sort.</param>
        /// <param name="keywords">The keywords.</param>
        /// <param name="offSet">The off set.</param>
        /// <param name="limit">The limit.</param>
        /// <returns>IEnumerable&lt;BridgeItem&gt;.</returns>
        /// <exception cref="BridgeException"></exception>
        [Pure]
        public IEnumerable<BridgeItem> GetBridgeItems(
            [Localizable(false)] string query,
            [Localizable(false)] string sort,
            [Localizable(false)] string keywords,
            int offSet,
            int limit)
        {
            try
            {
                LogConsumer.Info("Getting {0} items from {1} in bridge module that satisfy the condition '{2}'", limit, offSet, query);
                if (offSet >= 10000)
                {
                    LogConsumer.Warning("Cannot get more than 10000 items from Bridge / Master Data (VTEX Elastic Search limitation)");
                    return new List<BridgeItem>();
                }
                var source = new CancellationTokenSource(new TimeSpan(0, 5, 0));
                var queryString = new Dictionary<string, string>
                {
                    {@"_where", query},
                    {@"_sort", sort},
                    {@"offSet", offSet.ToString()},
                    {@"limit", limit.ToString()}
                };
                if (!string.IsNullOrWhiteSpace(keywords))
                    queryString.Add(@"_keywords", $@"*{keywords}*");
                var json = _wrapper.ServiceInvokerAsync(HttpRequestMethod.GET,
                                                        PlatformConstants.BRIDGE_SEARCH,
                                                        source.Token,
                                                        queryString,
                                                        restEndpoint: RequestEndpoint.BRIDGE).Result;
                return SerializerFactory.GetSerializer<List<BridgeItem>>().Deserialize(json);
            }
            catch (AggregateException e)
            {
                throw new BridgeException(query, e.InnerExceptions.FirstOrDefault() ?? e.InnerException ?? e);
            }
            catch (Exception e)
            {
                throw new BridgeException(query, e);
            }
        }

        /// <summary>
        /// Gets all bridge items.
        /// </summary>
        /// <param name="query">The query.</param>
        /// <param name="sort">The sort.</param>
        /// <param name="keywords">The keywords.</param>
        /// <param name="facetName">Name of the facet.</param>
        /// <param name="facetValue">The facet value.</param>
        /// <returns></returns>
        [Pure]
        public IEnumerable<BridgeItem> GetAllBridgeItems(
            [Localizable(false)] string query,
            [Localizable(false)] string sort,
            [Localizable(false)] string keywords,
            [Localizable(false)] string facetName,
            [Localizable(false)] string facetValue)
        {
            const int perPage = 100;
            var facets = GetBridgeFacets(query, keywords);
            var total = facets.Single(f => f.Field.Equals(facetName)).Facets[facetValue].ToInt32();

            var result = new List<BridgeItem>(total);
            var pages = total / perPage + 1;
            for (var x = 0; x < pages; x++)
                result.AddRange(GetBridgeItems(query, sort, keywords, x * perPage, perPage));
            return result;
        }

        #endregion

        #region Platform status

        /// <summary>
        /// Gets the platform status.
        /// </summary>
        /// <returns></returns>
        public IEnumerable<PlatformStatus> GetPlatformStatus()
        {
            return GetPlatformStatusAsync(CancellationToken.None).Result;
        }

        /// <summary>
        /// Gets the platform status asynchronous.
        /// </summary>
        /// <param name="token">The token.</param>
        /// <returns></returns>
        [Pure]
        public async Task<IEnumerable<PlatformStatus>> GetPlatformStatusAsync(CancellationToken token)
        {
            LogConsumer.Info("Getting platform status");
            var json = await _wrapper.ServiceInvokerAsync(HttpRequestMethod.GET, string.Empty, token, restEndpoint: RequestEndpoint.HEALTH)
                                     .ConfigureAwait(false);
            var status = SerializerFactory.GetSerializer<List<PlatformStatus>>().Deserialize(json);
            LogConsumer.Debug(status, "vtex-platform-status.js");
            return status;
        }

        #endregion

        #region Order payments

        /// <summary>
        /// Gets the order payments.
        /// </summary>
        /// <param name="transactionId">The transaction identifier.</param>
        /// <returns></returns>
        [Pure]
        public List<PCIPayment> GetOrderPayments(string transactionId)
        {
            var json = _wrapper.ServiceInvokerAsync(HttpRequestMethod.GET,
                $"{PlatformConstants.PCI_TRANSACTIONS}/{transactionId}/payments",
                CancellationToken.None,
                restEndpoint: RequestEndpoint.PAYMENTS).Result;
            if (json == null)
                return new List<PCIPayment>();
            var data = SerializerFactory.GetCustomSerializer<List<PCIPayment>>(SerializerFormat.JSON).Deserialize(json);
            LogConsumer.Debug(data, $"vtex-order-payemnts-{transactionId}.js");
            return data;
        }

        #endregion

        #region Catalog

        #region Specification

        /// <summary>
        /// Gets the specification field asynchronous.
        /// </summary>
        /// <param name="fieldId">The field identifier.</param>
        /// <param name="token">The token.</param>
        /// <returns></returns>
        [Pure]
        public async Task<SpecificationField> GetSpecificationFieldAsync(int fieldId, CancellationToken token)
        {
            LogConsumer.Info("Getting field for the field id {0}", fieldId);
            var json = await _wrapper.ServiceInvokerAsync(
                                                          HttpRequestMethod.GET,
                                                          $@"{PlatformConstants.CATALOG_PUB}/specification/fieldGet/{fieldId}",
                                                          token)
                                     .ConfigureAwait(false);
            var field = SerializerFactory.GetSerializer<SpecificationField>().Deserialize(json);
            LogConsumer.Debug(field, $"vtex-specification-field-{fieldId}.js");
            return field;
        }

        /// <summary>
        /// Gets the specification field values asynchronous.
        /// </summary>
        /// <param name="fieldId">The field identifier.</param>
        /// <param name="token">The token.</param>
        /// <returns></returns>
        [Pure]
        public async Task<ICollection<SpecificationFieldValue>> GetSpecificationFieldValuesAsync(
            int fieldId,
            CancellationToken token)
        {
            LogConsumer.Info("Getting field values for the field id {0}", fieldId);
            var json = await _wrapper.ServiceInvokerAsync(
                                                          HttpRequestMethod.GET,
                                                          $@"{PlatformConstants.CATALOG_PUB}/specification/fieldvalue/{fieldId}",
                                                          token)
                                     .ConfigureAwait(false);
            var fieldValues = SerializerFactory.GetSerializer<List<SpecificationFieldValue>>().Deserialize(json);
            LogConsumer.Debug(fieldValues, $"vtex-specification-values-{fieldId}.js");
            return fieldValues;
        }

        /// <summary>
        /// Updates the product specification asynchronous.
        /// </summary>
        /// <param name="specification">The specification.</param>
        /// <param name="productId">The product identifier.</param>
        /// <param name="token">The token.</param>
        /// <returns></returns>
        public async Task UpdateProductSpecificationAsync(
            Specification specification,
            int productId,
            CancellationToken token)
        {
            await UpdateProductSpecificationsAsync(new List<Specification>(new[] { specification }), productId, token)
                .ConfigureAwait(false);
        }

        /// <summary>
        /// Updates the product specifications asynchronous.
        /// </summary>
        /// <param name="specifications">The specifications list.</param>
        /// <param name="productId">The product identifier.</param>
        /// <param name="token">The token.</param>
        /// <returns></returns>
        public async Task UpdateProductSpecificationsAsync(
            List<Specification> specifications,
            int productId,
            CancellationToken token)
        {
            LogConsumer.Info("Updating the specifications {1} of product {0}",
                             productId,
                             string.Join(@",", specifications.Select(s => s.Id)));

            var data = (string)specifications.GetSerializer();
            await _wrapper.ServiceInvokerAsync(
                                               HttpRequestMethod.POST,
                                               $@"{PlatformConstants.CATALOG}/products/{productId}/specification",
                                               token,
                                               data: data)
                          .ConfigureAwait(false);

        }

        /// <summary>
        /// Inserts the specification field value asynchronous.
        /// </summary>
        /// <param name="fieldValue">The field value.</param>
        /// <param name="token">The token.</param>
        /// <returns></returns>
        public async Task InsertSpecificationFieldValueAsync(SpecificationFieldValue fieldValue, CancellationToken token)
        {
            LogConsumer.Info("Creating field value of field id {0}", fieldValue.FieldId);
            var data = (string)fieldValue.GetSerializer();
            await _wrapper.ServiceInvokerAsync(
                                               HttpRequestMethod.POST,
                                               $@"{PlatformConstants.CATALOG}/specification/fieldValue",
                                               token,
                                               data: data)
                          .ConfigureAwait(false);

        }

        #endregion

        #endregion

        #region Master data

        #region Search 

        /// <summary>
        /// Searches the asynchronous.
        /// </summary>
        /// <typeparam name="TDataEntity">The type of the data entity.</typeparam>
        /// <param name="searchedField">The searched field.</param>
        /// <param name="searchedValue">The searched value.</param>
        /// <param name="token">The token.</param>
        /// <returns></returns>
        [Pure]
        public async Task<TDataEntity> SearchAsync<TDataEntity>(
             string searchedField,
             string searchedValue,
             CancellationToken token)
             where TDataEntity : class, IDataEntity, new()
        {
            if (string.IsNullOrWhiteSpace(searchedValue))
                throw new ArgumentNullException(nameof(searchedValue));

            var queryString = new Dictionary<string, string>
            {
                { searchedField, searchedValue },
                { @"_fields", @"_all"}
            };
            var json = string.Empty;
            try
            {
                var entityName = typeof(TDataEntity).GetDataEntityName();
                json = await _wrapper.ServiceInvokerAsync(
                                                          HttpRequestMethod.GET,
                                                          $@"dataentities/{entityName}/search/",
                                                          token,
                                                          queryString,
                                                          restEndpoint: RequestEndpoint.MASTER_DATA)
                                     .ConfigureAwait(false);
                var entity = SerializerFactory.GetSerializer<List<TDataEntity>>().Deserialize(json).FirstOrDefault();
                if (entity == null)
                    return null;
                LogConsumer.Debug(entity, $@"vtex-masterdata-entity-{entityName}-{searchedField}-{searchedValue}.js");
                return entity;
            }
            catch (Exception e)
            {
                throw new UnexpectedApiResponseException(json, e);
            }
        }

        #endregion

        #endregion

        #endregion

        #region IDisposable

        /// <summary>Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.</summary>
        public void Dispose()
        {
            _wrapper.Dispose();
        }

        #endregion
    }
}