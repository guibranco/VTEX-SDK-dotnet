// ***********************************************************************
// Assembly         : VTEX
// Author           : Guilherme Branco Stracini
// Created          : 01-15-2023
//
// Last Modified By : Guilherme Branco Stracini
// Last Modified On : 01-16-2023
// ***********************************************************************
// <copyright file="Sla.cs" company="Guilherme Branco Stracini">
//     © 2020 Guilherme Branco Stracini. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
namespace VTEX.Transport
{
    using CrispyWaffle.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// Service Level Agreement.
    /// </summary>

    public sealed class Sla
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>The identifier.</value>

        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>The name.</value>

        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the shipping estimate.
        /// </summary>
        /// <value>The shipping estimate.</value>

        [JsonProperty("shippingEstimate")]
        public string ShippingEstimate { get; set; }

        /// <summary>
        /// Gets or sets the delivery window.
        /// </summary>
        /// <value>The delivery window.</value>

        [JsonProperty("deliveryWindow")]
        public NotNullObserver DeliveryWindow { get; set; }

        /// <summary>
        /// Gets or sets the price.
        /// </summary>
        /// <value>The price.</value>

        [JsonProperty("price")]
        public int Price { get; set; }

        /// <summary>
        /// Gets or sets the delivery channel.
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
        /// Gets or sets the name of the polygon.
        /// </summary>
        /// <value>The name of the polygon.</value>
        [JsonProperty("polygonName")]
        public NotNullObserver PolygonName { get; set; }

        /// <summary>
        /// Gets or sets the lock TTL.
        /// </summary>
        /// <value>The lock TTL.</value>
        [JsonProperty("lockTTL")]
        public string LockTTL { get; set; }

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