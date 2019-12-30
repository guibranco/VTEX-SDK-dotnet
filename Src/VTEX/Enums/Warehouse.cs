// ***********************************************************************
// Assembly         : IntegracaoService.Commons
// Author           : Guilherme Branco Stracini
// Created          : 2016-04-11
//
// Last Modified By : Guilherme Branco Stracini
// Last Modified On : 2018-09-24
// ***********************************************************************
// <copyright file="Stock.cs" company="Guilherme Branco Stracini ME">
//     © 2011-2019 Guilherme Branco Stracini, All Rights Reserved
// </copyright>
// <summary></summary>
// ***********************************************************************

namespace VTEX.Enums
{
    using CrispyWaffle.Attributes;

    /// <summary>
    /// The VTEX warehouse enumeration
    /// </summary>
    public enum Warehouse
    {
        /// <summary>
        /// The default.
        /// </summary>

        [InternalValue("padrao")]
        [HumanReadable("Default")]
        DEFAULT,

        /// <summary>
        /// The online course
        /// </summary>
        [InternalValue("cursos")]
        [HumanReadable("Online course")]
        COURSE
    }
}