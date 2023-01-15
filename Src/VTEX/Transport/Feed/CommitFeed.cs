namespace IntegracaoService.VTEX.Transport.Feed
{
    using CrispyWaffle.Serialization;

    /// <summary>
    /// Class CommitFeed.
    /// </summary>
    [Serializer(SerializerFormat.Json)]
    public class CommitFeed
    {
        /// <summary>
        /// Gets or sets the handles.
        /// </summary>
        /// <value>The handles.</value>
        public string[] Handles { get; set; }
    }
}
