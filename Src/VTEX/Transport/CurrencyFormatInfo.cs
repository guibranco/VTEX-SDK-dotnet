﻿// ***********************************************************************
// Assembly         : VTEX
// Author           : Guilherme Branco Stracini
// Created          : 01-15-2023
//
// Last Modified By : Guilherme Branco Stracini
// Last Modified On : 01-16-2023
// ***********************************************************************
// <copyright file="CurrencyFormatInfo.cs" company="Guilherme Branco Stracini">
//     © 2020 Guilherme Branco Stracini. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
namespace VTEX.Transport
{
    using Newtonsoft.Json;

    /// <summary>
    /// The currency format info class.
    /// This class cannot be inherited.
    /// </summary>
    public sealed class CurrencyFormatInfo
    {
        /// <summary>
        /// Gets or sets the currency decimal digits.
        /// </summary>
        /// <value>The currency decimal digits.</value>
        [JsonProperty("CurrencyDecimalDigits")]
        public int CurrencyDecimalDigits { get; set; }

        /// <summary>
        /// Gets or sets the currency decimal separator.
        /// </summary>
        /// <value>The currency decimal separator.</value>
        [JsonProperty("CurrencyDecimalSeparator")]
        public string CurrencyDecimalSeparator { get; set; }

        /// <summary>
        /// Gets or sets the currency group separator.
        /// </summary>
        /// <value>The currency group separator.</value>
        [JsonProperty("CurrencyGroupSeparator")]
        public string CurrencyGroupSeparator { get; set; }

        /// <summary>
        /// Gets or sets the size of the currency group.
        /// </summary>
        /// <value>The size of the currency group.</value>
        [JsonProperty("CurrencyGroupSize")]
        public int CurrencyGroupSize { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [starts with currency symbol].
        /// </summary>
        /// <value><c>true</c> if [starts with currency symbol]; otherwise, <c>false</c>.</value>
        [JsonProperty("StartsWithCurrencySymbol")]
        public bool StartsWithCurrencySymbol { get; set; }
    }
}
