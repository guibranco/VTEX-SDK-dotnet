namespace VTEX.Transport
{
    using Newtonsoft.Json;

    /// <summary>
    /// 	List of stats.
    /// </summary>
    ///
    /// <remarks>
    /// 	Versão: 1.61.3637.731
    /// 	Autor: Guilherme Branco Stracini
    /// 	Data: 02/06/2014.
    /// </remarks>

    public sealed class StatsList
    {
        /// <summary>
        /// 	Gets or sets the stats.
        /// </summary>
        ///
        /// <value>
        /// 	The stats.
        /// </value>

        [JsonProperty("stats")]
        public StatsItem Stats { get; set; }
    }
}