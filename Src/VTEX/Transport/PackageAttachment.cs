// ***********************************************************************
// Assembly         : VTEX
// Author           : Guilherme Branco Stracini
// Created          : 01-15-2023
//
// Last Modified By : Guilherme Branco Stracini
// Last Modified On : 01-16-2023
// ***********************************************************************
// <copyright file="PackageAttachment.cs" company="Guilherme Branco Stracini">
//     © 2020 Guilherme Branco Stracini. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
namespace VTEX.Transport
{
    using Newtonsoft.Json;

    /// <summary>
    /// A package attachment.
    /// </summary>
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