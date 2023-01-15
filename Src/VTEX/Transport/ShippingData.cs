// ***********************************************************************
// Assembly         : VTEX
// Author           : Guilherme Branco Stracini
// Created          : 01-15-2023
//
// Last Modified By : Guilherme Branco Stracini
// Last Modified On : 01-15-2023
// ***********************************************************************
// <copyright file="ShippingData.cs" company="Guilherme Branco Stracini">
//     © 2020 Guilherme Branco Stracini. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
namespace VTEX.Transport
{
    using Newtonsoft.Json;

    /// <summary>
    /// A shipping data.
    /// </summary>
    public sealed class ShippingData
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>The identifier.</value>

        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the address.
        /// </summary>
        /// <value>The address.</value>

        [JsonProperty("address")]
        public Address Address { get; set; }

        /// <summary>
        /// Gets or sets information describing the logistics.
        /// </summary>
        /// <value>Information describing the logistics.</value>

        [JsonProperty("logisticsInfo")]
        public LogisticsInfo[] LogisticsInfo { get; set; }

        /// <summary>
        /// Gets or sets the information describing the tracking hits
        /// </summary>
        /// <value>Information describing the tracking hits</value>
        [JsonProperty("trackingHints")]
        public TrackingHints[] TrackingHints { get; set; }

        /// <summary>
        /// Gets or sets the selected addresses.
        /// </summary>
        /// <value>The selected addresses.</value>
        [JsonProperty("selectedAddresses")]
        public Address[] SelectedAddresses { get; set; }
    }
}