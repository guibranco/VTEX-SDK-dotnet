// ***********************************************************************
// Assembly         : IntegracaoService.VTEX
// Author           : Guilherme Branco Stracini
// Created          : 04/05/2017
//
// Last Modified By : Guilherme Branco Stracini
// Last Modified On : 04/05/2017
// ***********************************************************************
// <copyright file="ResultStatus.cs" company="Guilherme Branco Stracini ME">
//     © 2011-2019 Guilherme Branco Stracini, All Rights Reserved
// </copyright>
// <summary></summary>
// ***********************************************************************

namespace VTEX.Enums
{
    using CrispyWaffle.Attributes;

    /// <summary>
    /// Enum ResultStatus
    /// </summary>
    public enum ResultStatus
    {
        /// <summary>
        /// The unhealthy.
        /// </summary>
        [InternalValue("unhealthy")]
        [HumanReadable("Unhealthy")]
        UNHEALTHY,
        /// <summary>
        /// The warning.
        /// </summary>
        [InternalValue("warning")]
        [HumanReadable("Warning")]
        WARNING,
        /// <summary>
        /// The healthy.
        /// </summary>
        [InternalValue("healthy")]
        [HumanReadable("Healthy")]
        HEALTHY,

        /// <summary>
        /// The stopped
        /// </summary>
        [InternalValue("stopped")]
        [HumanReadable("Stopped")]
        STOPPED,

    }
}
