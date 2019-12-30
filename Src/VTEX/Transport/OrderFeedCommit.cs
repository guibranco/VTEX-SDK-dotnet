namespace VTEX.Transport
{
    using CrispyWaffle.Serialization;

    /// <summary>
    /// The order feed commit class.
    /// </summary>
    [Serializer(SerializerFormat.JSON)]
    public class OrderFeedCommit
    {
        /// <summary>
        /// Gets or sets the commit token.
        /// </summary>
        /// <value>
        /// The commit token.
        /// </value>
        public string CommitToken { get; set; }
    }
}
