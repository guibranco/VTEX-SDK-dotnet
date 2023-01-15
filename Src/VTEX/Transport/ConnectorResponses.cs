// ***********************************************************************
// Assembly         : VTEX
// Author           : Guilherme Branco Stracini
// Created          : 01-15-2023
//
// Last Modified By : Guilherme Branco Stracini
// Last Modified On : 01-15-2023
// ***********************************************************************
// <copyright file="ConnectorResponses.cs" company="Guilherme Branco Stracini">
//     © 2020 Guilherme Branco Stracini. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
namespace VTEX.Transport
{
    using Newtonsoft.Json;

    /// <summary>
    /// Class ConnectorResponses. This class cannot be inherited.
    /// </summary>
    public sealed class ConnectorResponses
    {
        /// <summary>
        /// Gets or sets the tid.
        /// </summary>
        /// <value>The tid.</value>
        [JsonProperty("tid")]
        public string Tid { get; set; }

        /// <summary>
        /// Gets or sets the return code.
        /// </summary>
        /// <value>The return code.</value>
        [JsonProperty("returnCode")]
        public string ReturnCode { get; set; }

        /// <summary>
        /// Gets or sets the message.
        /// </summary>
        /// <value>The message.</value>
        [JsonProperty("message")]
        public string Message { get; set; }

        /// <summary>
        /// Gets or sets the authentication identifier.
        /// </summary>
        /// <value>The authentication identifier.</value>
        [JsonProperty("authId")]
        public string AuthId { get; set; }

        /// <summary>
        /// Gets or sets the nsu.
        /// </summary>
        /// <value>The nsu.</value>
        [JsonProperty("Nsu")]
        public string Nsu { get; set; }

        /// <summary>
        /// Gets or sets the number cv.
        /// </summary>
        /// <value>The number cv.</value>
        [JsonProperty("NumCv")]
        public string NumCv { get; set; }

        /// <summary>
        /// Gets or sets the number autent.
        /// </summary>
        /// <value>The number autent.</value>
        [JsonProperty("NumAutent")]
        public string NumAutent { get; set; }

        /// <summary>
        /// Gets or sets the arp.
        /// </summary>
        /// <value>The arp.</value>
        [JsonProperty("Arp")]
        public string Arp { get; set; }

        /// <summary>
        /// Gets or sets the eci.
        /// </summary>
        /// <value>The eci.</value>
        [JsonProperty("eci")]
        public string Eci { get; set; }

        /// <summary>
        /// Gets or sets the lr.
        /// </summary>
        /// <value>The lr.</value>
        [JsonProperty("lr")]
        public string Lr { get; set; }

        /// <summary>
        /// Gets or sets the nsu settle.
        /// </summary>
        /// <value>The nsu settle.</value>
        [JsonProperty("NsuSettle")]
        public string NsuSettle { get; set; }
    }
}