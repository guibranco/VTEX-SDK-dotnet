// ***********************************************************************
// Assembly         : VTEX
// Author           : Guilherme Branco Stracini
// Created          : 01-15-2023
//
// Last Modified By : Guilherme Branco Stracini
// Last Modified On : 01-16-2023
// ***********************************************************************
// <copyright file="PickupStoreInfo.cs" company="Guilherme Branco Stracini">
//     © 2020 Guilherme Branco Stracini. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
namespace VTEX.Transport
{
    using CrispyWaffle.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The pickup store info class
    /// </summary>
    public sealed class PickupStoreInfo
    {
        /// <summary>
        /// Gets or sets the additional information.
        /// </summary>
        /// <value>The additional information.</value>
        [JsonProperty("additionalInfo")]
        public NotNullObserver AdditionalInfo { get; set; }

        /// <summary>
        /// Gets or sets the address.
        /// </summary>
        /// <value>The address.</value>
        [JsonProperty("address")]
        public NotNullObserver Address { get; set; }

        /// <summary>
        /// Gets or sets the dock identifier.
        /// </summary>
        /// <value>The dock identifier.</value>
        [JsonProperty("dockId")]
        public NotNullObserver DockId { get; set; }

        /// <summary>
        /// Gets or sets the name of the friendly.
        /// </summary>
        /// <value>The name of the friendly.</value>
        [JsonProperty("friendlyName")]
        public NotNullObserver FriendlyName { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this instance is pickup store.
        /// </summary>
        /// <value><c>true</c> if this instance is pickup store; otherwise, <c>false</c>.</value>
        [JsonProperty("isPickupStore")]
        public bool IsPickupStore { get; set; }
    }
}
