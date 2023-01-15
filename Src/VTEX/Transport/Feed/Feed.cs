// ***********************************************************************
// Assembly         : VTEX
// Author           : Guilherme Branco Stracini
// Created          : 01-16-2023
//
// Last Modified By : Guilherme Branco Stracini
// Last Modified On : 01-16-2023
// ***********************************************************************
// <copyright file="Feed.cs" company="Guilherme Branco Stracini">
//     © 2020 Guilherme Branco Stracini. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
namespace VTEX.Transport.Feed
{
    using System;
    using CrispyWaffle.Serialization;

    /// <summary>
    /// Class Feed.
    /// </summary>
    [Serializer(SerializerFormat.Json)]
    public class Feed
    {
        /// <summary>
        /// Gets or sets the event identifier.
        /// </summary>
        /// <value>The event identifier.</value>
        public string EventId { get; set; }

        /// <summary>
        /// Gets or sets the handle.
        /// </summary>
        /// <value>The handle.</value>
        public string Handle { get; set; }

        /// <summary>
        /// Gets or sets the domain.
        /// </summary>
        /// <value>The domain.</value>
        public int Domain { get; set; }

        /// <summary>
        /// Gets or sets the state.
        /// </summary>
        /// <value>The state.</value>
        public int State { get; set; }

        /// <summary>
        /// Gets or sets the order identifier.
        /// </summary>
        /// <value>The order identifier.</value>
        public string OrderId { get; set; }

        /// <summary>
        /// Gets or sets the last change.
        /// </summary>
        /// <value>The last change.</value>
        public DateTime LastChange { get; set; }

        /// <summary>
        /// Gets or sets the current change.
        /// </summary>
        /// <value>The current change.</value>
        public DateTime CurrentChange { get; set; }
    }
}
