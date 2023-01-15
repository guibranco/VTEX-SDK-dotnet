// ***********************************************************************
// Assembly         : VTEX
// Author           : Guilherme Branco Stracini
// Created          : 01-15-2023
//
// Last Modified By : Guilherme Branco Stracini
// Last Modified On : 01-15-2023
// ***********************************************************************
// <copyright file="ShippingNotificationPatch.cs" company="Guilherme Branco Stracini">
//     © 2020 Guilherme Branco Stracini. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
namespace VTEX.Transport
{
    using CrispyWaffle.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// Class ShippingNotificationPatch. This class cannot be inherited.
    /// </summary>
    [Serializer(SerializerFormat.Json)]
    public sealed class ShippingNotificationPatch
    {
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
    }
}
