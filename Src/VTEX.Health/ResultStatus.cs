// ***********************************************************************
// Assembly         : VTEX.Health
// Author           : Guilherme Branco Stracini
// Created          : 01-15-2023
//
// Last Modified By : Guilherme Branco Stracini
// Last Modified On : 01-15-2023
// ***********************************************************************
// <copyright file="ResultStatus.cs" company="Guilherme Branco Stracini">
//     © 2020 Guilherme Branco Stracini. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
namespace VTEX.Health
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
