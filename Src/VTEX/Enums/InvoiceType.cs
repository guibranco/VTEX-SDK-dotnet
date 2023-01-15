// ***********************************************************************
// Assembly         : VTEX
// Author           : Guilherme Branco Stracini
// Created          : 01-15-2023
//
// Last Modified By : Guilherme Branco Stracini
// Last Modified On : 01-15-2023
// ***********************************************************************
// <copyright file="InvoiceType.cs" company="Guilherme Branco Stracini">
//     © 2020 Guilherme Branco Stracini. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
namespace VTEX.Enums
{
    using CrispyWaffle.Attributes;

    /// <summary>
    /// The invoice type enumeration.
    /// Used when sending shipping notification.
    /// </summary>
    public enum InvoiceType
    {

        /// <summary>
        /// The output.
        /// </summary>
        [InternalValue("Output")]
        [HumanReadable("Output")]
        OUTPUT,

        /// <summary>
        /// The input.
        /// </summary>
        [InternalValue("Input")]
        [HumanReadable("Input")]
        INPUT
    }
}
