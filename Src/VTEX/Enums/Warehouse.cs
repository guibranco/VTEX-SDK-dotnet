namespace VTEX.Enums
{
    using CrispyWaffle.Attributes;

    /// <summary>
    /// The VTEX warehouse enumeration
    /// </summary>
    public enum Warehouse
    {
        /// <summary>
        /// The default.
        /// </summary>

        [InternalValue("padrao")]
        [HumanReadable("Default")]
        DEFAULT,

        /// <summary>
        /// The online course
        /// </summary>
        [InternalValue("cursos")]
        [HumanReadable("Online course")]
        COURSE
    }
}