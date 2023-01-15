// ***********************************************************************
// Assembly         : VTEX
// Author           : Guilherme Branco Stracini
// Created          : 01-15-2023
//
// Last Modified By : Guilherme Branco Stracini
// Last Modified On : 01-16-2023
// ***********************************************************************
// <copyright file="BridgeItem.cs" company="Guilherme Branco Stracini">
//     © 2020 Guilherme Branco Stracini. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
namespace VTEX.Transport
{
    using CrispyWaffle.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;

    /// <summary>
    /// Class BridgeItem. This class cannot be inherited.
    /// </summary>

    [Serializer(SerializerFormat.Json)]
    public sealed class BridgeItem
    {
        /// <summary>
        /// The actions
        /// </summary>
        private BridgeAction[] _actions;

        /// <summary>
        /// Gets or sets the actions.
        /// </summary>
        /// <value>The actions.</value>
        [JsonIgnore]
        public BridgeAction[] Actions
        {
            get => _actions;
            set => _actions = value;
        }

        /// <summary>
        /// Sets the actions internal.
        /// </summary>
        /// <value>The actions internal.</value>
        [Browsable(false)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        [JsonProperty("Action")]
        public string ActionsInternal
        {
            get => JsonConvert.SerializeObject(_actions);
            set
            {
                var json = JToken.Parse(value).ToString();
                _actions = SerializerFactory.GetSerializer<List<BridgeAction>>()
                                            .Deserialize(json)
                                            .ToArray();
            }
        }

        /// <summary>
        /// Gets or sets the name of the account.
        /// </summary>
        /// <value>The name of the account.</value>
        [JsonProperty("An")]
        public string AccountName { get; set; }

        /// <summary>
        /// Gets or sets the last retry date.
        /// </summary>
        /// <value>The last retry date.</value>
        [JsonProperty("LastRetryDate")]
        public DateTime LastRetryDate { get; set; }

        /// <summary>
        /// Gets or sets the message.
        /// </summary>
        /// <value>The message.</value>
        [JsonProperty("Message")]
        public string Message { get; set; }

        /// <summary>
        /// Gets or sets the origin.
        /// </summary>
        /// <value>The origin.</value>
        [JsonProperty("Origin")]
        public string Origin { get; set; }

        /// <summary>
        /// Gets or sets the status.
        /// </summary>
        /// <value>The status.</value>
        [JsonProperty("Status")]
        public string Status { get; set; }

        /// <summary>
        /// Gets or sets the type.
        /// </summary>
        /// <value>The type.</value>
        [JsonProperty("Type")]
        public string Type { get; set; }

        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>The identifier.</value>
        [JsonProperty("id")]
        public string Id { get; set; }
    }
}
