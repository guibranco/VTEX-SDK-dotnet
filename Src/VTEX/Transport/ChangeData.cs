// ***********************************************************************
// Assembly         : VTEX
// Author           : Guilherme Branco Stracini
// Created          : 01-15-2023
//
// Last Modified By : Guilherme Branco Stracini
// Last Modified On : 01-16-2023
// ***********************************************************************
// <copyright file="ChangeData.cs" company="Guilherme Branco Stracini">
//     © 2020 Guilherme Branco Stracini. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
namespace VTEX.Transport
{
    using Newtonsoft.Json;

    /// <summary>
    /// The change data class.
    /// This class cannot be inherited.
    /// </summary>
    public sealed class ChangeData
    {
        /// <summary>
        /// Gets or sets the reason.
        /// </summary>
        /// <value>The reason.</value>
        [JsonProperty("reason")]
        public string Reason { get; set; }

        /// <summary>
        /// Gets or sets the discount value.
        /// </summary>
        /// <value>The discount value.</value>
        [JsonProperty("discountValue")]
        public int DiscountValue { get; set; }

        /// <summary>
        /// Gets or sets the incremented value.
        /// </summary>
        /// <value>The incremented value.</value>
        [JsonProperty("incrementValue")]
        public int IncrementedValue { get; set; }


        /// <summary>
        /// Gets or sets the items added.
        /// </summary>
        /// <value>The items added.</value>
        [JsonProperty("itemsAdded")]
        public ItemChanged[] ItemsAdded { get; set; }

        /// <summary>
        /// Gets or sets the items removed.
        /// </summary>
        /// <value>The items removed.</value>
        [JsonProperty("itemsRemoved")]
        public ItemChanged[] ItemsRemoved { get; set; }

        /// <summary>
        /// Gets or sets the receipt.
        /// </summary>
        /// <value>The receipt.</value>
        [JsonProperty("receipt")]
        public ResponseReceipt Receipt { get; set; }
    }
}
