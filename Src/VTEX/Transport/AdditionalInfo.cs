// ***********************************************************************
// Assembly         : VTEX
// Author           : Guilherme Branco Stracini
// Created          : 01-15-2023
//
// Last Modified By : Guilherme Branco Stracini
// Last Modified On : 01-16-2023
// ***********************************************************************
// <copyright file="AdditionalInfo.cs" company="Guilherme Branco Stracini">
//     © 2020 Guilherme Branco Stracini. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
namespace VTEX.Transport
{
    using CrispyWaffle.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// Class AdditionalInfo. This class cannot be inherited.
    /// </summary>
    public sealed class AdditionalInfo
    {
        /// <summary>
        /// Gets or sets the name of the brand.
        /// </summary>
        /// <value>The name of the brand.</value>
        [JsonProperty("brandName")]
        public string BrandName { get; set; }

        /// <summary>
        /// Gets or sets the brand identifier.
        /// </summary>
        /// <value>The brand identifier.</value>
        [JsonProperty("brandId")]
        public string BrandId { get; set; }

        /// <summary>
        /// Gets or sets the categories ids.
        /// </summary>
        /// <value>The categories ids.</value>
        [JsonProperty("categoriesIds")]
        public string CategoriesIds { get; set; }

        /// <summary>
        /// Gets or sets the categories.
        /// </summary>
        /// <value>The categories.</value>
        [JsonProperty("categories")]
        public Category[] Categories { get; set; }

        /// <summary>
        /// Gets or sets the product cluster identifier.
        /// </summary>
        /// <value>The product cluster identifier.</value>
        [JsonProperty("productClusterId")]
        public string ProductClusterId { get; set; }

        /// <summary>
        /// Gets or sets the commercial condition identifier.
        /// </summary>
        /// <value>The commercial condition identifier.</value>
        [JsonProperty("commercialConditionId")]
        public string CommercialConditionId { get; set; }

        /// <summary>
        /// Gets or sets the dimension.
        /// </summary>
        /// <value>The dimension.</value>
        [JsonProperty("dimension")]
        public Dimension Dimension { get; set; }

        /// <summary>
        /// Gets or sets the offering information.
        /// </summary>
        /// <value>The offering information.</value>
        [JsonProperty("offeringInfo")]
        public NotNullObserver OfferingInfo { get; set; }

        /// <summary>
        /// Gets or sets the type of the offering.
        /// </summary>
        /// <value>The type of the offering.</value>
        [JsonProperty("offeringType")]
        public NotNullObserver OfferingType { get; set; }

        /// <summary>
        /// Gets or sets the offering type identifier.
        /// </summary>
        /// <value>The offering type identifier.</value>
        [JsonProperty("offeringTypeId")]
        public NotNullObserver OfferingTypeId { get; set; }
    }
}