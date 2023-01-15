// ***********************************************************************
// Assembly         : VTEX
// Author           : Guilherme Branco Stracini
// Created          : 01-15-2023
//
// Last Modified By : Guilherme Branco Stracini
// Last Modified On : 01-16-2023
// ***********************************************************************
// <copyright file="CourierStatus.cs" company="Guilherme Branco Stracini">
//     © 2020 Guilherme Branco Stracini. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
namespace VTEX.Transport
{
    using System;
    using Newtonsoft.Json;

    /// <summary>
    /// Class CourierStatus. This class cannot be inherited.
    /// </summary>
    public sealed class CourierStatus
    {
        /// <summary>
        /// Gets or sets the status.
        /// </summary>
        /// <value>The status.</value>
        [JsonProperty("status")]
        public string Status { get; set; }

        /// <summary>
        /// Gets or sets the finished.
        /// </summary>
        /// <value>The finished.</value>
        [JsonProperty("finished")]
        public bool Finished { get; set; }

        /// <summary>
        /// Gets or sets the data.
        /// </summary>
        /// <value>The data.</value>
        [JsonProperty("data")]
        public CourierData[] Data { get; set; }

        /// <summary>
        /// Gets or sets the delivered date.
        /// </summary>
        /// <value>The delivered date.</value>
        [JsonProperty("deliveredDate")]
        public DateTime DeliveredDate { get; set; }
    }
}