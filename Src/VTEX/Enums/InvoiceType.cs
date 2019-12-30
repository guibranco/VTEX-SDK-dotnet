namespace VTEX.Enums
{
    using CrispyWaffle.Attributes;

    /// <summary>
    /// The invoice type enumeration.
    /// Used when sending shipping notification.
    /// </summary>
    public enum InvoiceType
    {

        /// <summary>
        /// The output.
        /// </summary>
        [InternalValue("Output")]
        [HumanReadable("Output")]
        OUTPUT,

        /// <summary>
        /// The input.
        /// </summary>
        [InternalValue("Input")]
        [HumanReadable("Input")]
        INPUT
    }
}
