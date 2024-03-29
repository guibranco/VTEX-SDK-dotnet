﻿// ***********************************************************************
// Assembly         : VTEX
// Author           : Guilherme Branco Stracini
// Created          : 01-15-2023
//
// Last Modified By : Guilherme Branco Stracini
// Last Modified On : 01-16-2023
// ***********************************************************************
// <copyright file="Sheet.cs" company="Guilherme Branco Stracini">
//     © 2020 Guilherme Branco Stracini. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
namespace VTEX.Transport
{
    /// <summary>
    /// Class Sheet. This class cannot be inherited.
    /// </summary>
    public sealed class Sheet
    {
        /// <summary>
        /// Gets or sets the installment.
        /// </summary>
        /// <value>The installment.</value>
        public int Installment { get; set; }

        /// <summary>
        /// Gets or sets the due date.
        /// </summary>
        /// <value>The due date.</value>
        public string DueDate { get; set; }

        /// <summary>
        /// Gets or sets the value.
        /// </summary>
        /// <value>The value.</value>
        public int Value { get; set; }

        /// <summary>
        /// Gets or sets the sheet number.
        /// </summary>
        /// <value>The sheet number.</value>
        public string SheetNumber { get; set; }

        /// <summary>
        /// Gets or sets the bar code number.
        /// </summary>
        /// <value>The bar code number.</value>
        public string BarCodeNumber { get; set; }

        /// <summary>
        /// Gets or sets the print.
        /// </summary>
        /// <value>The print.</value>
        public Print Print { get; set; }

        /// <summary>
        /// Gets or sets our number.
        /// </summary>
        /// <value>Our number.</value>
        public string OurNumber { get; set; }
    }
}
