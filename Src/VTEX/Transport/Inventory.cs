// ***********************************************************************
// Assembly         : IntegracaoService.VTEX
// Author           : Guilherme Branco Stracini
// Created          : 12-20-2016
//
// Last Modified By : Guilherme Branco Stracini
// Last Modified On : 12-20-2016
// ***********************************************************************
// <copyright file="Inventory.cs" company="Guilherme Branco Stracini ME">
//     © 2016 Guilherme Branco Stracini, All Rights Reserved
// </copyright>
// <summary></summary>
// ***********************************************************************

namespace VTEX.Transport
{
    using CrispyWaffle.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// Class Inventory. This class cannot be inherited.
    /// </summary>
    [Serializer(SerializerFormat.JSON)]
    public sealed class Inventory
    {
        /// <summary>
        /// Gets or sets the sku identifier.
        /// </summary>
        /// <value>The sku identifier.</value>
        [JsonProperty("skuid")]
        public int SKUId { get; set; }

        /// <summary>
        /// Gets or sets the balances.
        /// </summary>
        /// <value>The balances.</value>
        [JsonProperty("balance")]
        public Balance[] Balances { get; set; }
    }
}
