// ***********************************************************************
// Assembly         : IntegracaoService.VTEX
// Author           : Guilherme Branco Stracini
// Created          : 12-20-2016
//
// Last Modified By : Guilherme Branco Stracini
// Last Modified On : 12-26-2016
// ***********************************************************************
// <copyright file="PackageAttachment.cs" company="Guilherme Branco Stracini ME">
//     © 2016 Guilherme Branco Stracini, All Rights Reserved
// </copyright>
// <summary></summary>
// ***********************************************************************

namespace VTEX.Transport
{
    using Newtonsoft.Json;

    /// <summary>
    /// A package attachment.
    /// </summary>
    /// <remarks>Versão: 1.61.3637.731
    /// Autor: Guilherme Branco Stracini
    /// Data: 02/06/2014.</remarks>

    public sealed class PackageAttachment
    {
        /// <summary>
        /// Gets or sets the packages.
        /// </summary>
        /// <value>The packages.</value>

        [JsonProperty("packages")]
        public Package[] Packages { get; set; }
    }
}