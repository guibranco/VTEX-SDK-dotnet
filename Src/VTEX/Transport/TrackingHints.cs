// ***********************************************************************
// Assembly         : GuiStracini.Mandae
// Author           : Guilherme Branco Stracini
// Created          : 2017-10-02
//
// Last Modified By : Guilherme Branco Stracini
// Last Modified On : 2018-11-24
// ***********************************************************************
// <copyright file="TrackingHints.cs" company="Editora Inovação LTDA">
//     Copyright © 2017 - 2018 Guilherme Branco Stracini
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

        [JsonProperty("courierName")]
        public string CourierName { get; set; }

        /// <summary>
        /// The tracking id
        /// </summary>

        [JsonProperty("trackingId")]
        public long TrackingId { get; set; }

        /// <summary>
        /// The tracking label
        /// </summary>

        [JsonProperty("trackingLabel")]
        public string TrackingLabel { get; set; }

        /// <summary>
        /// The tracking url
        /// </summary>

        [JsonProperty("trackingUrl")]
        public string TrackingUrl { get; set; }
    }
}
