namespace VTEX.Enums
{
    using CrispyWaffle.Attributes;

    /// <summary>
    /// The document type enumeration.
    /// </summary>
    public enum DocumentType
    {
        /// <summary>
        /// The personal.
        /// </summary>
        [InternalValue("cpf")]
        [HumanReadable("Personal")]
        PERSONAL,

        /// <summary>
        /// The corporate.
        /// </summary>
        [InternalValue("cnpj")]
        [HumanReadable("Corporate")]
        CORPORATE,
    }
}
