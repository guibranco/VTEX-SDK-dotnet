// ***********************************************************************
// Assembly         : VTEX
// Author           : Guilherme Branco Stracini
// Created          : 01-15-2023
//
// Last Modified By : Guilherme Branco Stracini
// Last Modified On : 01-16-2023
// ***********************************************************************
// <copyright file="RatesAndBenefitsData.cs" company="Guilherme Branco Stracini">
//     © 2020 Guilherme Branco Stracini. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
namespace VTEX.Transport
{
    using Newtonsoft.Json;

    /// <summary>
    /// The rates and benefits data.
    /// </summary>
    public sealed class RatesAndBenefitsData
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>The identifier.</value>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets a list of identifiers of the rate and benefits.
        /// </summary>
        /// <value>A list of identifiers of the rate and benefits.</value>
        [JsonProperty("rateAndBenefitsIdentifiers")]
        public RateAndBenefitsIdentifiers[] RateAndBenefitsIdentifiers { get; set; }
    }
}
