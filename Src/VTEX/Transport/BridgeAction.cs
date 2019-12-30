// ***********************************************************************
// Assembly         : IntegracaoService.VTEX
// Author           : Guilherme Branco Stracini
// Created          : 12/04/2017
//
// Last Modified By : Guilherme Branco Stracini
// Last Modified On : 12/04/2017
// ***********************************************************************
// <copyright file="BridgeAction.cs" company="Guilherme Branco Stracini ME">
//     © 2011-2019 Guilherme Branco Stracini, All Rights Reserved
// </copyright>
// <summary></summary>
// ***********************************************************************

namespace VTEX.Transport
{
    using CrispyWaffle.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// Class BridgeAction. This class cannot be inherited.
    /// </summary>

    [Serializer(SerializerFormat.JSON)]
    public sealed class BridgeAction
    {
        /// <summary>
        /// Gets or sets the action identifier.
        /// </summary>
        /// <value>The action identifier.</value>
        [JsonProperty("actionid")]
        public string ActionId { get; set; }

        /// <summary>
        /// Gets or sets the URL callback.
        /// </summary>
        /// <value>The URL callback.</value>
        [JsonProperty("urlcallback")]
        public string UrlCallback { get; set; }

    }
}
