// ***********************************************************************
// Assembly         : VTEX
// Author           : Guilherme Branco Stracini
// Created          : 01-15-2023
//
// Last Modified By : Guilherme Branco Stracini
// Last Modified On : 01-16-2023
// ***********************************************************************
// <copyright file="List.cs" company="Guilherme Branco Stracini">
//     © 2020 Guilherme Branco Stracini. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
namespace VTEX.Transport
{
    using System;
    using CrispyWaffle.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The list class.
    /// </summary>
    public sealed class List
    {
        /// <summary>
        /// Gets or sets the identifier of the order.
        /// </summary>
        /// <value>The identifier of the order.</value>

        [JsonProperty("orderId")]
        public string OrderId { get; set; }

        /// <summary>
        /// Gets or sets the creation date.
        /// </summary>
        /// <value>The creation date.</value>

        [JsonProperty("creationDate")]
        public DateTime CreationDate { get; set; }

        /// <summary>
        /// Gets or sets the name of the client.
        /// </summary>
        /// <value>The name of the client.</value>

        [JsonProperty("clientName")]
        public string ClientName { get; set; }

        /// <summary>
        /// Gets or sets the items.
        /// </summary>
        /// <value>The items.</value>

        [JsonProperty("items")]
        public ListItem[] Items { get; set; }

        /// <summary>
        /// Gets or sets the total number of value.
        /// </summary>
        /// <value>The total number of value.</value>

        [JsonProperty("totalValue")]
        public decimal TotalValue { get; set; }

        /// <summary>
        /// Gets or sets a list of names of the payments.
        /// </summary>
        /// <value>A list of names of the payments.</value>

        [JsonProperty("paymentNames")]
        public string PaymentNames { get; set; }

        /// <summary>
        /// Gets or sets the status.
        /// </summary>
        /// <value>The status.</value>

        [JsonProperty("status")]
        public string Status { get; set; }

        /// <summary>
        /// Gets or sets information describing the status.
        /// </summary>
        /// <value>Information describing the status.</value>

        [JsonProperty("statusDescription")]
        public string StatusDescription { get; set; }

        /// <summary>
        /// Gets or sets the identifier of the market place order.
        /// </summary>
        /// <value>The identifier of the market place order.</value>

        [JsonProperty("marketPlaceOrderId")]
        public string MarketPlaceOrderId { get; set; }

        /// <summary>
        /// Gets or sets the sequence.
        /// </summary>
        /// <value>The sequence.</value>

        [JsonProperty("sequence")]
        public int Sequence { get; set; }

        /// <summary>
        /// Gets or sets the sales channel.
        /// </summary>
        /// <value>The sales channel.</value>

        [JsonProperty("salesChannel")]
        public int SalesChannel { get; set; }

        /// <summary>
        /// Gets or sets the identifier of the affiliate.
        /// </summary>
        /// <value>The identifier of the affiliate.</value>

        [JsonProperty("affiliateId")]
        public string AffiliateId { get; set; }

        /// <summary>
        /// Gets or sets the origin.
        /// </summary>
        /// <value>The origin.</value>

        [JsonProperty("origin")]
        public string Origin { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the workflow in error state.
        /// </summary>
        /// <value>true if workflow in error state, false if not.</value>

        [JsonProperty("workflowInErrorState")]
        public bool WorkflowInErrorState { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the workflow in retry.
        /// </summary>
        /// <value>true if workflow in retry, false if not.</value>

        [JsonProperty("workflowInRetry")]
        public bool WorkflowInRetry { get; set; }

        /// <summary>
        /// Gets or sets the last message unread.
        /// </summary>
        /// <value>The last message unread.</value>

        [JsonProperty("lastMessageUnread")]
        public string LastMessageUnread { get; set; }

        /// <summary>
        /// Gets or sets the shipping estimated date.
        /// </summary>
        /// <value>The shipping estimated date.</value>

        [JsonProperty("ShippingEstimatedDate")]
        public DateTime? ShippingEstimatedDate { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the order is complete.
        /// </summary>
        /// <value>true if order is complete, false if not.</value>

        [JsonProperty("orderIsComplete")]
        public bool OrderIsComplete { get; set; }

        /// <summary>
        /// Gets or sets the list identifier.
        /// </summary>
        /// <value>The list identifier.</value>
        [JsonProperty("listId")]
        public NotNullObserver ListId { get; set; }

        /// <summary>
        /// Gets or sets the type of the list.
        /// </summary>
        /// <value>The type of the list.</value>
        [JsonProperty("listType")]
        public NotNullObserver ListType { get; set; }

        /// <summary>
        /// Gets or sets the authorized date.
        /// </summary>
        /// <value>The authorized date.</value>
        [JsonProperty("authorizedDate")]
        public DateTime? AuthorizedDate { get; set; }

        /// <summary>
        /// Gets or sets the name of the call center operator.
        /// </summary>
        /// <value>The name of the call center operator.</value>
        [JsonProperty("callCenterOperatorName")]
        public string CallCenterOperatorName { get; set; }

        /// <summary>
        /// Gets or sets the total items.
        /// </summary>
        /// <value>The total items.</value>
        [JsonProperty("totalItems")]
        public int TotalItems { get; set; }

        /// <summary>
        /// Gets or sets the currency code.
        /// </summary>
        /// <value>The currency code.</value>
        [JsonProperty("currencyCode")]
        public string CurrencyCode { get; set; }

        /// <summary>
        /// Gets or sets the shipping estimated date maximum.
        /// </summary>
        /// <value>The shipping estimated date maximum.</value>
        [JsonProperty("shippingEstimatedDateMax")]
        public DateTime? ShippingEstimatedDateMax { get; set; }

        /// <summary>
        /// Gets or sets the shipping estimated date minimum.
        /// </summary>
        /// <value>The shipping estimated date minimum.</value>
        [JsonProperty("shippingEstimatedDateMin")]
        public DateTime? ShippingEstimatedDateMin { get; set; }

        /// <summary>
        /// Gets or sets the hostname.
        /// </summary>
        /// <value>The hostname.</value>
        [JsonProperty("hostname")]
        public string Hostname { get; set; }

        /// <summary>
        /// Gets or sets the invoice output.
        /// </summary>
        /// <value>The invoice output.</value>
        [JsonProperty("invoiceOutput")]
        public string[] InvoiceOutput { get; set; }

        /// <summary>
        /// Gets or sets the invoice input.
        /// </summary>
        /// <value>The invoice input.</value>
        [JsonProperty("invoiceInput")]
        public string[] InvoiceInput { get; set; }

    }
}