// ***********************************************************************
// Assembly         : IntegracaoService.Commons
// Author           : Guilherme Branco Stracini
// Created          : 11-04-2016
//
// Last Modified By : Guilherme Branco Stracini
// Last Modified On : 12-26-2016
// ***********************************************************************
// <copyright file="ProductExportException.cs" company="Guilherme Branco Stracini ME">
//     © 2011-2019 Guilherme Branco Stracini, All Rights Reserved
// </copyright>
// <summary></summary>
// ***********************************************************************

namespace VTEX.GoodPractices
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// Class ProductExportException. This class cannot be inherited.
    /// </summary>
    /// <seealso cref="Exception" />
    [Serializable]
    public class ProductExportException : Exception
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProductExportException" /> class.
        /// </summary>
        /// <param name="innerException">The inner exception.</param>
        public ProductExportException(Exception innerException)
            : base("Unable to export product to VTEX platform", innerException)
        { }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProductExportException" /> class.
        /// </summary>
        /// <param name="code">The code.</param>
        /// <param name="innerException">The inner exception.</param>
        public ProductExportException(int code, Exception innerException)
            : base($"Unable to export product {code} to VTEX platform", innerException)
        { }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProductExportException"/> class.
        /// </summary>
        /// <param name="info">The <see cref="T:System.Runtime.Serialization.SerializationInfo" /> that holds the serialized object data about the exception being thrown.</param>
        /// <param name="context">The <see cref="T:System.Runtime.Serialization.StreamingContext" /> that contains contextual information about the source or destination.</param>
        protected ProductExportException(SerializationInfo info, StreamingContext context) : base(info, context)
        { }
    }
}
