// ***********************************************************************
// Assembly         : VTEX
// Author           : Guilherme Branco Stracini
// Created          : 01-15-2023
//
// Last Modified By : Guilherme Branco Stracini
// Last Modified On : 01-15-2023
// ***********************************************************************
// <copyright file="Score.cs" company="Guilherme Branco Stracini">
//     © 2020 Guilherme Branco Stracini. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
namespace VTEX.ValueObjects
{
    using System;
    using Newtonsoft.Json;

    /// <summary>
    /// The score class.
    /// </summary>
    public class Score
    {
        /// <summary>
        /// Gets or sets the point.
        /// </summary>
        /// <value>The point.</value>
        [JsonProperty("Point")]
        public decimal Point { get; set; }

        /// <summary>
        /// Gets or sets the date.
        /// </summary>
        /// <value>The date.</value>
        [JsonProperty("Date")]
        public DateTime Date { get; set; }

        /// <summary>
        /// Gets or sets the until.
        /// </summary>
        /// <value>The until.</value>
        [JsonProperty("Until")]
        public DateTime Until { get; set; }
    }
}
