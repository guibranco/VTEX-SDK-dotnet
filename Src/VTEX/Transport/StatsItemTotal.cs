// ***********************************************************************
// Assembly         : VTEX
// Author           : Guilherme Branco Stracini
// Created          : 01-15-2023
//
// Last Modified By : Guilherme Branco Stracini
// Last Modified On : 01-15-2023
// ***********************************************************************
// <copyright file="StatsItemTotal.cs" company="Guilherme Branco Stracini">
//     © 2020 Guilherme Branco Stracini. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
namespace VTEX.Transport
{
    using CrispyWaffle.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// Statistics item total.
    /// </summary>
    public sealed class StatsItemTotal
    {
        /// <summary>
        /// Gets or sets the number of.
        /// </summary>
        /// <value>The count.</value>

        [JsonProperty("Count")]
        public int Count { get; set; }

        /// <summary>
        /// Gets or sets the maximum.
        /// </summary>
        /// <value>The maximum value.</value>

        [JsonProperty("Max")]
        public decimal? Max { get; set; }

        /// <summary>
        /// Gets or sets the mean.
        /// </summary>
        /// <value>The mean value.</value>

        [JsonProperty("Mean")]
        public decimal? Mean { get; set; }

        /// <summary>
        /// Gets or sets the minimum.
        /// </summary>
        /// <value>The minimum value.</value>

        [JsonProperty("Min")]
        public decimal? Min { get; set; }

        /// <summary>
        /// Gets or sets the missing.
        /// </summary>
        /// <value>The missing.</value>

        [JsonProperty("Missing")]
        public decimal? Missing { get; set; }

        /// <summary>
        /// Gets or sets the standard development.
        /// </summary>
        /// <value>The standard development.</value>

        [JsonProperty("StdDev")]
        public decimal? StdDev { get; set; }

        /// <summary>
        /// Gets or sets the number of.
        /// </summary>
        /// <value>The sum.</value>

        [JsonProperty("Sum")]
        public decimal? Sum { get; set; }

        /// <summary>
        /// Gets or sets the sum of squares.
        /// </summary>
        /// <value>The total number of of squares.</value>

        [JsonProperty("SumOfSquares")]
        public long? SumOfSquares { get; set; }

        /// <summary>
        /// Gets or sets the facets.
        /// </summary>
        /// <value>The facets.</value>
        [JsonProperty("Facets")]
        public NotNullObserver Facets { get; set; }
    }
}