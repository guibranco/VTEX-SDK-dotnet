// ***********************************************************************
// Assembly         : VTEX
// Author           : Guilherme Branco Stracini
// Created          : 01-15-2023
//
// Last Modified By : Guilherme Branco Stracini
// Last Modified On : 01-16-2023
// ***********************************************************************
// <copyright file="Item.cs" company="Guilherme Branco Stracini">
//     © 2020 Guilherme Branco Stracini. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
namespace VTEX.Transport
{
    using System;
    using System.Collections.Generic;
    using CrispyWaffle.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// Class Item. This class cannot be inherited.
    /// </summary>
    public sealed class Item
    {
        /// <summary>
        /// Gets or sets the unique identifier.
        /// </summary>
        /// <value>The unique identifier.</value>
        [JsonProperty("uniqueId")]
        public Guid UniqueId { get; set; }

        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>The identifier.</value>
        [JsonProperty("id")]
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the product identifier.
        /// </summary>
        /// <value>The product identifier.</value>
        [JsonProperty("productId")]
        public int ProductId { get; set; }

        /// <summary>
        /// Gets or sets the ean.
        /// </summary>
        /// <value>The ean.</value>
        [JsonProperty("ean")]
        public string Ean { get; set; }

        /// <summary>
        /// Gets or sets the lock identifier.
        /// </summary>
        /// <value>The lock identifier.</value>
        [JsonProperty("lockId")]
        public string LockId { get; set; }

        /// <summary>
        /// Gets or sets the quantity.
        /// </summary>
        /// <value>The quantity.</value>
        [JsonProperty("quantity")]
        public int Quantity { get; set; }

