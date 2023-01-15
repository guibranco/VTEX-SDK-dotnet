// ***********************************************************************
// Assembly         : VTEX
// Author           : Guilherme Branco Stracini
// Created          : 01-15-2023
//
// Last Modified By : Guilherme Branco Stracini
// Last Modified On : 01-15-2023
// ***********************************************************************
// <copyright file="PriceTag.cs" company="Guilherme Branco Stracini">
//     © 2020 Guilherme Branco Stracini. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
namespace VTEX.Transport
{
    using Newtonsoft.Json;

    /// <summary>
    /// The price tag class.
    /// This class cannot be inherited.
    /// </summary>
    public sealed class PriceTag
    {
        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>The name.</value>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the value.
        /// </summary>
        /// <value>The value.</value>
        [JsonProperty("value")]
        public int Value { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this instance is percentual.
        /// </summary>
        /// <value><c>true</c> if this instance is percentual; otherwise, <c>false</c>.</value>
        [JsonProperty("isPercentual")]
        public bool IsPercentual { get; set; }

        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>The identifier.</value>
        [JsonProperty("identifier")]
        public string Identifier { get; set; }

        /// <summary>
        /// Gets or sets the raw value.
        /// </summary>
        /// <value>The raw value.</value>
        [JsonProperty("rawValue")]
        public decimal RawValue { get; set; }

    }
}
