// ***********************************************************************
// Assembly         : VTEX
// Author           : Guilherme Branco Stracini
// Created          : 01-16-2023
//
// Last Modified By : Guilherme Branco Stracini
// Last Modified On : 01-16-2023
// ***********************************************************************
// <copyright file="CancellationData.cs" company="Guilherme Branco Stracini">
//     © 2020 Guilherme Branco Stracini. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
namespace VTEX.Transport
{
    using System;

    /// <summary>
    /// Class CancellationData.
    /// </summary>
    public class CancellationData
    {
        /// <summary>
        /// Gets or sets a value indicating whether [requested by user].
        /// </summary>
        /// <value><c>true</c> if [requested by user]; otherwise, <c>false</c>.</value>
        public bool RequestedByUser { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [requested by system].
        /// </summary>
        /// <value><c>true</c> if [requested by system]; otherwise, <c>false</c>.</value>
        public bool RequestedBySystem { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [requested by seller notification].
        /// </summary>
        /// <value><c>true</c> if [requested by seller notification]; otherwise, <c>false</c>.</value>
        public bool RequestedBySellerNotification { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [requested by payment notification].
        /// </summary>
        /// <value><c>true</c> if [requested by payment notification]; otherwise, <c>false</c>.</value>
        public bool RequestedByPaymentNotification { get; set; }

        /// <summary>
        /// Gets or sets the reason.
        /// </summary>
        /// <value>The reason.</value>
        public string Reason { get; set; }

        /// <summary>
        /// Gets or sets the cancellation date.
        /// </summary>
        /// <value>The cancellation date.</value>
        public DateTime CancellationDate { get; set; }
    }
}
