// ***********************************************************************
// Assembly         : VTEX
// Author           : Guilherme Branco Stracini
// Created          : 01-15-2023
//
// Last Modified By : Guilherme Branco Stracini
// Last Modified On : 01-16-2023
// ***********************************************************************
// <copyright file="ShippingNotificationPatch.cs" company="Guilherme Branco Stracini">
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
    /// Class ShippingNotificationPatch. This class cannot be inherited.
    /// </summary>
    [Serializer(SerializerFormat.Json)]
    public sealed class ShippingNotificationPatch
    {
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
        /// Gets or sets the courier.
        /// </summary>
        /// <value>The courier.</value>

        [JsonProperty("courier")]
        public string Courier { get; set; }

        /// <summary>
        /// Gets or sets the dispatched date.
        /// </summary>
        /// <value>The dispatched date.</value>
        [JsonProperty("dispatchedDate")]
        public DateTime? DispatchedDate { get; set; }
    }
}
