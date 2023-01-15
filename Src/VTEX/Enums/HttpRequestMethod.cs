// ***********************************************************************
// Assembly         : VTEX
// Author           : Guilherme Branco Stracini
// Created          : 01-15-2023
//
// Last Modified By : Guilherme Branco Stracini
// Last Modified On : 01-15-2023
// ***********************************************************************
// <copyright file="HttpRequestMethod.cs" company="Guilherme Branco Stracini">
//     © 2020 Guilherme Branco Stracini. All rights reserved.
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
