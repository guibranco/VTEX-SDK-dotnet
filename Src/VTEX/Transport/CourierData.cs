// ***********************************************************************
// Assembly         : VTEX
// Author           : Guilherme Branco Stracini
// Created          : 01-15-2023
//
// Last Modified By : Guilherme Branco Stracini
// Last Modified On : 01-16-2023
// ***********************************************************************
// <copyright file="CourierData.cs" company="Guilherme Branco Stracini">
//     © 2020 Guilherme Branco Stracini. All rights reserved.
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
        /// Gets or sets the create date.
        /// </summary>
        /// <value>The create date.</value>
        public DateTime CreateDate { get; set; }

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
