// ***********************************************************************
// Assembly         : IntegracaoService.Commons
// Author           : Guilherme Branco Stracini
// Created          : 12-20-2016
//
// Last Modified By : Guilherme Branco Stracini
// Last Modified On : 12-20-2016
// ***********************************************************************
// <copyright file="InvalidPaymentDataException.cs" company="Guilherme Branco Stracini ME">
//     © 2011-2019 Guilherme Branco Stracini, All Rights Reserved
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
        /// Initializes a new instance of the <see cref="InvalidPaymentDataException"/> class.
        /// </summary>
        /// <param name="orderId">The order identifier.</param>
        public InvalidPaymentDataException(int orderId) :
            base($"The order {orderId} hasn't valid payment data")
        { }

        /// <summary>
        /// Initializes a new instance of the <see cref="InvalidPaymentDataException"/> class.
        /// </summary>
        /// <param name="term">The term.</param>
        public InvalidPaymentDataException(string term) :
            base($"Unable to identify the payment data for the query '{term}'")
        { }

        /// <summary>
        /// Initializes a new instance of the <see cref="InvalidPaymentDataException"/> class.
        /// </summary>
        /// <param name="info">The <see cref="T:System.Runtime.Serialization.SerializationInfo" /> that holds the serialized object data about the exception being thrown.</param>
        /// <param name="context">The <see cref="T:System.Runtime.Serialization.StreamingContext" /> that contains contextual information about the source or destination.</param>
        protected InvalidPaymentDataException(SerializationInfo info, StreamingContext context) : base(info, context)
        { }
    }
}
