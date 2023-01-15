// ***********************************************************************
// Assembly         : VTEX
// Author           : Guilherme Branco Stracini
// Created          : 01-15-2023
//
// Last Modified By : Guilherme Branco Stracini
// Last Modified On : 01-16-2023
// ***********************************************************************
// <copyright file="BankSlipSettlement.cs" company="Guilherme Branco Stracini">
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
    /// The bank slip settlement class.
    /// </summary>
    [Serializer(SerializerFormat.Json)]
    public sealed class BankSlipSettlement
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>The identifier.</value>
        [JsonProperty("Id")]
        public Guid Id { get; set; }

        /// <summary>
        /// Converts to ken.
        /// </summary>
        /// <value>The token.</value>
        [JsonProperty("Token")]
        public string Token { get; set; }

        /// <summary>
        /// Gets or sets the settlement date.
        /// </summary>
        /// <value>The settlement date.</value>
        [JsonProperty("SettlementDate")]
        public DateTime SettlementDate { get; set; }

        /// <summary>
        /// Gets or sets the value as int.
        /// </summary>
        /// <value>The value as int.</value>
        [JsonProperty("ValueAsInt")]
        public int ValueAsInt { get; set; }

        /// <summary>
        /// Gets or sets the value.
        /// </summary>
        /// <value>The value.</value>
        [JsonProperty("Value")]
        public decimal Value { get; set; }

        /// <summary>
        /// Gets or sets the type of the settlement.
        /// </summary>
        /// <value>The type of the settlement.</value>
        [JsonProperty("SettlementType")]
        public int SettlementType { get; set; }
    }
}
