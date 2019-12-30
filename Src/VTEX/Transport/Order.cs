namespace VTEX.Transport
{
    using CrispyWaffle.Extensions;
    using CrispyWaffle.Serialization;
    using Enums;
    using Newtonsoft.Json;
    using System;

    /// <summary>
    /// An order.
    /// </summary>
    [Serializer(SerializerFormat.JSON)]
    public sealed class Order
    {
        /// <summary>
        /// Gets or sets the email tracked.
        /// </summary>
        /// <value>
        /// The email tracked.
        /// </value>
        [JsonProperty("emailTracked")]
        public string EmailTracked { get; set; }

        /// <summary>
        /// Gets or sets the cancel reason.
        /// </summary>
        /// <value>
        /// The cancel reason.
        /// </value>
        [JsonProperty("cancelReason")]
        public string CancelReason { get; set; }

        /// <summary>
        /// Gets or sets the cancelled by.
        /// </summary>
        /// <value>
        /// The cancelled by.
        /// </value>
        [JsonProperty("cancelledBy")]
        public string CancelledBy { get; set; }

        /// <summary>
        /// Gets or sets the identifier of the order.
        /// </summary>
        /// <value>The identifier of the order.</value>

        [JsonProperty("orderId")]
        public string OrderId { get; set; }

        /// <summary>
        /// Gets or sets the sequence.
        /// </summary>
        /// <value>The sequence.</value>

        [JsonProperty("sequence")]
        public int Sequence { get; set; }

        /// <summary>
        /// Gets or sets the identifier of the marketplace order.
        /// </summary>
        /// <value>The identifier of the marketplace order.</value>

        [JsonProperty("marketplaceOrderId")]
        public string MarketplaceOrderId { get; set; }

        /// <summary>
        /// Gets or sets the marketplace services endpoint.
        /// </summary>
        /// <value>
        /// The marketplace services endpoint.
        /// </value>
        [JsonProperty("marketplaceServicesEndpoint")]
        public string MarketplaceServicesEndpoint { get; set; }

        /// <summary>
        /// Gets or sets the identifier of the seller order.
        /// </summary>
        /// <value>The identifier of the seller order.</value>

        [JsonProperty("sellerOrderId")]
        public string SellerOrderId { get; set; }

        /// <summary>
        /// Gets or sets the origin.
        /// </summary>
        /// <value>
        /// The origin.
        /// </value>
        [JsonProperty("origin")]
        public string Origin { get; set; }

        /// <summary>
        /// Gets or sets the identifier of the affiliate.
        /// </summary>
        /// <value>The identifier of the affiliate.</value>

        [JsonProperty("affiliateId")]
        public string AffiliateId { get; set; }

        /// <summary>
        /// Gets or sets the sales channel.
        /// </summary>
        /// <value>The sales channel.</value>

        [JsonProperty("salesChannel")]
        public int SalesChannel { get; set; }

        /// <summary>
        /// Gets or sets the name of the merchant.
        /// </summary>
        /// <value>
        /// The name of the merchant.
        /// </value>
        [JsonProperty("merchantName")]
        public string MerchantName { get; set; }

        /// <summary>
        /// Gets or sets the status.
        /// </summary>
        /// <value>The status.</value>

        [JsonProperty("status")]
        public string StatusInternal { get; set; }

        /// <summary>
        /// Gets the status pedido.
        /// </summary>
        /// <value>The status pedido.</value>

        [JsonIgnore]
        public OrderStatus Status => EnumExtensions.GetEnumByInternalValueAttribute<OrderStatus>(StatusInternal);

        /// <summary>
        /// Gets or sets information describing the status.
        /// </summary>
        /// <value>Information describing the status.</value>

        [JsonProperty("statusDescription")]
        public string StatusDescription { get; set; }

        /// <summary>
        /// Gets or sets the value.
        /// </summary>
        /// <value>The value.</value>

        [JsonProperty("value")]
        public int Value { get; set; }

        /// <summary>
        /// The creation date
        /// </summary>
        private DateTimeOffset _creationDate;

        /// <summary>
        /// Gets or sets the creation date.
        /// </summary>
        /// <value>The creation date.</value>

        [JsonProperty("creationDate")]
        public DateTime CreationDate
        {
            get => _creationDate.LocalDateTime;
            set => _creationDate = value;
        }

        /// <summary>
        /// The last change
        /// </summary>
        private DateTimeOffset _lastChange;

        /// <summary>
        /// Gets or sets the Date/Time of the last change.
        /// </summary>
        /// <value>The last change.</value>

        [JsonProperty("lastChange")]
        public DateTime LastChange
        {
            get => _lastChange.LocalDateTime;
            set => _lastChange = value;
        }

        /// <summary>
        /// Gets or sets the order group.
        /// </summary>
        /// <value>
        /// The order group.
        /// </value>
        [JsonProperty("orderGroup")]
        public string OrderGroup { get; set; }

        /// <summary>
        /// Gets or sets the totals.
        /// </summary>
        /// <value>The total number of s.</value>

        [JsonProperty("totals")]
        public Total[] Totals { get; set; }

        /// <summary>
        /// Gets or sets the items.
        /// </summary>
        /// <value>The items.</value>

        [JsonProperty("items")]
        public Item[] Items { get; set; }

        /// <summary>
        /// Gets or sets the marketplace items.
        /// </summary>
        /// <value>
        /// The marketplace items.
        /// </value>
        [JsonProperty("marketplaceItems")]
        public NotNullObserver[] MarketplaceItems { get; set; }

        /// <summary>
        /// Gets or sets information describing the client profile.
        /// </summary>
        /// <value>Information describing the client profile.</value>

        [JsonProperty("clientProfileData")]
        public ClientProfileData ClientProfileData { get; set; }

        /// <summary>
        /// Gets or sets the gift registry data.
        /// </summary>
        /// <value>
        /// The gift registry data.
        /// </value>
        [JsonProperty("giftRegistryData")]
        public NotNullObserver GiftRegistryData { get; set; }

        /// <summary>
        /// Gets or sets information describing the marketing.
        /// </summary>
        /// <value>Information describing the marketing.</value>

        [JsonProperty("marketingData")]
        public MarketingData MarketingData { get; set; }

        /// <summary>
        /// Gets or sets information describing the rates and benefits.
        /// </summary>
        /// <value>Information describing the rates and benefits.</value>

        [JsonProperty("ratesAndBenefitsData")]
        public RatesAndBenefitsData RatesAndBenefitsData { get; set; }

        /// <summary>
        /// Gets or sets information describing the shipping.
        /// </summary>
        /// <value>Information describing the shipping.</value>

        [JsonProperty("shippingData")]
        public ShippingData ShippingData { get; set; }

        /// <summary>
        /// Gets or sets information describing the payment.
        /// </summary>
        /// <value>Information describing the payment.</value>

        [JsonProperty("paymentData")]
        public PaymentData PaymentData { get; set; }

        /// <summary>
        /// Gets or sets the package attachment.
        /// </summary>
        /// <value>The package attachment.</value>

        [JsonProperty("packageAttachment")]
        public PackageAttachment PackageAttachment { get; set; }

        /// <summary>
        /// Gets or sets the sellers.
        /// </summary>
        /// <value>The sellers.</value>

        [JsonProperty("sellers")]
        public Seller[] Sellers { get; set; }

        /// <summary>
        /// Gets or sets information describing the call center operator.
        /// </summary>
        /// <value>Information describing the call center operator.</value>

        [JsonProperty("callCenterOperatorData")]
        public CallCenterOperatorData CallCenterOperatorData { get; set; }

        /// <summary>
        /// Gets or sets the follow up email.
        /// </summary>
        /// <value>
        /// The follow up email.
        /// </value>
        [JsonProperty("followUpEmail")]
        public string FollowUpEmail { get; set; }

        /// <summary>
        /// Gets or sets the last message.
        /// </summary>
        /// <value>
        /// The last message.
        /// </value>
        [JsonProperty("lastMessage")]
        public string LastMessage { get; set; }

        /// <summary>
        /// Gets or sets the hostname.
        /// </summary>
        /// <value>
        /// The hostname.
        /// </value>
        [JsonProperty("hostname")]
        public string Hostname { get; set; }

        /// <summary>
        /// Gets or sets the changes attachment.
        /// </summary>
        /// <value>
        /// The changes attachment.
        /// </value>
        [JsonProperty("changesAttachment")]
        public ChangesAttachment ChangesAttachment { get; set; }

        /// <summary>
        /// Gets or sets the open text field.
        /// </summary>
        /// <value>The open text field.</value>
        [JsonProperty("openTextField")]
        public OpenTextField OpenTextField { get; set; }

        /// <summary>
        /// Gets or sets the rounding error.
        /// </summary>
        /// <value>
        /// The rounding error.
        /// </value>
        [JsonProperty("roundingError")]
        public int RoundingError { get; set; }

        /// <summary>
        /// Gets or sets the order form identifier.
        /// </summary>
        /// <value>
        /// The order form identifier.
        /// </value>
        [JsonProperty("orderFormId")]
        public string OrderFormId { get; set; }

        /// <summary>
        /// Gets or sets the comercial condition data.
        /// </summary>
        /// <value>
        /// The comercial condition data.
        /// </value>
        [JsonProperty("comercialConditionData")]
        public NotNullObserver ComercialConditionData { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this instance is completed.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this instance is completed; otherwise, <c>false</c>.
        /// </value>
        [JsonProperty("isCompleted")]
        public bool IsCompleted { get; set; }

        /// <summary>
        /// Gets or sets the custom data.
        /// </summary>
        /// <value>
        /// The custom data.
        /// </value>
        [JsonProperty("customData")]
        public NotNullObserver CustomData { get; set; }

        /// <summary>
        /// Gets or sets the store preferences data.
        /// </summary>
        /// <value>
        /// The store preferences data.
        /// </value>
        [JsonProperty("storePreferencesData")]
        public StorePreferenceData StorePreferencesData { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [allow cancellation].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [allow cancellation]; otherwise, <c>false</c>.
        /// </value>
        [JsonProperty("allowCancellation")]
        public bool AllowCancellation { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [allow edition].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [allow edition]; otherwise, <c>false</c>.
        /// </value>
        [JsonProperty("allowEdition")]
        public bool AllowEdition { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this instance is checked in.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this instance is checked in; otherwise, <c>false</c>.
        /// </value>
        [JsonProperty("isCheckedIn")]
        public bool IsCheckedIn { get; set; }

        /// <summary>
        /// Gets or sets the marketplace.
        /// </summary>
        /// <value>
        /// The marketplace.
        /// </value>
        [JsonProperty("marketplace")]
        public Marketplace Marketplace { get; set; }

        /// <summary>
        /// Gets or sets the commercial condition data.
        /// </summary>
        /// <value>
        /// The commercial condition data.
        /// </value>
        [JsonProperty("commercialConditionData")]
        public NotNullObserver CommercialConditionData { get; set; }

        /// <summary>
        /// Gets or sets the invoice data.
        /// </summary>
        /// <value>
        /// The invoice data.
        /// </value>
        [JsonProperty("invoiceData")]
        public NotNullObserver InvoiceData { get; set; }

        /// <summary>
        /// Gets or sets the invoiced date.
        /// </summary>
        /// <value>
        /// The invoiced date.
        /// </value>
        [JsonProperty("invoicedDate")]
        public DateTime? InvoicedDate { get; set; }

        /// <summary>
        /// Gets or sets the approved by.
        /// </summary>
        /// <value>
        /// The approved by.
        /// </value>
        [JsonProperty("approvedBy")]
        public NotNullObserver ApprovedBy { get; set; }

        /// <summary>
        /// Gets or sets the authorized date.
        /// </summary>
        /// <value>
        /// The authorized date.
        /// </value>
        [JsonProperty("authorizedDate")]
        public DateTime AuthorizedDate { get; set; }

    }
}
