// ***********************************************************************
// Assembly         : VTEX
// Author           : Guilherme Branco Stracini
// Created          : 01-15-2023
//
// Last Modified By : Guilherme Branco Stracini
// Last Modified On : 01-16-2023
// ***********************************************************************
// <copyright file="UnexpectedApiResponseException.cs" company="Guilherme Branco Stracini">
//     © 2020 Guilherme Branco Stracini. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
namespace VTEX.GoodPractices
{
    using CrispyWaffle.GoodPractices;
    using System;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    /// <summary>
    /// Class UnexpectedApiResponseException. This class cannot be inherited.
    /// </summary>
    /// <seealso cref="IRestException" />
    /// <seealso cref="Exception" />

    [Serializable]
    public class UnexpectedApiResponseException : Exception, IRestException
    {
        #region ~Ctors

        /// <summary>
        /// Initializes a new instance of the <see cref="UnexpectedApiResponseException" /> class.
        /// </summary>
        /// <param name="responseBody">The response body.</param>
        /// <param name="innerException">The inner exception.</param>
        public UnexpectedApiResponseException(string responseBody, Exception innerException)
            : base("Unable to complete the request", innerException)
        {
            Response = responseBody;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UnexpectedApiResponseException" /> class.
        /// </summary>
        /// <param name="uri">The URI.</param>
        /// <param name="method">The HTTP requested method.</param>
        /// <param name="requestBody">The request body.</param>
        /// <param name="responseBody">The response body.</param>
        /// <param name="statusCode">The HTTP status code of response.</param>
        /// <param name="innerException">The inner exception.</param>
        public UnexpectedApiResponseException(
            Uri uri,
            string method,
            string requestBody,
            string responseBody,
            int statusCode,
            Exception innerException
        )
            : base(
                $"Unable to complete {method} request to VTEX REST API at Endpoint: {uri}",
                innerException
            )
        {
            Request = requestBody;
            Response = responseBody;
            StatusCode = statusCode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UnexpectedApiResponseException" /> class.
        /// </summary>
        /// <param name="info">The <see cref="T:System.Runtime.Serialization.SerializationInfo" /> that holds the serialized object data about the exception being thrown.</param>
        /// <param name="context">The <see cref="T:System.Runtime.Serialization.StreamingContext" /> that contains contextual information about the source or destination.</param>
        protected UnexpectedApiResponseException(SerializationInfo info, StreamingContext context)
            : base(info, context) { }

        #endregion

        #region Overrides of Exception

        /// <summary>
        /// When overridden in a derived class, sets the <see cref="T:System.Runtime.Serialization.SerializationInfo" /> with information about the exception.
        /// </summary>
        /// <param name="info">The <see cref="T:System.Runtime.Serialization.SerializationInfo" /> that holds the serialized object data about the exception being thrown.</param>
        /// <param name="context">The <see cref="T:System.Runtime.Serialization.StreamingContext" /> that contains contextual information about the source or destination.</param>
        /// <exception cref="System.ArgumentNullException">info</exception>
        [SecurityPermission(SecurityAction.Demand, SerializationFormatter = true)]
        public override void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            if (info == null)
            {
                throw new ArgumentNullException(nameof(info));
            }

            info.AddValue("Request", Request);
            info.AddValue("Response", Response);
            info.AddValue("StatusCode", StatusCode);
            base.GetObjectData(info, context);
        }

        #endregion

        #region Public properties

        /// <summary>
        /// Gets or sets the request.
        /// </summary>
        /// <value>The request.</value>
        public string Request { get; }

        /// <summary>
        /// Gets the response.
        /// </summary>
        /// <value>The response.</value>
        public string Response { get; }

        /// <summary>
        /// Gets the status code.
        /// </summary>
        /// <value>The status code.</value>
        public int StatusCode { get; }

        #endregion
    }
}
