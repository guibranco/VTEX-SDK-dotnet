// ***********************************************************************
// Assembly         : VTEX
// Author           : Guilherme Branco Stracini
// Created          : 01-15-2023
//
// Last Modified By : Guilherme Branco Stracini
// Last Modified On : 01-15-2023
// ***********************************************************************
// <copyright file="BarCode.cs" company="Guilherme Branco Stracini">
//     © 2020 Guilherme Branco Stracini. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
namespace VTEX.Transport
{
    /// <summary>
    /// Class BarCode. This class cannot be inherited.
    /// </summary>
    public sealed class BarCode
    {
        /// <summary>
        /// Gets or sets the bar code image.
        /// </summary>
        /// <value>The bar code image.</value>
        public string BarCodeImage { get; set; }
        /// <summary>
        /// Gets or sets the bar code number.
        /// </summary>
        /// <value>The bar code number.</value>
        public string BarCodeNumber { get; set; }
    }
}