        /// <summary>
        /// Gets or sets the seller.
        /// </summary>
        /// <value>The seller.</value>
        [JsonProperty("seller")]
        public int Seller { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>The name.</value>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the reference identifier.
        /// </summary>
        /// <value>The reference identifier.</value>
        [JsonProperty("refId")]
        public string RefId { get; set; }

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
        /// Gets or sets the price tags.
        /// </summary>
        /// <value>The price tags.</value>
        [JsonProperty("priceTags")]
        public PriceTag[] PriceTags { get; set; }

        /// <summary>
        /// Gets or sets the image URL.
        /// </summary>
        /// <value>The image URL.</value>
        [JsonProperty("imageUrl")]
        public string ImageUrl { get; set; }

        /// <summary>
        /// Gets or sets the components.
        /// </summary>
        /// <value>The components.</value>

        [JsonProperty("components")]
        public Item[] Components { get; set; }

        /// <summary>
        /// Gets or sets the bundle items.
        /// </summary>
        /// <value>The bundle items.</value>
        [JsonProperty("bundleItems")]
        public NotNullObserver[] BundleItems { get; set; }

        /// <summary>
        /// Gets or sets the parameters.
        /// </summary>
        /// <value>The parameters.</value>
        [JsonProperty("params")]
        public NotNullObserver[] Params { get; set; }

        /// <summary>
        /// Gets or sets the offerings.
        /// </summary>
        /// <value>The offerings.</value>
        [JsonProperty("offerings")]
        public NotNullObserver[] Offerings { get; set; }

        /// <summary>
        /// Gets or sets the seller sku.
        /// </summary>
        /// <value>The seller sku.</value>
        [JsonProperty("sellerSku")]
        public string SellerSku { get; set; }

        /// <summary>
        /// Gets or sets the price valid until.
        /// </summary>
        /// <value>The price valid until.</value>
        [JsonProperty("priceValidUntil")]
        public NotNullObserver PriceValidUntil { get; set; }

        /// <summary>
        /// Gets or sets the commission.
        /// </summary>
        /// <value>The commission.</value>
        [JsonProperty("commission")]
        public int Commission { get; set; }

        /// <summary>
        /// Gets or sets the tax.
        /// </summary>
        /// <value>The tax.</value>
        [JsonProperty("tax")]
        public int Tax { get; set; }

        /// <summary>
        /// Gets or sets the pre sale date.
        /// </summary>
        /// <value>The pre sale date.</value>
        [JsonProperty("preSaleDate")]
        public DateTime? PreSaleDate { get; set; }

        /// <summary>
        /// Gets or sets the default picker.
        /// </summary>
        /// <value>The default picker.</value>
        [JsonProperty("defaultPicker")]
        public NotNullObserver DefaultPicker { get; set; }

        /// <summary>
        /// Gets or sets the handler sequence.
        /// </summary>
        /// <value>The handler sequence.</value>
        [JsonProperty("handlerSequence")]
        public int HandlerSequence { get; set; }

        /// <summary>
        /// Gets or sets the handling.
        /// </summary>
        /// <value>The handling.</value>
        [JsonProperty("handling")]
        public bool Handling { get; set; }

        /// <summary>
        /// Gets or sets the additional information.
        /// </summary>
        /// <value>The additional information.</value>
        [JsonProperty("additionalInfo")]
        public AdditionalInfo AdditionalInfo { get; set; }

        /// <summary>
        /// Gets or sets the measurement unit.
        /// </summary>
        /// <value>The measurement unit.</value>
        [JsonProperty("measurementUnit")]
        public string MeasurementUnit { get; set; }

        /// <summary>
        /// Gets or sets the unit multiplier.
        /// </summary>
        /// <value>The unit multiplier.</value>
        [JsonProperty("unitMultiplier")]
        public decimal UnitMultiplier { get; set; }

        /// <summary>
        /// Gets or sets the selling price.
        /// </summary>
        /// <value>The selling price.</value>
        [JsonProperty("sellingPrice")]
        public int SellingPrice { get; set; }

        /// <summary>
        /// Gets or sets the is gift.
        /// </summary>
        /// <value>The is gift.</value>
        [JsonProperty("isGift")]
        public bool IsGift { get; set; }

        /// <summary>
        /// Gets or sets the item attachment.
        /// </summary>
        /// <value>The item attachment.</value>
        [JsonProperty("itemAttachment")]
        public ItemAttachment ItemAttachment { get; set; }

        /// <summary>
        /// Gets or sets the attachments.
        /// </summary>
        /// <value>The attachments.</value>
        [JsonProperty("attachments")]
        public NotNullObserver[] Attachments { get; set; }

        /// <summary>
        /// Gets or sets the manual price.
        /// </summary>
        /// <value>The manual price.</value>
        [JsonProperty("manualPrice")]
        public NotNullObserver ManualPrice { get; set; }

        /// <summary>
        /// Gets or sets the detail URL.
        /// </summary>
        /// <value>The detail URL.</value>
        [JsonProperty("detailUrl")]
        public string DetailUrl { get; set; }

        /// <summary>
        /// Gets or sets the offering information.
        /// </summary>
        /// <value>The offering information.</value>
        [JsonProperty("offeringInfo")]
        public NotNullObserver OfferingInfo { get; set; }

        /// <summary>
        /// Gets or sets the shipping price.
        /// </summary>
        /// <value>The shipping price.</value>
        [JsonProperty("shippingPrice")]
        public NotNullObserver ShippingPrice { get; set; }

        /// <summary>
        /// Gets or sets the reward value.
        /// </summary>
        /// <value>The reward value.</value>
        [JsonProperty("rewardValue")]
        public int RewardValue { get; set; }

        /// <summary>
        /// Gets or sets the freight commission.
        /// </summary>
        /// <value>The freight commission.</value>
        [JsonProperty("freightCommission")]
        public int FreightCommission { get; set; }

        /// <summary>
        /// Gets or sets the price definitions.
        /// </summary>
        /// <value>The price definitions.</value>
        [JsonProperty("priceDefinitions")]
        public NotNullObserver PriceDefinitions { get; set; }

        /// <summary>
        /// Gets or sets the tax code.
        /// </summary>
        /// <value>The tax code.</value>
        [JsonProperty("taxCode")]
        public string TaxCode { get; set; }

        /// <summary>
        /// Gets or sets the product categories.
        /// </summary>
        /// <value>The product categories.</value>
        [JsonProperty("productCategories")]
        public Dictionary<int, string> ProductCategories { get; set; }

        /// <summary>
        /// Gets or sets the index of the parent item.
        /// </summary>
        /// <value>The index of the parent item.</value>
        [JsonProperty("parentItemIndex")]
        public NotNullObserver ParentItemIndex { get; set; }

        /// <summary>
        /// Gets or sets the parent assembly binding.
        /// </summary>
        /// <value>The parent assembly binding.</value>
        [JsonProperty("parentAssemblyBinding")]
        public NotNullObserver ParentAssemblyBinding { get; set; }

        /// <summary>
        /// Gets or sets the call center operator.
        /// </summary>
        /// <value>The call center operator.</value>
        [JsonProperty("callCenterOperator")]
        public string CallCenterOperator { get; set; }

        /// <summary>
        /// Gets or sets the serial numbers.
        /// </summary>
        /// <value>The serial numbers.</value>
        [JsonProperty("serialNumbers")]
        public NotNullObserver SerialNumbers { get; set; }

        /// <summary>
        /// Gets or sets the assemblies.
        /// </summary>
        /// <value>The assemblies.</value>
        [JsonProperty("assemblies")]
        public NotNullObserver[] Assemblies { get; set; }

        /// <summary>
        /// Gets or sets the cost price.
        /// </summary>
        /// <value>The cost price.</value>
        [JsonProperty("costPrice")]
        public decimal CostPrice { get; set; }
    }
}
