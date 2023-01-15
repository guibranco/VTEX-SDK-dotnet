// ***********************************************************************
// Assembly         : VTEX
// Author           : Guilherme Branco Stracini
// Created          : 01-15-2023
//
// Last Modified By : Guilherme Branco Stracini
// Last Modified On : 01-15-2023
// ***********************************************************************
// <copyright file="OrderFeed.cs" company="Guilherme Branco Stracini">
//     © 2020 Guilherme Branco Stracini. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
namespace VTEX.Transport
{
    using System;
    using CrispyWaffle.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The order feed class.
    /// </summary>
    [Serializer(SerializerFormat.Json)]
    public class OrderFeed
    {
        /// <summary>
        /// Gets or sets the origin.
        /// </summary>
        /// <value>The origin.</value>
        [JsonProperty("origin")]
        public string Origin { get; set; }

        /// <summary>
        /// Gets or sets the order identifier.
        /// </summary>
        /// <value>The order identifier.</value>
        [JsonProperty("orderid")]
        public string OrderId { get; set; }

        /// <summary>
        /// Gets or sets the status.
        /// </summary>
        /// <value>The status.</value>
        [JsonProperty("status")]
        public string Status { get; set; }

        /// <summary>
        /// Gets or sets the date time.
        /// </summary>
        /// <value>The date time.</value>
        [JsonProperty("datetime")]
        public DateTime DateTime { get; set; }

        /// <summary>
        /// Gets or sets the commit token.
        /// </summary>
        /// <value>The commit token.</value>
        [JsonProperty("commitToken")]
        public string CommitToken { get; set; }
    }
}
