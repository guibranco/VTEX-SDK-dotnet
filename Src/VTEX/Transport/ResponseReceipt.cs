// ***********************************************************************
// Assembly         : VTEX
// Author           : Guilherme Branco Stracini
// Created          : 01-15-2023
//
// Last Modified By : Guilherme Branco Stracini
// Last Modified On : 01-15-2023
// ***********************************************************************
// <copyright file="ResponseReceipt.cs" company="Guilherme Branco Stracini">
//     © 2020 Guilherme Branco Stracini. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
namespace VTEX.Transport
{
    using CrispyWaffle.Serialization;
    using Newtonsoft.Json;
    using System;

    /// <summary>
    /// Class ResponseReceipt. This class cannot be inherited.
    /// </summary>
    [Serializer(SerializerFormat.Json)]
    public sealed class ResponseReceipt
    {
        /// <summary>
        /// The date
        /// </summary>
        private DateTime _date;
        /// <summary>
        /// The date set
        /// </summary>
        private bool _dateSet;

        /// <summary>
        /// Gets or sets the date internal.
        /// </summary>
        /// <value>The date internal.</value>
        [JsonProperty("date")]
        public string DateInternal
        {
            get => _dateSet
                       ? _date.ToString(@"s")
                       : null;
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    _date = DateTime.Parse(value);
                }

                _dateSet = true;
            }
        }

        /// <summary>
        /// Gets or sets the date.
        /// </summary>
        /// <value>The date.</value>
        [JsonIgnore]
        public DateTime Date
        {
            get => _date;
            set
            {
                _date = value;
                _dateSet = true;
            }
        }

        /// <summary>
        /// Gets or sets the order identifier.
        /// </summary>
        /// <value>The order identifier.</value>
        [JsonProperty("orderId")]
        public string OrderId { get; set; }

        /// <summary>
        /// Gets or sets the receipt.
        /// </summary>
        /// <value>The receipt.</value>
        [JsonProperty("receipt")]
        public string Receipt { get; set; }

    }
}
