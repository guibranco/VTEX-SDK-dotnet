// ***********************************************************************
// Assembly         : IntegracaoService.VTEX
// Author           : Guilherme Branco Stracini
// Created          : 12-26-2016
//
// Last Modified By : Guilherme Branco Stracini
// Last Modified On : 12-26-2016
// ***********************************************************************
// <copyright file="StockInfo.cs" company="Guilherme Branco Stracini ME">
//     © 2016 Guilherme Branco Stracini, All Rights Reserved
// </copyright>
// <summary></summary>
// ***********************************************************************

namespace VTEX.Transport
{
    using System;
    using CrispyWaffle.Extensions;
    using CrispyWaffle.Serialization;
    using Enums;
    using Newtonsoft.Json;

    /// <summary>
    /// An estoque dto.
    /// </summary>
    /// <remarks>Versão: 1.51.2928.607
    /// Autor: Guilherme Branco Stracini
    /// Data: 31/03/2014.</remarks>

    [Serializer(SerializerFormat.JSON)]
    public sealed class StockInfo
    {
        /// <summary>
        /// The estoque.
        /// </summary>

        private Warehouse _warehouse;

        /// <summary>
        /// Gets or sets the identifier of the ware house.
        /// </summary>
        /// <value>The identifier of the ware house.</value>

        [JsonProperty("wareHouseId")]
        public string WareHouseId
        {
            get => _warehouse.GetInternalValue();
            set => _warehouse = EnumExtensions.GetEnumByInternalValueAttribute<Warehouse>(value);
        }

        /// <summary>
        /// Gets or sets the ware house enum.
        /// </summary>
        /// <value>The ware house enum.</value>

        [JsonIgnore]
        public Warehouse WareHouseEnum
        {
            get => _warehouse;
            set => _warehouse = value;
        }

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
