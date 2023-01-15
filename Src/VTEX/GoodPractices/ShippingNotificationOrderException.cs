// ***********************************************************************
// Assembly         : VTEX
// Author           : Guilherme Branco Stracini
// Created          : 01-15-2023
//
// Last Modified By : Guilherme Branco Stracini
// Last Modified On : 01-16-2023
// ***********************************************************************
// <copyright file="ShippingNotificationOrderException.cs" company="Guilherme Branco Stracini">
//     © 2020 Guilherme Branco Stracini. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
namespace VTEX.GoodPractices
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// Class ShippingNotificationOrderException. This class cannot be inherited.
    /// </summary>
    /// <seealso cref="Exception" />
    [Serializable]
    public class ShippingNotificationOrderException : Exception
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ShippingNotificationOrderException" /> class.
        /// </summary>
        /// <param name="sequence">The sequence.</param>
        /// <param name="innerException">The inner exception.</param>
        public ShippingNotificationOrderException(int sequence, Exception innerException)
            : base($"Unable to send shipping notification for the order {sequence}", innerException)
        { }

        /// <summary>
        /// Initializes a new instance of the <see cref="ShippingNotificationOrderException" /> class.
        /// </summary>
        /// <param name="orderId">The order identifier.</param>
        /// <param name="innerException">The inner exception.</param>
        public ShippingNotificationOrderException(string orderId, Exception innerException)
            : base($"Unable to send shipping notification for the order {orderId}", innerException)
        { }

        /// <summary>
        /// Initializes a new instance of the <see cref="ShippingNotificationOrderException" /> class.
        /// </summary>
        /// <param name="info">The <see cref="T:System.Runtime.Serialization.SerializationInfo" /> that holds the serialized object data about the exception being thrown.</param>
        /// <param name="context">The <see cref="T:System.Runtime.Serialization.StreamingContext" /> that contains contextual information about the source or destination.</param>
        protected ShippingNotificationOrderException(SerializationInfo info, StreamingContext context) : base(info, context)
        { }
    }
}
