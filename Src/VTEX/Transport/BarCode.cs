// ***********************************************************************
// Assembly         : IntegracaoService.VTEX
// Author           : Guilherme Branco Stracini
// Created          : 12-20-2016
//
// Last Modified By : Guilherme Branco Stracini
// Last Modified On : 12-20-2016
// ***********************************************************************
// <copyright file="BarCode.cs" company="Guilherme Branco Stracini ME">
//     © 2016 Guilherme Branco Stracini, All Rights Reserved
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
