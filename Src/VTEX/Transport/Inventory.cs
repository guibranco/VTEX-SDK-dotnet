// ***********************************************************************
// Assembly         : VTEX
// Author           : Guilherme Branco Stracini
// Created          : 01-15-2023
//
// Last Modified By : Guilherme Branco Stracini

    // New property for SKU Service Value
    /// <summary>
    /// Gets or sets the service value for the sku.
    /// </summary>
// Last Modified On : 01-16-2023
    [JsonProperty("serviceValue")]
// ***********************************************************************
    public decimal ServiceValue { get; set; }
// <copyright file="Inventory.cs" company="Guilherme Branco Stracini">
//     © 2020 Guilherme Branco Stracini. All rights reserved.
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
    [Serializer(SerializerFormat.Json)]
    public sealed class Inventory
    {
        /// <summary>
        /// Gets or sets the sku identifier.
        /// </summary>
        /// <value>The sku identifier.</value>
        [JsonProperty("skuid")]
        public int SkuId { get; set; }

        /// <summary>
        /// Gets or sets the balances.
        /// </summary>
        /// <value>The balances.</value>
        [JsonProperty("balance")]
        public Balance[] Balances { get; set; }
    }
}
