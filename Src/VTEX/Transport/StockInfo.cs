// ***********************************************************************
// Assembly         : VTEX
// Author           : Guilherme Branco Stracini
// Created          : 01-15-2023
//
// Last Modified By : Guilherme Branco Stracini
// Last Modified On : 01-16-2023
// ***********************************************************************
// <copyright file="StockInfo.cs" company="Guilherme Branco Stracini">
//     © 2020 Guilherme Branco Stracini. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
namespace VTEX.Transport
{
    using System;
    using CrispyWaffle.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// Class StockInfo. This class cannot be inherited.
    /// </summary>
    [Serializer(SerializerFormat.Json)]
    public sealed class StockInfo
    {
        /// <summary>
        /// Gets or sets the identifier of the ware house.
        /// </summary>
        /// <value>The identifier of the ware house.</value>
        [JsonProperty("wareHouseId")]
        public string WareHouseId { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the unlimited quantity.
        /// </summary>
        /// <value>true if unlimited quantity, false if not.</value>
        [JsonProperty("unlimitedQuantity")]
        public bool UnlimitedQuantity { get; set; }

        /// <summary>
        /// Gets or sets the identifier of the item.
        /// </summary>
        /// <value>The identifier of the item.</value>
        [JsonProperty("itemId")]
        public int ItemId { get; set; }

        /// <summary>
        /// Gets or sets the quantity.
        /// </summary>
        /// <value>The quantity.</value>
        [JsonProperty("quantity")]
        public int Quantity { get; set; }

        /// <summary>
        /// Gets or sets the Date/Time of the date UTC on balance system.
        /// </summary>
        /// <value>The date UTC on balance system.</value>
        [JsonProperty("dateUtcOnBalanceSystem")]
        public DateTime? DateUtcOnBalanceSystem { get; set; }
    }
}
