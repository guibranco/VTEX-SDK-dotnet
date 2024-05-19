// ***********************************************************************
// Assembly         : VTEX
// Author           : Guilherme Branco Stracini
// Created          : 01-15-2023
//
// Last Modified By : Guilherme Branco Stracini
// Last Modified On : 01-16-2023
// ***********************************************************************
// <copyright file="Package.cs" company="Guilherme Branco Stracini">
//     © 2020 Guilherme Branco Stracini. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
namespace VTEX.Transport
{
    using CrispyWaffle.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// Class Package. This class cannot be inherited.
    /// </summary>
    public sealed class Package
    {
        /// <summary>
        /// Gets or sets the type.
        /// </summary>
        /// <value>The type.</value>
        [JsonProperty("type")]
        public string Type { get; set; }

        /// <summary>
        /// Gets or sets the invoice number.
        /// </summary>
        /// <value>The invoice number.</value>
        [JsonProperty("invoiceNumber")]
        public string InvoiceNumber { get; set; }

        /// <summary>
        /// Gets or sets the invoice value.
        /// </summary>
        /// <value>The invoice value.</value>
        [JsonProperty("invoiceValue")]
        public int InvoiceValue { get; set; }

        /// <summary>
        /// Gets or sets the Key of the invoice.
        /// </summary>
        /// <value>The invoice key.</value>
        [JsonProperty("invoiceKey")]
        public string InvoiceKey { get; set; }

        /// <summary>
        /// Gets or sets URL of the invoice.
        /// </summary>
        /// <value>The invoice URL.</value>
        [JsonProperty("invoiceUrl")]
        public string InvoiceUrl { get; set; }

        /// <summary>
        /// Gets or sets the courier.
        /// </summary>
        /// <value>The courier.</value>
        [JsonProperty("courier")]
        public string Courier { get; set; }

        /// <summary>
        /// Gets or sets the tracking number.
        /// </summary>
        /// <value>The tracking number.</value>
        [JsonProperty("trackingNumber")]
        public string TrackingNumber { get; set; }

        /// <summary>
        /// Gets or sets the tracking url.
        /// </summary>
        /// <value>The tracking url.</value>
        [JsonProperty("trackingUrl")]
        public string TrackingUrl { get; set; }

        /// <summary>
        /// Gets or sets the issuance date.
        /// </summary>
        /// <value>The issuance date.</value>
        [JsonProperty("issuanceDate")]
        public string IssuanceDate { get; set; }

        /// <summary>
        /// Gets or sets the embedded invoice.
        /// </summary>
        /// <value>The embedded invoice.</value>
        [JsonProperty("embeddedInvoice")]
        public NotNullObserver EmbeddedInvoice { get; set; }

        /// <summary>
        /// Gets or sets the courier status.
        /// </summary>
        /// <value>The courier status.</value>
        [JsonProperty("courierStatus")]
        public CourierStatus CourierStatus { get; set; }

        /// <summary>
        /// Gets or sets the cfop.
        /// </summary>
        /// <value>The cfop.</value>
        [JsonProperty("cfop")]
        public NotNullObserver Cfop { get; set; }

        /// <summary>
        /// Gets or sets the items.
        /// </summary>
        /// <value>The items.</value>
        public ItemOfPackage[] Items { get; set; }

        /// <summary>
        /// Gets or sets the refunds.
        /// </summary>
        /// <value>The refunds.</value>
        [JsonProperty("restitutions")]
        public NotNullObserver Refunds { get; set; }

        /// <summary>
        /// Gets or sets the volumes.
        /// </summary>
        /// <value>The volumes.</value>
        [JsonProperty("volumes")]
        public int Volumes { get; set; }
    }
}
