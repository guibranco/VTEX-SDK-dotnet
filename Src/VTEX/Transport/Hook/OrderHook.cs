// ***********************************************************************
// Assembly         : VTEX
// Author           : Guilherme Branco Stracini
// Created          : 01-16-2023
//
// Last Modified By : Guilherme Branco Stracini
// Last Modified On : 01-16-2023
// ***********************************************************************
// <copyright file="OrderHook.cs" company="Guilherme Branco Stracini">
//     © 2020 Guilherme Branco Stracini. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
namespace VTEX.Transport.Hook
{
    using VTEX.Transport.Shared;

    /// <summary>
    /// Class OrderHook.
    /// </summary>
    public class OrderHook
    {
        /// <summary>
        /// Gets or sets the filter.
        /// </summary>
        /// <value>The filter.</value>
        public Filter Filter { get; set; }

        /// <summary>
        /// Gets or sets the hook.
        /// </summary>
        /// <value>The hook.</value>
        public Hook Hook { get; set; }
    }
}
