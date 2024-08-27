// ***********************************************************************
// Assembly         : VTEX
// Author           : Guilherme Branco Stracini
// Created          : 01-15-2023
//
// Last Modified By : Guilherme Branco Stracini
// Last Modified On : 01-16-2023
// ***********************************************************************
// <copyright file="RequestEndpoint.cs" company="Guilherme Branco Stracini">
//     © 2020 Guilherme Branco Stracini. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
namespace VTEX.Enums
{
    /// <summary>
    /// The request endpoint enumeration
    /// </summary>
    public enum RequestEndpoint
    {
        /// <summary>
        /// The default
        /// </summary>
        DEFAULT,

        /// <summary>
        /// The payments
        /// </summary>
        PAYMENTS,

        /// <summary>
        /// The logistics
        /// </summary>
        LOGISTICS,

        /// <summary>
        /// The API
        /// </summary>
        API,

        /// <summary>
        /// The bridge.
        /// </summary>
        BRIDGE,

        /// <summary>
        /// The master data
        /// </summary>
        MASTER_DATA,

        /// <summary>
        /// The health
        /// </summary>
        HEALTH,
    }
}
