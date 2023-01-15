// ***********************************************************************
// Assembly         : VTEX
// Author           : Guilherme Branco Stracini
// Created          : 01-15-2023
//
// Last Modified By : Guilherme Branco Stracini
// Last Modified On : 01-15-2023
// ***********************************************************************
// <copyright file="Reservations.cs" company="Guilherme Branco Stracini">
//     © 2020 Guilherme Branco Stracini. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
namespace VTEX.Transport
{
    using CrispyWaffle.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// Class Reservations. This class cannot be inherited.
    /// </summary>
    [Serializer(SerializerFormat.Json)]
    public sealed class Reservations
    {
        /// <summary>
        /// Gets or sets the items.
        /// </summary>
        /// <value>The items.</value>
        [JsonProperty("items")]
        public Reservation[] Items { get; set; }

        /// <summary>
        /// Gets or sets the paging.
        /// </summary>
        /// <value>The paging.</value>
        [JsonProperty("paging")]
        public Paging Paging { get; set; }
    }
}
