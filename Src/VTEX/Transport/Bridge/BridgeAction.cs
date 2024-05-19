// ***********************************************************************
// Assembly         : VTEX
// Author           : Guilherme Branco Stracini
// Created          : 01-15-2023
//
// Last Modified By : Guilherme Branco Stracini
// Last Modified On : 01-16-2023
// ***********************************************************************
// <copyright file="BridgeAction.cs" company="Guilherme Branco Stracini">
//     © 2020 Guilherme Branco Stracini. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
namespace VTEX.Transport.Bridge
{
    using CrispyWaffle.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// Class BridgeAction. This class cannot be inherited.
    /// </summary>
    [Serializer(SerializerFormat.Json)]
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
