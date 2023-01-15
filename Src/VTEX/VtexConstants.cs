// ***********************************************************************
// Assembly         : 
// Author           : Guilherme Branco Stracini
// Created          : 01-16-2023
//
// Last Modified By : Guilherme Branco Stracini
// Last Modified On : 01-16-2023
// ***********************************************************************
// <copyright file="VTEXConstants.cs" company="Guilherme Branco Stracini ME">
//     Copyright (c) Guilherme Branco Stracini ME. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
namespace VTEX
{
    /// <summary>
    /// Class VTEX Constants.
    /// </summary>
    //TODO replace public to internal after remove the old code from Integração Service.
    public static class VTEXConstants
    {
        /// <summary>
        /// The platform stable domain
        /// </summary>
        public const string PlatformStableDomain = "vtexcommercestable.com.br";
        /// <summary>
        /// The payments domain
        /// </summary>
        public const string PaymentsDomain = "vtexpayments.com.br";
        /// <summary>
        /// The logistics domain
        /// </summary>
        public const string LogisticsDomain = "logistics.vtexcommercestable.com.br";
        /// <summary>
        /// The API domain
        /// </summary>
        public const string ApiDomain = "api.vtex.com";
        /// <summary>
        /// My vtex domain
        /// </summary>
        public const string MyVtexDomain = "myvtex.com";
        /// <summary>
        /// The monitoring domain
        /// </summary>
        public const string MonitoringDomain = "monitoring.vtex.com";

        /// <summary>
        /// The vtex identifier client authentication cookie name
        /// </summary>
        public const string VtexIdClientAuthCookieName = "VtexIdclientAutCookie";
    }
}
