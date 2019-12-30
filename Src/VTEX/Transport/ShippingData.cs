// ***********************************************************************
// Assembly         : GuiStracini.Mandae
// Author           : Guilherme Branco Stracini
// Created          : 19/12/2013
//
// Last Modified By : Guilherme Branco Stracini
// Last Modified On : 02/10/2017
// ***********************************************************************
// <copyright file="" company="Editora Inovação LTDA">
//     Copyright © 2017 Guilherme Branco Stracini
// </copyright>
// <summary></summary>
// ***********************************************************************

namespace VTEX.Transport
{
    using Newtonsoft.Json;

    /// <summary>
    /// 	A shipping data.
    /// </summary>
    ///
    /// <remarks>
    /// 	Versão: 1.61.3637.731
    /// 	Autor: Guilherme Branco Stracini
    /// 	Data: 02/06/2014.
    /// </remarks>

    public sealed class ShippingData
    {
        /// <summary>
        /// 	Gets or sets the identifier.
        /// </summary>
        ///
        /// <value>
        /// 	The identifier.
        /// </value>

        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// 	Gets or sets the address.
        /// </summary>
        ///
        /// <value>
        /// 	The address.
        /// </value>

        [JsonProperty("address")]
        public Address Address { get; set; }

        /// <summary>
        /// 	Gets or sets information describing the logistics.
        /// </summary>
        ///
        /// <value>
        /// 	Information describing the logistics.
        /// </value>

        [JsonProperty("logisticsInfo")]
        public LogisticsInfo[] LogisticsInfo { get; set; }

        /// <summary>
        ///     Gets or sets the information describing the tracking hits
        /// </summary>
        /// 
        /// <value>
        ///     Information describing the tracking hits
        /// </value>
        [JsonProperty("trackingHints")]
        public TrackingHints[] TrackingHints { get; set; }

        /// <summary>
        /// Gets or sets the selected addresses.
        /// </summary>
        /// <value>
        /// The selected addresses.
        /// </value>
        [JsonProperty("selectedAddresses")]
        public Address[] SelectedAddresses { get; set; }
    }
}