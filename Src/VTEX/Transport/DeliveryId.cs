// ***********************************************************************
// Assembly         : VTEX
// Author           : Guilherme Branco Stracini
// Created          : 01-15-2023
//
// Last Modified By : Guilherme Branco Stracini
// Last Modified On : 01-16-2023
// ***********************************************************************
// <copyright file="DeliveryId.cs" company="Guilherme Branco Stracini">
//     © 2020 Guilherme Branco Stracini. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
namespace VTEX.Transport
{
    using Newtonsoft.Json;

    /// <summary>
    /// Class DeliveryId. This class cannot be inherited.
    /// </summary>
    public sealed class DeliveryId
    {

        /// <summary>
        /// Gets or sets the courier identifier.
        /// </summary>
        /// <value>The courier identifier.</value>
        [JsonProperty("courierId")]
        public string CourierId { get; set; }

        /// <summary>
        /// Gets or sets the dock identifier.
        /// </summary>
        /// <value>The dock identifier.</value>
        [JsonProperty("dockId")]
        public string DockId { get; set; }

        /// <summary>
        /// Gets or sets the quantity.
        /// </summary>
        /// <value>The quantity.</value>
        [JsonProperty("quantity")]
        public int Quantity { get; set; }

        /// <summary>
        /// Gets or sets the warehouse identifier.
        /// </summary>
        /// <value>The warehouse identifier.</value>
        [JsonProperty("warehouseId")]
        public string WarehouseId { get; set; }

        /// <summary>
        /// Gets or sets the name of the courier.
        /// </summary>
        /// <value>The name of the courier.</value>
        [JsonProperty("courierName")]
        public string CourierName { get; set; }

        /// <summary>
        /// Gets or sets the name of the account carrier.
        /// </summary>
        /// <value>The name of the account carrier.</value>
        [JsonProperty("accountCarrierName")]
        public string AccountCarrierName { get; set; }
    }
}