// ***********************************************************************
// Assembly         : VTEX
// Author           : Guilherme Branco Stracini
// Created          : 01-15-2023
//
// Last Modified By : Guilherme Branco Stracini
// Last Modified On : 01-15-2023
// ***********************************************************************
// <copyright file="Marketplace.cs" company="Guilherme Branco Stracini">
//     © 2020 Guilherme Branco Stracini. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
namespace VTEX.Transport
{
    using CrispyWaffle.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The marketplace class.
    /// This class cannot be inherited.
    /// </summary>
    public sealed class Marketplace
    {
        /// <summary>
        /// Gets or sets the base URL.
        /// </summary>
        /// <value>The base URL.</value>
        [JsonProperty("baseURL")]
        public string BaseURL { get; set; }

        /// <summary>
        /// Gets or sets the is certificated.
        /// </summary>
        /// <value>The is certificated.</value>
        [JsonProperty("isCertificated")]
        public NotNullObserver IsCertificated { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>The name.</value>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this instance is certified.
        /// </summary>
        /// <value><c>true</c> if this instance is certified; otherwise, <c>false</c>.</value>
        [JsonProperty("isCertified")]
        public bool? IsCertified { get; set; }

    }
}
