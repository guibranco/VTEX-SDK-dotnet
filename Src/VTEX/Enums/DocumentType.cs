// ***********************************************************************
// Assembly         : VTEX
// Author           : Guilherme Branco Stracini
// Created          : 01-15-2023
//
// Last Modified By : Guilherme Branco Stracini
// Last Modified On : 01-15-2023
// ***********************************************************************
// <copyright file="DocumentType.cs" company="Guilherme Branco Stracini">
//     © 2020 Guilherme Branco Stracini. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
namespace VTEX.Enums
{
    using CrispyWaffle.Attributes;

    /// <summary>
    /// The document type enumeration.
    /// </summary>
    public enum DocumentType
    {
        /// <summary>
        /// The personal.
        /// </summary>
        [InternalValue("cpf")]
        [HumanReadable("Personal")]
        PERSONAL,

        /// <summary>
        /// The corporate.
        /// </summary>
        [InternalValue("cnpj")]
        [HumanReadable("Corporate")]
        CORPORATE,
    }
}
