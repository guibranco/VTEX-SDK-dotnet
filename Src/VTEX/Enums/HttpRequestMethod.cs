namespace VTEX.Enums
{
    using CrispyWaffle.Attributes;

    /// <summary>
    /// Enum HttpRequestMethod
    /// </summary>
    public enum HttpRequestMethod
    {
        /// <summary>
        /// The none
        /// </summary>
        [HumanReadable("None")]
        [InternalValue("NONE")]
        NONE,

        /// <summary>
        /// The delete
        /// </summary>
        [HumanReadable("DELETE")]
        [InternalValue("DELETE")]
        DELETE,

        /// <summary>
        /// The get
        /// </summary>
        [HumanReadable("GET")]
        [InternalValue("GET")]
        GET,

        /// <summary>
        /// The head
        /// </summary>
        [HumanReadable("HEAD")]
        [InternalValue("HEAD")]
        HEAD,

        /// <summary>
        /// The options
        /// </summary>
        [HumanReadable("OPTIONS")]
        [InternalValue("OPTIONS")]
        OPTIONS,

        /// <summary>
        /// The patch
        /// </summary>
        [HumanReadable("PATCH")]
        [InternalValue("PATCH")]
        PATCH,

        /// <summary>
        /// The post
        /// </summary>
        [HumanReadable("POST")]
        [InternalValue("POST")]
        POST,

        /// <summary>
        /// The put
        /// </summary>
        [HumanReadable("PUT")]
        [InternalValue("PUT")]
        PUT,
    }
}
