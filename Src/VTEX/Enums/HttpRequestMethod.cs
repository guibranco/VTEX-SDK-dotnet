// ***********************************************************************
// Assembly         : IntegracaoService.Commons
// Author           : Guilherme Branco Stracini
// Created          : 11-04-2016
//
// Last Modified By : Guilherme Branco Stracini
// Last Modified On : 13/04/2017
// ***********************************************************************
// <copyright file="HttpRequestMethod.cs" company="Guilherme Branco Stracini ME">
//     © 2011-2019 Guilherme Branco Stracini, All Rights Reserved
// </copyright>
// <summary></summary>
// ***********************************************************************

namespace VTEX.Enums
{
    using CrispyWaffle.Attributes;

    /// <summary>
    /// Enum HttpRequestMethod
    /// </summary>
    public enum HttpRequestMethod
    {
        /// <summary>
        /// The none
        /// </summary>
        [HumanReadable("None")]
        [InternalValue("NONE")]
        NONE,

        /// <summary>
        /// The delete
        /// </summary>
        [HumanReadable("DELETE")]
        [InternalValue("DELETE")]
        DELETE,

        /// <summary>
        /// The get
        /// </summary>
        [HumanReadable("GET")]
        [InternalValue("GET")]
        GET,

        /// <summary>
        /// The head
        /// </summary>
        [HumanReadable("HEAD")]
        [InternalValue("HEAD")]
        HEAD,

        /// <summary>
        /// The options
        /// </summary>
        [HumanReadable("OPTIONS")]
        [InternalValue("OPTIONS")]
        OPTIONS,

        /// <summary>
        /// The patch
        /// </summary>
        [HumanReadable("PATCH")]
        [InternalValue("PATCH")]
        PATCH,

        /// <summary>
        /// The post
        /// </summary>
        [HumanReadable("POST")]
        [InternalValue("POST")]
        POST,

        /// <summary>
        /// The put
        /// </summary>
        [HumanReadable("PUT")]
        [InternalValue("PUT")]
        PUT,
    }
}
