// ***********************************************************************
// Assembly         : VTEX
// Author           : Guilherme Branco Stracini
// Created          : 01-15-2023
//
// Last Modified By : Guilherme Branco Stracini
// Last Modified On : 01-16-2023
// ***********************************************************************
// <copyright file="TrackingHints.cs" company="Guilherme Branco Stracini">
//     © 2020 Guilherme Branco Stracini. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
namespace VTEX.Transport
{
    using Newtonsoft.Json;

    /// <summary>
    /// The tracking hints data (used by the Mercado Livre / ME2 (Mercado Envios 2) integration
    /// The tracking url redirects to the PDF tag for printing
    /// </summary>
    public sealed class TrackingHints
    {
        /// <summary>
        /// The courier name
        /// </summary>
        /// <value>The name of the courier.</value>
        [JsonProperty("courierName")]
        public string CourierName { get; set; }

        /// <summary>
        /// The tracking id
        /// </summary>
        /// <value>The tracking identifier.</value>
        [JsonProperty("trackingId")]
        public long TrackingId { get; set; }

        /// <summary>
        /// The tracking label
        /// </summary>
        /// <value>The tracking label.</value>
        [JsonProperty("trackingLabel")]
        public string TrackingLabel { get; set; }

        /// <summary>
        /// The tracking url
        /// </summary>
        /// <value>The tracking URL.</value>
        [JsonProperty("trackingUrl")]
        public string TrackingUrl { get; set; }
    }
}
