// ***********************************************************************
// Assembly         : VTEX
// Author           : Guilherme Branco Stracini
// Created          : 01-15-2023
//
// Last Modified By : Guilherme Branco Stracini
// Last Modified On : 01-15-2023
// ***********************************************************************
// <copyright file="Paging.cs" company="Guilherme Branco Stracini">
//     © 2020 Guilherme Branco Stracini. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
namespace VTEX.Transport
{
    using Newtonsoft.Json;

    /// <summary>
    /// A paging.
    /// </summary>
    public sealed class Paging
    {
        /// <summary>
        /// Gets or sets the page.
        /// </summary>
        /// <value>The page.</value>
        [JsonProperty("page")]
        public int Page { get; set; }
        /// <summary>
        /// Gets or sets the number of.
        /// </summary>
        /// <value>The total.</value>

        [JsonProperty("total")]
        public int Total { get; set; }

        /// <summary>
        /// Gets or sets the pages.
        /// </summary>
        /// <value>The pages.</value>

        [JsonProperty("pages")]
        public int Pages { get; set; }

        /// <summary>
        /// Gets or sets the current page.
        /// </summary>
        /// <value>The current page.</value>

        [JsonProperty("currentPage")]
        public int CurrentPage { get; set; }

        /// <summary>
        /// Gets or sets the per page.
        /// </summary>
        /// <value>The per page.</value>

        [JsonProperty("perPage")]
        public int PerPage { get; set; }
    }
}