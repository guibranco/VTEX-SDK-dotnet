// ***********************************************************************
// Assembly         : VTEX
// Author           : Guilherme Branco Stracini
// Created          : 01-15-2023
//
// Last Modified By : Guilherme Branco Stracini
// Last Modified On : 01-16-2023
// ***********************************************************************
// <copyright file="OpenTextField.cs" company="Guilherme Branco Stracini">
//     © 2020 Guilherme Branco Stracini. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
namespace VTEX.Transport
{
    using Newtonsoft.Json;

    /// <summary>
    /// Class OpenTextField. This class cannot be inherited.
    /// </summary>
    public sealed class OpenTextField
    {
        /// <summary>
        /// The value
        /// </summary>
        private string _value;

        /// <summary>
        /// Gets or sets the value.
        /// </summary>
        /// <value>The value.</value>
        [JsonProperty("value")]
        public string Value
        {
            get => _value;
            set => _value = value;
        }

        /// <summary>
        /// Gets the dynamic.
        /// </summary>
        /// <value>The dynamic.</value>
        [JsonIgnore]
        public dynamic Dynamic => JsonConvert.DeserializeObject(_value);
    }
}
