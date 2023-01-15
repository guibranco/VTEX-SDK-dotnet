// ***********************************************************************
// Assembly         : VTEX
// Author           : Guilherme Branco Stracini
// Created          : 01-15-2023
//
// Last Modified By : Guilherme Branco Stracini
// Last Modified On : 01-16-2023
// ***********************************************************************
// <copyright file="Tag.cs" company="Guilherme Branco Stracini">
//     © 2020 Guilherme Branco Stracini. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
namespace VTEX.ValueObjects
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    /// <summary>
    /// The cart tag class.
    /// </summary>
    public class Tag
    {
        /// <summary>
        /// Gets or sets the display value.
        /// </summary>
        /// <value>The display value.</value>
        [JsonProperty("DisplayValue")]
        public string DisplayValue { get; set; }

        /// <summary>
        /// Gets or sets the scores.
        /// </summary>
        /// <value>The scores.</value>
        [JsonProperty("Scores")]
        public Dictionary<string, Score[]> Scores { get; set; }
    }
}
