// ***********************************************************************
// Assembly         : VTEX
// Author           : Guilherme Branco Stracini
// Created          : 01-15-2023
//
// Last Modified By : Guilherme Branco Stracini
// Last Modified On : 01-16-2023
// ***********************************************************************
// <copyright file="OrderCancellation.cs" company="Guilherme Branco Stracini">
//     © 2020 Guilherme Branco Stracini. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
namespace VTEX.Transport
{
    using System;
    using CrispyWaffle.Serialization;

    /// <summary>
    /// An order cancellation.
    /// </summary>
    [Serializer(SerializerFormat.Json)]
    public sealed class OrderCancellation
    {
        /// <summary>
        /// Gets or sets the identifier of the order.
        /// </summary>
        /// <value>The identifier of the order.</value>

        public string OrderId { get; set; }

        /// <summary>
        /// Gets or sets the receipt.
        /// </summary>
        /// <value>The receipt.</value>

        public string Receipt { get; set; }

        /// <summary>
        /// Gets or sets the Date/Time of the date.
        /// </summary>
        /// <value>The date.</value>

        public DateTime Date { get; set; }
    }
}
