// file:	DTOSC\StatsItem.cs
//
// summary:	Implements the stats item class

namespace VTEX.Transport
{
    using Newtonsoft.Json;

    /// <summary>
    /// 	The stats item.
    /// </summary>
    ///
    /// <remarks>
    /// 	Versão: 1.61.3637.731
    /// 	Autor: Guilherme Branco Stracini
    /// 	Data: 02/06/2014.
    /// </remarks>

    public sealed class StatsItem
    {
        /// <summary>
        /// 	Gets or sets the total number of items.
        /// </summary>
        ///
        /// <value>
        /// 	The total number of items.
        /// </value>

        [JsonProperty("totalItems")]
        public StatsItemTotal TotalItems { get; set; }

        /// <summary>
        /// 	Gets or sets the total number of value.
        /// </summary>
        ///
        /// <value>
        /// 	The total number of value.
        /// </value>

        [JsonProperty("totalValue")]
        public StatsItemTotal TotalValue { get; set; }
    }
}