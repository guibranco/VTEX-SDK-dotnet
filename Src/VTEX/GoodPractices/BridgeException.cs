// ***********************************************************************
// Assembly         : IntegracaoService.VTEX
// Author           : Guilherme Branco Stracini
// Created          : 13/04/2017
//
// Last Modified By : Guilherme Branco Stracini
// Last Modified On : 13/04/2017
// ***********************************************************************
// <copyright file="BridgeException.cs" company="Guilherme Branco Stracini ME">
//     © 2011-2019 Guilherme Branco Stracini, All Rights Reserved
// </copyright>
// <summary></summary>
// ***********************************************************************

namespace VTEX.GoodPractices
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// Class BridgeException. This class cannot be inherited.
    /// </summary>
    /// <seealso cref="Exception" />

    [Serializable]
    public class BridgeException : Exception
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BridgeException"/> class.
        /// </summary>
        /// <param name="query">The query.</param>
        /// <param name="innerException">The inner exception.</param>
        public BridgeException(string query, Exception innerException)
            : base(string.Format(Resources.BridgeException, query), innerException)
        { }

        /// <summary>
        /// Initializes a new instance of the <see cref="BridgeException"/> class.
        /// </summary>
        /// <param name="info">The <see cref="T:System.Runtime.Serialization.SerializationInfo" /> that holds the serialized object data about the exception being thrown.</param>
        /// <param name="context">The <see cref="T:System.Runtime.Serialization.StreamingContext" /> that contains contextual information about the source or destination.</param>
        protected BridgeException(SerializationInfo info, StreamingContext context) : base(info, context)
        { }
    }
}
