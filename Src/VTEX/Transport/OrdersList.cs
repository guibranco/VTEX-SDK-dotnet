// ***********************************************************************
// Assembly         : IntegracaoService.VTEX
// Author           : Guilherme Branco Stracini
// Created          : 11-04-2016
//
// Last Modified By : Guilherme Branco Stracini
// Last Modified On : 11-04-2016
// ***********************************************************************
// <copyright file="OrdersList.cs" company="Guilherme Branco Stracini ME">
//     © 2016 Guilherme Branco Stracini, All Rights Reserved
// </copyright>
// <summary></summary>
// ***********************************************************************

namespace VTEX.Transport
{
    using CrispyWaffle.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// Class OrdersList. This class cannot be inherited.
    /// </summary>
    [Serializer(SerializerFormat.JSON)]
    public sealed class OrdersList
    {
        /// <summary>
        /// Gets or sets the list.
        /// </summary>
        /// <value>The list.</value>
        [JsonProperty("list")]
        public List[] List { get; set; }

        /// <summary>
        /// Gets or sets the facets.
        /// </summary>
        /// <value>The facets.</value>
        [JsonProperty("facets")]
        public Facet[] Facets { get; set; }

        /// <summary>
        /// Gets or sets the paging.
        /// </summary>
        /// <value>The paging.</value>
        [JsonProperty("paging")]
        public Paging Paging { get; set; }

        /// <summary>
        /// Gets or sets the stats.
        /// </summary>
        /// <value>The stats.</value>
        [JsonProperty("stats")]
        public StatsList Stats { get; set; }
    }

}
