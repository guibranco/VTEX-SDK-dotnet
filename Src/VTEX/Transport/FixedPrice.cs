// ***********************************************************************
// Assembly         : VTEX
// Author           : Guilherme Branco Stracini
// Created          : 01-15-2023
//
// Last Modified By : Guilherme Branco Stracini
// Last Modified On : 01-16-2023
// ***********************************************************************
// <copyright file="FixedPrice.cs" company="Guilherme Branco Stracini">
//     © 2020 Guilherme Branco Stracini. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
namespace VTEX.Transport
{
    using Newtonsoft.Json;

    /// <summary>
    /// The fixed price class.
    /// This class cannot be inherited.
    /// </summary>
    public sealed class FixedPrice
    {
        /// <summary>
        /// Gets or sets the trade policy identifier.
        /// </summary>
        /// <value>The trade policy identifier.</value>
        [JsonProperty("tradePolicyId")]
        public string TradePolicyId { get; set; }

        /// <summary>
        /// Gets or sets the value.
        /// </summary>
        /// <value>The value.</value>
        [JsonProperty("value")]
        public decimal Value { get; set; }

        /// <summary>
        /// Gets or sets the list price.
        /// </summary>
        /// <value>The list price.</value>
        [JsonProperty("listPrice")]
        public decimal? ListPrice { get; set; }

        /// <summary>
        /// Gets or sets the minimum quantity.
        /// </summary>
        /// <value>The minimum quantity.</value>
        [JsonProperty("minQuantity")]
        public int MinQuantity { get; set; }

        /// <summary>
        /// Gets or sets the date range.
        /// </summary>
        /// <value>The date range.</value>
        [JsonProperty("dateRange")]
        public DateRange DateRange { get; set; }
    }
}
