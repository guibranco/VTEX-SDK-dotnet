namespace IntegracaoService.VTEX.Transport.Feed
{
    using IntegracaoService.VTEX.Transport.Shared;

    /// <summary>
    /// Class UpdateFeedConfiguration.
    /// </summary>
    public class UpdateFeedConfiguration
    {
        /// <summary>
        /// Gets or sets the filter.
        /// </summary>
        /// <value>The filter.</value>
        public Filter Filter { get; set; }

        /// <summary>
        /// Gets or sets the queue.
        /// </summary>
        /// <value>The queue.</value>
        public FeedQueue Queue { get; set; }

    }
}
