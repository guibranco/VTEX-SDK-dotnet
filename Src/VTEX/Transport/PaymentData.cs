// ***********************************************************************
// Assembly         : VTEX
// Author           : Guilherme Branco Stracini
// Created          : 01-15-2023
//
// Last Modified By : Guilherme Branco Stracini
// Last Modified On : 01-16-2023
// ***********************************************************************
// <copyright file="PaymentData.cs" company="Guilherme Branco Stracini">
//     © 2020 Guilherme Branco Stracini. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
namespace VTEX.Transport
{
    using CrispyWaffle.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A payment data.
    /// </summary>

    public sealed class PaymentData
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>The identifier.</value>

        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the gift cards.
        /// </summary>
        /// <value>The gift cards.</value>

        [JsonProperty("giftCards")]
        public NotNullObserver[] GiftCards { get; set; }

        /// <summary>
        /// Gets or sets the transactions.
        /// </summary>
        /// <value>The transactions.</value>

        [JsonProperty("transactions")]
        public Transaction[] Transactions { get; set; }
    }
}
