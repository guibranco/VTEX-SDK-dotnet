namespace IntegracaoService.VTEX.Transport.Feed
{
    /// <summary>
    /// Class FeedQueue.
    /// </summary>
    public class FeedQueue
    {
        /// <summary>
        /// Gets or sets the visibility timeout in seconds.
        /// </summary>
        /// <value>The visibility timeout in seconds.</value>
        public int VisibilityTimeoutInSeconds { get; set; }

        /// <summary>
        /// Gets or sets the message retention period in seconds.
        /// </summary>
        /// <value>The message retention period in seconds.</value>
        public int MessageRetentionPeriodInSeconds { get; set; }
    }
}