namespace VTEX.Enums
{
    using CrispyWaffle.Attributes;

    /// <summary>
    /// Enum ResultStatus
    /// </summary>
    public enum ResultStatus
    {
        /// <summary>
        /// The unhealthy.
        /// </summary>
        [InternalValue("unhealthy")]
        [HumanReadable("Unhealthy")]
        UNHEALTHY,
        /// <summary>
        /// The warning.
        /// </summary>
        [InternalValue("warning")]
        [HumanReadable("Warning")]
        WARNING,
        /// <summary>
        /// The healthy.
        /// </summary>
        [InternalValue("healthy")]
        [HumanReadable("Healthy")]
        HEALTHY,

        /// <summary>
        /// The stopped
        /// </summary>
        [InternalValue("stopped")]
        [HumanReadable("Stopped")]
        STOPPED,

    }
}
