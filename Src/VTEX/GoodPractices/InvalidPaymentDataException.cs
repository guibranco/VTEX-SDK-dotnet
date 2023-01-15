// ***********************************************************************
// Assembly         : VTEX
// Author           : Guilherme Branco Stracini
// Created          : 01-15-2023
//
// Last Modified By : Guilherme Branco Stracini
// Last Modified On : 01-15-2023
// ***********************************************************************
// <copyright file="InvalidPaymentDataException.cs" company="Guilherme Branco Stracini">
//     © 2020 Guilherme Branco Stracini. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
namespace VTEX.GoodPractices
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// Class InvalidPaymentDataException. This class cannot be inherited.
    /// </summary>
    /// <seealso cref="Exception" />
    [Serializable]
    public class InvalidPaymentDataException : Exception
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InvalidPaymentDataException" /> class.
        /// </summary>
        /// <param name="orderId">The order identifier.</param>
        public InvalidPaymentDataException(int orderId) :
            base($"The order {orderId} hasn't valid payment data")
        { }

        /// <summary>
        /// Initializes a new instance of the <see cref="InvalidPaymentDataException" /> class.
        /// </summary>
        /// <param name="term">The term.</param>
        public InvalidPaymentDataException(string term) :
            base($"Unable to identify the payment data for the query '{term}'")
        { }

        /// <summary>
        /// Initializes a new instance of the <see cref="InvalidPaymentDataException" /> class.
        /// </summary>
        /// <param name="info">The <see cref="T:System.Runtime.Serialization.SerializationInfo" /> that holds the serialized object data about the exception being thrown.</param>
        /// <param name="context">The <see cref="T:System.Runtime.Serialization.StreamingContext" /> that contains contextual information about the source or destination.</param>
        protected InvalidPaymentDataException(SerializationInfo info, StreamingContext context) : base(info, context)
        { }
    }
}
