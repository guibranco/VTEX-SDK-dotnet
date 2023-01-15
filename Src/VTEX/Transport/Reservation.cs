// ***********************************************************************
// Assembly         : VTEX
// Author           : Guilherme Branco Stracini
// Created          : 01-15-2023
//
// Last Modified By : Guilherme Branco Stracini
// Last Modified On : 01-15-2023
// ***********************************************************************
// <copyright file="Reservation.cs" company="Guilherme Branco Stracini">
//     © 2020 Guilherme Branco Stracini. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
namespace VTEX.Transport
{
    using CrispyWaffle.Serialization;
    using Newtonsoft.Json;
    using System;

    /// <summary>
    /// Class Reservation. This class cannot be inherited.
    /// </summary>
    [Serializer(SerializerFormat.Json)]
    public sealed class Reservation
    {
        /// <summary>
        /// Gets or sets the lock identifier.
        /// </summary>
        /// <value>The lock identifier.</value>
        [JsonProperty("LockId")]
        public string LockId { get; set; }

        /// <summary>
        /// Gets or sets the item identifier.
        /// </summary>
        /// <value>The item identifier.</value>
        [JsonProperty("ItemId")]
        public string ItemId { get; set; }

        /// <summary>
        /// Gets or sets the quantity.
        /// </summary>
        /// <value>The quantity.</value>
        [JsonProperty("Quantity")]
        public int Quantity { get; set; }

        /// <summary>
        /// Gets or sets the sales channel.
        /// </summary>
        /// <value>The sales channel.</value>
        [JsonProperty("SalesChannel")]
        public string SalesChannel { get; set; }

        /// <summary>
        /// Gets or sets the reservation date UTC.
        /// </summary>
        /// <value>The reservation date UTC.</value>
        [JsonProperty("ReservationDateUtc")]
        public DateTime ReservationDateUtc { get; set; }

        /// <summary>
        /// Gets or sets the maximum confirmation date UTC.
        /// </summary>
        /// <value>The maximum confirmation date UTC.</value>
        [JsonProperty("MaximumConfirmationDateUtc")]
        public DateTime MaximumConfirmationDateUtc { get; set; }

        /// <summary>
        /// Gets or sets the confirmed date UTC.
        /// </summary>
        /// <value>The confirmed date UTC.</value>
        [JsonProperty("ConfirmedDateUtc")]
        public DateTime ConfirmedDateUtc { get; set; }

        /// <summary>
        /// Gets or sets the status.
        /// </summary>
        /// <value>The status.</value>
        [JsonProperty("Status")]
        public string Status { get; set; }

        /// <summary>
        /// Gets or sets the date UTC acknowledged on balance system.
        /// </summary>
        /// <value>The date UTC acknowledged on balance system.</value>
        [JsonProperty("DateUtcAcknowledgedOnBalanceSystem")]
        public DateTime DateUtcAcknowledgedOnBalanceSystem { get; set; }

        /// <summary>
        /// Gets or sets the internal status.
        /// </summary>
        /// <value>The internal status.</value>
        [JsonProperty("InternalStatus")]
        public string InternalStatus { get; set; }
    }
}
