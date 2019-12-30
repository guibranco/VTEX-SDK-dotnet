// ***********************************************************************
// Assembly         : IntegracaoService.VTEX
// Author           : Guilherme Branco Stracini
// Created          : 02-10-2017
//
// Last Modified By : Guilherme Branco Stracini
// Last Modified On : 02-10-2017
// ***********************************************************************
// <copyright file="ShippingNotificationPatch.cs" company="Guilherme Branco Stracini ME">
//     © 2011-2019 Guilherme Branco Stracini, All Rights Reserved
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
    [Serializer(SerializerFormat.JSON)]
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
