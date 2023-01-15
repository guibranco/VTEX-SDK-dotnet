namespace IntegracaoService.VTEX.Transport.Hook
{
    using CrispyWaffle.Serialization;
    using System.Collections.Generic;

    /// <summary>
    /// Class Hook.
    /// </summary>
    [Serializer(SerializerFormat.Json)]
    public class Hook
    {
        /// <summary>
        /// Gets or sets the URL.
        /// </summary>
        /// <value>The URL.</value>
        public string Url { get; set; }

        /// <summary>
        /// Gets or sets the headers.
        /// </summary>
        /// <value>The headers.</value>
        public Dictionary<string, string> Headers { get; set; }
    }
}