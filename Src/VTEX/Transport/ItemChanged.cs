// ***********************************************************************
// Assembly         : VTEX
// Author           : Guilherme Branco Stracini
// Created          : 01-15-2023
//
// Last Modified By : Guilherme Branco Stracini
// Last Modified On : 01-15-2023
// ***********************************************************************
// <copyright file="ItemChanged.cs" company="Guilherme Branco Stracini">
//     © 2020 Guilherme Branco Stracini. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
namespace VTEX.Transport
{
    using Newtonsoft.Json;

    /// <summary>
    /// The item changed class
    /// </summary>
    /// <seealso cref="ItemOfInvoice" />
    public sealed class ItemChanged : ItemOfInvoice
    {
        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>The name.</value>
        /// <remarks>This property is used in Order.ChangesAttachment.ChangesData[].Items[Added|Removed]
        /// This property is not used in invoice operations!</remarks>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the unit multiplier.
        /// </summary>
        /// <value>The unit multiplier.</value>
        [JsonProperty("unitMultiplier")]
        public decimal UnitMultiplier { get; set; }
    }
}
