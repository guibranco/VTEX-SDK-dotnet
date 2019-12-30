// ***********************************************************************
// Assembly         : IntegracaoService.VTEX
// Author           : Guilherme Branco Stracini
// Created          : 12-20-2016
//
// Last Modified By : Guilherme Branco Stracini
// Last Modified On : 12-20-2016
// ***********************************************************************
// <copyright file="CourierData.cs" company="Guilherme Branco Stracini ME">
//     © 2016 Guilherme Branco Stracini, All Rights Reserved
// </copyright>
// <summary></summary>
// ***********************************************************************

namespace VTEX.Transport
{
    using System;

    /// <summary>
    /// Class CourierData. This class cannot be inherited.
    /// </summary>
    public sealed class CourierData
    {
        /// <summary>
        /// The last change
        /// </summary>
        private DateTimeOffset _lastChange;

        /// <summary>
        /// Gets or sets the last change.
        /// </summary>
        /// <value>The last change.</value>
        public DateTime LastChange
        {
            get => _lastChange.LocalDateTime;
            set => _lastChange = value;
        }

        /// <summary>
        /// Gets or sets the city.
        /// </summary>
        /// <value>The city.</value>
        public string City { get; set; }
        /// <summary>
        /// Gets or sets the state.
        /// </summary>
        /// <value>The state.</value>
        public string State { get; set; }
        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        /// <value>The description.</value>
        public string Description { get; set; }
    }
}