// ***********************************************************************
// Assembly         : VTEX
// Author           : Guilherme Branco Stracini
// Created          : 01-15-2023
//
// Last Modified By : Guilherme Branco Stracini
// Last Modified On : 01-15-2023
// ***********************************************************************
// <copyright file="ChangeOrder.cs" company="Guilherme Branco Stracini">
//     © 2020 Guilherme Branco Stracini. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
namespace VTEX.Transport
{
    using CrispyWaffle.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The order change item class.
    /// This class cannot be inherited.
    /// </summary>
    [Serializer(SerializerFormat.Json)]
    public sealed class ChangeOrder
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
        /// Gets or sets the increment value.
        /// </summary>
        /// <value>The increment value.</value>
        [JsonProperty("incrementValue")]
        public int IncrementValue { get; set; }

        /// <summary>
        /// Gets or sets the items added.
        /// </summary>
        /// <value>The items added.</value>
        [JsonProperty("itemsAdded")]
        public ChangeOrderItem[] ItemsAdded { get; set; }

        /// <summary>
        /// Gets the items removed.
        /// </summary>
        /// <value>The items removed.</value>
        [JsonProperty("itemsRemoved")]
        public ChangeOrderItem[] ItemsRemoved { get; set; }
    }
}
