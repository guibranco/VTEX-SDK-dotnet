namespace IntegracaoService.VTEX.Transport.PaymentAggregate
{
    /// <summary>
    /// Class ConnectorResponse. This class cannot be inherited.
    /// </summary>

    public sealed class ConnectorResponse
    {

        /// <summary>
        /// Gets or sets the tid.
        /// </summary>
        /// <value>The tid.</value>
        public string Tid { get; set; }
        /// <summary>
        /// Gets or sets the return code.
        /// </summary>
        /// <value>The return code.</value>
        public string ReturnCode { get; set; }
        /// <summary>
        /// Gets or sets the message.
        /// </summary>
        /// <value>The message.</value>
        public string Message { get; set; }
        /// <summary>
        /// Gets or sets the authentication identifier.
        /// </summary>
        /// <value>The authentication identifier.</value>
        public string AuthId { get; set; }
        /// <summary>
        /// Gets or sets the nsu.
        /// </summary>
        /// <value>The nsu.</value>
        public string Nsu { get; set; }
        /// <summary>
        /// Gets or sets the arp.
        /// </summary>
        /// <value>The arp.</value>
        public string Arp { get; set; }
        /// <summary>
        /// Gets or sets the number cv.
        /// </summary>
        /// <value>
        /// The number cv.
        /// </value>
        public string NumCv { get; set; }
        /// <summary>
        /// Gets or sets the eci.
        /// </summary>
        /// <value>
        /// The eci.
        /// </value>
        public string Eci { get; set; }

        /// <summary>
        /// Gets or sets the lr.
        /// </summary>
        /// <value>
        /// The lr.
        /// </value>
        public string Lr { get; set; }

        /// <summary>
        /// Gets or sets the number authentication.
        /// </summary>
        /// <value>
        /// The number authentication.
        /// </value>
        public string NumAutent { get; set; }
        /// <summary>
        /// Gets or sets the nsu settle.
        /// </summary>
        /// <value>
        /// The nsu settle.
        /// </value>
        public string NsuSettle { get; set; }

        /// <summary>
        /// Gets or sets the network.
        /// </summary>
        /// <value>The network.</value>
        public string Network { get; set; }
    }
}
