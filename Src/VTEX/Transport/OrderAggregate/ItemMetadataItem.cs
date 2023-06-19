// ***********************************************************************
// Assembly         : VTEX
// Author           : Guilherme Branco Stracini
// Created          : 01-16-2023
//
// Last Modified By : Guilherme Branco Stracini
// Last Modified On : 01-16-2023
// ***********************************************************************
// <copyright file="ItemMetadataItem.cs" company="Guilherme Branco Stracini">
//     © 2020 Guilherme Branco Stracini. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
namespace VTEX.Transport.OrderAggregate
{
    /// <summary>
    /// Class ItemMetadataItem.
    /// </summary>
    public class ItemMetadataItem
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>The identifier.</value>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the seller.
        /// </summary>
        /// <value>The seller.</value>
        public int Seller { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>The name.</value>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the name of the sku.
        /// </summary>
        /// <value>The name of the sku.</value>
        public string SkuName { get; set; }

        /// <summary>
        /// Gets or sets the product identifier.
        /// </summary>
        /// <value>The product identifier.</value>
        public int ProductId { get; set; }

        /// <summary>
        /// Gets or sets the reference identifier.
        /// </summary>
        /// <value>The reference identifier.</value>
        public string RefId { get; set; }

        /// <summary>
        /// Gets or sets the ean.
        /// </summary>
        /// <value>The ean.</value>
        public string Ean { get; set; }

        /// <summary>
        /// Gets or sets the image URL.
        /// </summary>
        /// <value>The image URL.</value>
        public string ImageUrl { get; set; }

        /// <summary>
        /// Gets or sets the detail URL.
        /// </summary>
        /// <value>The detail URL.</value>
        public string DetailUrl { get; set; }

        /// <summary>
        /// Gets or sets assembly options.
        /// </summary>
        /// <value>assembly options.</value>
        public object[] AssemblyOptions { get; set; }
    }
}
