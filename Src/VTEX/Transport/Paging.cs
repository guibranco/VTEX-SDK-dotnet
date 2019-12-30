// file:	DTOSC\Paging.cs
//
// summary:	Implements the paging class

namespace VTEX.Transport
{
    using Newtonsoft.Json;

    /// <summary>
    /// 	A paging.
    /// </summary>
    ///
    /// <remarks>
    /// 	Versão: 1.61.3637.731
    /// 	Autor: Guilherme Branco Stracini
    /// 	Data: 02/06/2014.
    /// </remarks>

    public sealed class Paging
    {
        /// <summary>
        /// Gets or sets the page.
        /// </summary>
        /// <value>
        /// The page.
        /// </value>
        [JsonProperty("page")]
        public int Page { get; set; }
        /// <summary>
        /// 	Gets or sets the number of. 
        /// </summary>
        ///
        /// <value>
        /// 	The total.
        /// </value>

        [JsonProperty("total")]
        public int Total { get; set; }

        /// <summary>
        /// 	Gets or sets the pages.
        /// </summary>
        ///
        /// <value>
        /// 	The pages.
        /// </value>

        [JsonProperty("pages")]
        public int Pages { get; set; }

        /// <summary>
        /// 	Gets or sets the current page.
        /// </summary>
        ///
        /// <value>
        /// 	The current page.
        /// </value>

        [JsonProperty("currentPage")]
        public int CurrentPage { get; set; }

        /// <summary>
        /// 	Gets or sets the per page.
        /// </summary>
        ///
        /// <value>
        /// 	The per page.
        /// </value>

        [JsonProperty("perPage")]
        public int PerPage { get; set; }
    }
}