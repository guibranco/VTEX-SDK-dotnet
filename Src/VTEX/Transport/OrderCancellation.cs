namespace VTEX.Transport
{
    using CrispyWaffle.Serialization;
    using System;

    /// <summary>
    ///     An order cancellation.
    /// </summary>
    [Serializer(SerializerFormat.Json)]
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
