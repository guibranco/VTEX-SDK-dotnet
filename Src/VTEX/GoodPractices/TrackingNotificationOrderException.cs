// ***********************************************************************
// Assembly         : IntegracaoService.VTEX
// Author           : Guilherme Branco Stracini
// Created          : 30/01/2018
//
// Last Modified By : Guilherme Branco Stracini
// Last Modified On : 30/01/2018
// ***********************************************************************
// <copyright file="TrackingNotificationOrderException.cs" company="Guilherme Branco Stracini ME">
//     © 2011-2019 Guilherme Branco Stracini, All Rights Reserved
// </copyright>
// <summary></summary>
// ***********************************************************************

namespace VTEX.GoodPractices
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// Class TrackingNotificationOrderException. This class cannot be inherited.
    /// </summary>
    /// <seealso cref="Exception" />
    [Serializable]
    public class TrackingNotificationOrderException : Exception
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TrackingNotificationOrderException" /> class.
        /// </summary>
        /// <param name="sequence">The sequence.</param>
        /// <param name="innerException">The inner exception.</param>
        public TrackingNotificationOrderException(int sequence, Exception innerException)
            : base(string.Format(Resources.TrackingNotificationOrderException, sequence), innerException)
        { }

        /// <summary>
        /// Initializes a new instance of the <see cref="TrackingNotificationOrderException" /> class.
        /// </summary>
        /// <param name="orderId">The order identifier.</param>
        /// <param name="innerException">The inner exception.</param>
        public TrackingNotificationOrderException(string orderId, Exception innerException)
            : base(string.Format(Resources.TrackingNotificationOrderException, orderId), innerException)
        { }

        /// <summary>
        /// Initializes a new instance of the <see cref="TrackingNotificationOrderException"/> class.
        /// </summary>
        /// <param name="info">The <see cref="T:System.Runtime.Serialization.SerializationInfo" /> that holds the serialized object data about the exception being thrown.</param>
        /// <param name="context">The <see cref="T:System.Runtime.Serialization.StreamingContext" /> that contains contextual information about the source or destination.</param>
        protected TrackingNotificationOrderException(SerializationInfo info, StreamingContext context) : base(info, context)
        { }
    }
}
