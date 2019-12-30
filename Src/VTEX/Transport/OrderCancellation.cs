// file:	DTOSC\OrderCancellation.cs
//
// summary:	Implements the order cancellation class

namespace VTEX.Transport
{
    using System;
    using CrispyWaffle.Serialization;

    /// <summary>
    ///     An order cancellation.
    /// </summary>
    ///
    /// <remarks>
    ///     Versão: 1.64.4143.849
    ///     Autor: Guilherme Branco Stracini
    ///     Data: 16/08/2014.
    /// </remarks>

    [Serializer(SerializerFormat.JSON)]
    public sealed class OrderCancellation
    {
        /// <summary>
        ///     Gets or sets the identifier of the order.
        /// </summary>
        ///
        /// <value>
        ///     The identifier of the order.
        /// </value>

        public string OrderId { get; set; }

        /// <summary>
        ///     Gets or sets the receipt.
        /// </summary>
        ///
        /// <value>
        ///     The receipt.
        /// </value>

        public string Receipt { get; set; }

        /// <summary>
        ///     Gets or sets the Date/Time of the date.
        /// </summary>
        ///
        /// <value>
        ///     The date.
        /// </value>

        public DateTime Date { get; set; }
    }
}
