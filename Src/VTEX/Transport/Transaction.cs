// ***********************************************************************
// Assembly         : VTEX
// Author           : Guilherme Branco Stracini
// Created          : 01-15-2023
//
// Last Modified By : Guilherme Branco Stracini
// Last Modified On : 01-15-2023
// ***********************************************************************
// <copyright file="Transaction.cs" company="Guilherme Branco Stracini">
//     © 2020 Guilherme Branco Stracini. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
namespace VTEX.Transport
{
    using Newtonsoft.Json;

    /// <summary>
    /// A transaction.
    /// </summary>
    public sealed class Transaction
    {
        /// <summary>
        /// Gets or sets a value indicating whether this object is active.
        /// </summary>
        /// <value>true if this object is active, false if not.</value>

        [JsonProperty("isActive")]
        public bool IsActive { get; set; }

        /// <summary>
        /// Gets or sets the identifier of the transaction.
        /// </summary>
        /// <value>The identifier of the transaction.</value>

        [JsonProperty("transactionId")]
        public string TransactionId { get; set; }

        /// <summary>
        /// Gets or sets the name of the merchant.
        /// </summary>
        /// <value>The name of the merchant.</value>
        [JsonProperty("merchantName")]
        public string MerchantName { get; set; }

        /// <summary>
        /// Gets or sets the payments.
        /// </summary>
        /// <value>The payments.</value>

        [JsonProperty("payments")]
        public Payment[] Payments { get; set; }
    }
}