// ***********************************************************************
// Assembly         : VTEX
// Author           : Guilherme Branco Stracini
// Created          : 01-15-2023
//
// Last Modified By : Guilherme Branco Stracini
// Last Modified On : 01-16-2023
// ***********************************************************************
// <copyright file="DateRange.cs" company="Guilherme Branco Stracini">
//     © 2020 Guilherme Branco Stracini. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
namespace VTEX.Transport
{
    using System;
    using Newtonsoft.Json;

    /// <summary>
    /// The date range class.
    /// This class cannot be inherited.
    /// </summary>
    public sealed class DateRange
    {
        /// <summary>
        /// Gets or sets from.
        /// </summary>
        /// <value>From.</value>
        [JsonIgnore]
        public DateTime From { get; set; }

        /// <summary>
        /// Gets or sets from internal.
        /// </summary>
        /// <value>From internal.</value>
        [JsonProperty("from")]
        public string FromInternal
        {
            get => From.ToString(@"s");
            set
            {
                if (DateTime.TryParse(value, out var from))
                {
                    From = @from;
                }
            }
        }

        /// <summary>
        /// Gets or sets to.
        /// </summary>
        /// <value>To.</value>
        [JsonIgnore]
        public DateTime To { get; set; }

        /// <summary>
        /// Gets or sets to internal.
        /// </summary>
        /// <value>To internal.</value>
        [JsonProperty("to")]
        public string ToInternal
        {
            get => To.ToString(@"s");
            set
            {
                if (DateTime.TryParse(value, out var to))
                {
                    To = to;
                }
            }
        }
    }
}
