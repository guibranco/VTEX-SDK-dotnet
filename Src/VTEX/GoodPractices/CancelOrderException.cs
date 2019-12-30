// ***********************************************************************
// Assembly         : IntegracaoService.Commons
// Author           : Guilherme Branco Stracini
// Created          : 12-26-2016
//
// Last Modified By : Guilherme Branco Stracini
// Last Modified On : 12-26-2016
// ***********************************************************************
// <copyright file="CancelOrderException.cs" company="Guilherme Branco Stracini ME">
//     © 2011-2019 Guilherme Branco Stracini, All Rights Reserved
// </copyright>
// <summary></summary>
// ***********************************************************************
// ***********************************************************************
// Assembly         : IntegracaoService.Commons
// Author           : Guilherme Branco Stracini
// Created          : 12-04-2016
//
// Last Modified By : Guilherme Branco Stracini
// Last Modified On : 12-04-2016
// ***********************************************************************
// <copyright file="CancelOrderException.cs" company="Guilherme Branco Stracini ME">
//     © 2011-2019 Guilherme Branco Stracini, All Rights Reserved
// </copyright>
// <summary></summary>
// ***********************************************************************

namespace VTEX.GoodPractices
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// Class CancelOrderException. This class cannot be inherited.
    /// </summary>
    /// <seealso cref="Exception" />
    [Serializable]
    public class CancelOrderException : Exception
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CancelOrderException"/> class.
        /// </summary>
        /// <param name="orderId">The order identifier.</param>
        /// <param name="innerException">The inner exception.</param>
        public CancelOrderException(string orderId, Exception innerException)
            : base($"Unable to cancel order {orderId} in VTEX platform", innerException)
        { }

        /// <summary>
        /// Initializes a new instance of the <see cref="CancelOrderException"/> class.
        /// </summary>
        /// <param name="innerException">The inner exception.</param>
        public CancelOrderException(Exception innerException)
            : base("Unable to cancel orders. See inner exception for details", innerException)
        { }

        /// <summary>
        /// Initializes a new instance of the <see cref="CancelOrderException"/> class.
        /// </summary>
        /// <param name="info">The <see cref="T:System.Runtime.Serialization.SerializationInfo" /> that holds the serialized object data about the exception being thrown.</param>
        /// <param name="context">The <see cref="T:System.Runtime.Serialization.StreamingContext" /> that contains contextual information about the source or destination.</param>
        protected CancelOrderException(SerializationInfo info, StreamingContext context) : base(info, context)
        { }
    }
}
