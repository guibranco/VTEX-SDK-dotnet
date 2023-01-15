// ***********************************************************************
// Assembly         : VTEX
// Author           : Guilherme Branco Stracini
// Created          : 01-15-2023
//
// Last Modified By : Guilherme Branco Stracini
// Last Modified On : 01-15-2023
// ***********************************************************************
// <copyright file="StatsList.cs" company="Guilherme Branco Stracini">
//     © 2020 Guilherme Branco Stracini. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
namespace VTEX.Transport
{
    using Newtonsoft.Json;

    /// <summary>
    /// List of stats.
    /// </summary>
    public sealed class StatsList
    {
        /// <summary>
        /// Gets or sets the stats.
        /// </summary>
        /// <value>The stats.</value>

        [JsonProperty("stats")]
        public StatsItem Stats { get; set; }
    }
}