// ***********************************************************************
// Assembly         : IntegracaoService.VTEX
// Author           : Guilherme Branco Stracini
// Created          : 11-04-2016
//
// Last Modified By : Guilherme Branco Stracini
// Last Modified On : 11-04-2016
// ***********************************************************************
// <copyright file="Address.cs" company="Guilherme Branco Stracini ME">
//     © 2016 Guilherme Branco Stracini, All Rights Reserved
// </copyright>
// <summary></summary>
// ***********************************************************************

namespace VTEX.Transport
{
    using Newtonsoft.Json;

    /// <summary>
    /// Class Address. This class cannot be inherited.
    /// </summary>
    public sealed class Address
    {

        /// <summary>
        /// Gets or sets the type of the address.
        /// </summary>
        /// <value>The type of the address.</value>
        [JsonProperty("addressType")]
        public string AddressType { get; set; }

        /// <summary>
        /// Gets or sets the name of the receiver.
        /// </summary>
        /// <value>The name of the receiver.</value>
        [JsonProperty("receiverName")]
        public string ReceiverName { get; set; }

        /// <summary>
        /// Gets or sets the address identifier.
        /// </summary>
        /// <value>The address identifier.</value>
        [JsonProperty("addressId")]
        public string AddressId { get; set; }

        /// <summary>
        /// Gets or sets the postal code.
        /// </summary>
        /// <value>The postal code.</value>
        [JsonProperty("postalCode")]
        public string PostalCode { get; set; }

        /// <summary>
        /// Gets or sets the city.
        /// </summary>
        /// <value>The city.</value>
        [JsonProperty("city")]
        public string City { get; set; }

        /// <summary>
        /// Gets or sets the state.
        /// </summary>
        /// <value>The state.</value>
        [JsonProperty("state")]
        public string State { get; set; }

        /// <summary>
        /// Gets or sets the country.
        /// </summary>
        /// <value>The country.</value>
        [JsonProperty("country")]
        public string Country { get; set; }

        /// <summary>
        /// Gets or sets the street.
        /// </summary>
        /// <value>The street.</value>
        [JsonProperty("street")]
        public string Street { get; set; }

        /// <summary>
        /// Gets or sets the number.
        /// </summary>
        /// <value>The number.</value>
        [JsonProperty("number")]
        public string Number { get; set; }

        /// <summary>
        /// Gets or sets the neighborhood.
        /// </summary>
        /// <value>The neighborhood.</value>
        [JsonProperty("neighborhood")]
        public string Neighborhood { get; set; }

        /// <summary>
        /// Gets or sets the complement.
        /// </summary>
        /// <value>The complement.</value>
        [JsonProperty("complement")]
        public string Complement { get; set; }

        /// <summary>
        /// Gets or sets the reference.
        /// </summary>
        /// <value>The reference.</value>
        [JsonProperty("reference")]
        public string Reference { get; set; }

        /// <summary>
        /// Gets or sets the geo coordinates.
        /// </summary>
        /// <value>
        /// The geo coordinates.
        /// </value>
        [JsonProperty("geoCoordinates")]
        public decimal[] GeoCoordinates { get; set; }
    }
}