namespace IntegracaoService.VTEX.Transport.Hook
{
    using IntegracaoService.VTEX.Transport.Shared;

    /// <summary>
    /// Class OrderHook.
    /// </summary>
    public class OrderHook
    {
        /// <summary>
        /// Gets or sets the filter.
        /// </summary>
        /// <value>The filter.</value>
        public Filter Filter { get; set; }

        /// <summary>
        /// Gets or sets the hook.
        /// </summary>
        /// <value>The hook.</value>
        public Hook Hook { get; set; }
    }
}


