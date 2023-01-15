// ***********************************************************************
// Assembly         : VTEX
// Author           : Guilherme Branco Stracini
// Created          : 01-15-2023
//
// Last Modified By : Guilherme Branco Stracini
// Last Modified On : 01-16-2023
// ***********************************************************************
// <copyright file="StatsItem.cs" company="Guilherme Branco Stracini">
//     © 2020 Guilherme Branco Stracini. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
namespace VTEX.Transport
{
    using Newtonsoft.Json;

    /// <summary>
    /// The stats item.
    /// </summary>
    public sealed class StatsItem
    {
        /// <summary>
        /// Gets or sets the total number of items.
        /// </summary>
        /// <value>The total number of items.</value>

        [JsonProperty("totalItems")]
        public StatsItemTotal TotalItems { get; set; }

        /// <summary>
        /// Gets or sets the total number of value.
        /// </summary>
        /// <value>The total number of value.</value>

        [JsonProperty("totalValue")]
        public StatsItemTotal TotalValue { get; set; }
    }
}