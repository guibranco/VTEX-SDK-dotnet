// ***********************************************************************
// Assembly         : VTEX
// Author           : Guilherme Branco Stracini
// Created          : 01-15-2023
//
// Last Modified By : Guilherme Branco Stracini
// Last Modified On : 01-16-2023
// ***********************************************************************
// <copyright file="LogisticsInfo.cs" company="Guilherme Branco Stracini">
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
    /// Class LogisticsInfo. This class cannot be inherited.
    /// </summary>
    public sealed class LogisticsInfo
    {
        /// <summary>
        /// Gets or sets the index of the item.
        /// </summary>
        /// <value>The index of the item.</value>
        [JsonProperty("itemIndex")]
        public int ItemIndex { get; set; }

        /// <summary>
        /// Gets or sets the selected sla.
        /// </summary>
        /// <value>The selected sla.</value>
        [JsonProperty("selectedSla")]
        public string SelectedSla { get; set; }

        /// <summary>
        /// Gets or sets the lock TTL.
        /// </summary>
        /// <value>The lock TTL.</value>
        [JsonProperty("lockTTL")]
        public string LockTTL { get; set; }

        /// <summary>
        /// Gets or sets the price.
        /// </summary>
        /// <value>The price.</value>
        [JsonProperty("price")]
        public int Price { get; set; }

        /// <summary>
        /// Gets or sets the list price.
        /// </summary>
        /// <value>The list price.</value>
        [JsonProperty("listPrice")]
        public int ListPrice { get; set; }

        /// <summary>
        /// Gets or sets the delivery window.
        /// </summary>
        /// <value>The delivery window.</value>
        [JsonProperty("deliveryWindow")]
        public NotNullObserver DeliveryWindow { get; set; }

        /// <summary>
        /// Gets or sets the delivery company.
        /// </summary>
        /// <value>The delivery company.</value>
        [JsonProperty("deliveryCompany")]
        public string DeliveryCompany { get; set; }

        /// <summary>
        /// Gets or sets the shipping estimate.
        /// </summary>
        /// <value>The shipping estimate.</value>
        [JsonProperty("shippingEstimate")]
        public string ShippingEstimate { get; set; }

        /// <summary>
        /// Gets or sets the shipping estimate date.
        /// </summary>
        /// <value>The shipping estimate date.</value>
        [JsonProperty("shippingEstimateDate")]
        public DateTime? ShippingEstimateDate { get; set; }

        /// <summary>
        /// Gets or sets the sla.
        /// </summary>
        /// <value>The sla.</value>
        [JsonProperty("slas")]
        public Sla[] Sla { get; set; }

        /// <summary>
        /// Gets or sets the ships to.
        /// </summary>
        /// <value>The ships to.</value>
        [JsonProperty("shipsTo")]
        public string[] ShipsTo { get; set; }

        /// <summary>
        /// Gets or sets the selling price.
        /// </summary>
        /// <value>The selling price.</value>
        [JsonProperty("sellingPrice")]
        public int SellingPrice { get; set; }

        /// <summary>
        /// Gets or sets the delivery ids.
        /// </summary>
        /// <value>The delivery ids.</value>
        [JsonProperty("deliveryIds")]
        public DeliveryId[] DeliveryIds { get; set; }

        /// <summary>
        /// Gets the delivery channel.
        /// </summary>
        /// <value>The delivery channel.</value>
        [JsonProperty("deliveryChannel")]
        public string DeliveryChannel { get; set; }

        /// <summary>
        /// Gets or sets the pickup store information.
        /// </summary>
        /// <value>The pickup store information.</value>
        [JsonProperty("pickupStoreInfo")]
        public PickupStoreInfo PickupStoreInfo { get; set; }

        /// <summary>
        /// Gets or sets the address identifier.
        /// </summary>
        /// <value>The address identifier.</value>
        [JsonProperty("addressId")]
        public string AddressId { get; set; }

        /// <summary>
        /// Gets or sets the name of the polygon.
        /// </summary>
        /// <value>The name of the polygon.</value>
        [JsonProperty("polygonName")]
        public NotNullObserver PolygonName { get; set; }

        /// <summary>
        /// Gets or sets the pickup point identifier.
        /// </summary>
        /// <value>The pickup point identifier.</value>
        [JsonProperty("pickupPointId")]
        public NotNullObserver PickupPointId { get; set; }

        /// <summary>
        /// Gets or sets the transit time.
        /// </summary>
        /// <value>The transit time.</value>
        [JsonProperty("transitTime")]
        public string TransitTime { get; set; }
    }
}
