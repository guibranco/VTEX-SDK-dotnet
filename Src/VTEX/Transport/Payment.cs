// ***********************************************************************
// Assembly         : IntegracaoService.VTEX
// Author           : Guilherme Branco Stracini
// Created          : 20/12/2016
//
// Last Modified By : Guilherme Branco Stracini
// Last Modified On : 20/12/2016
// ***********************************************************************
// <copyright file="Payment.cs" company="Guilherme Branco Stracini ME">
//     © 2016 Guilherme Branco Stracini, All Rights Reserved
// </copyright>
// <summary></summary>
// ***********************************************************************

namespace VTEX.Transport
{
    using System;
    using System.ComponentModel;
    using CrispyWaffle.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A payment.
    /// </summary>
    /// <remarks>Versão: 1.51.2931.607
    /// Autor: Guilherme Branco Stracini
    /// Data: 31/03/2014.</remarks>

    public sealed class Payment
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>The identifier.</value>

        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the payment system.
        /// </summary>
        /// <value>The payment system.</value>

        [JsonProperty("paymentSystem")]
        public int PaymentSystem { get; set; }

        /// <summary>
        /// Gets or sets the name of the payment system.
        /// </summary>
        /// <value>The name of the payment system.</value>

        [JsonProperty("paymentSystemName")]
        public string PaymentSystemName { get; set; }

        /// <summary>
        /// Gets or sets the value.
        /// </summary>
        /// <value>The value.</value>

        [JsonProperty("value")]
        public int Value { get; set; }

        /// <summary>
        /// Gets or sets the installments.
        /// </summary>
        /// <value>The installments.</value>

        [JsonProperty("installments")]
        public int Installments { get; set; }

        /// <summary>
        /// Gets or sets the reference value.
        /// </summary>
        /// <value>The reference value.</value>

        [JsonProperty("referenceValue")]
        public int ReferenceValue { get; set; }

        /// <summary>
        /// Gets or sets the card holder.
        /// </summary>
        /// <value>The card holder.</value>

        [JsonProperty("cardHolder")]
        public string CardHolder { get; set; }

        /// <summary>
        /// Gets or sets the card number.
        /// </summary>
        /// <value>The card number.</value>

        [JsonProperty("cardNumber")]
        public string CardNumber { get; set; }

        /// <summary>
        /// Gets or sets the first digits.
        /// </summary>
        /// <value>The first digits.</value>

        [JsonProperty("firstDigits")]
        public string FirstDigits { get; set; }

        /// <summary>
        /// Gets or sets the last digits.
        /// </summary>
        /// <value>The last digits.</value>

        [JsonProperty("lastDigits")]
        public string LastDigits { get; set; }

        /// <summary>
        /// Gets or sets the cvv 2.
        /// </summary>
        /// <value>The cvv 2.</value>

        [JsonProperty("cvv2")]
        public string Cvv2 { get; set; }

        /// <summary>
        /// Gets or sets the expire month.
        /// </summary>
        /// <value>The expire month.</value>

        [JsonProperty("expireMonth")]
        public string ExpireMonth { get; set; }

        /// <summary>
        /// Gets or sets the expire year.
        /// </summary>
        /// <value>The expire year.</value>

        [JsonProperty("expireYear")]
        public string ExpireYear { get; set; }

        /// <summary>
        /// Gets or sets URL of the document.
        /// </summary>
        /// <value>The URL.</value>

        [JsonProperty("url")]
        public string Url { get; set; }

        /// <summary>
        /// Gets or sets the gift card identifier.
        /// </summary>
        /// <value>The gift card identifier.</value>
        [JsonProperty("giftCardId")]
        public string GiftCardId { get; set; }

        /// <summary>
        /// Gets or sets the name of the gift card.
        /// </summary>
        /// <value>
        /// The name of the gift card.
        /// </value>
        [JsonProperty("giftCardName")]
        public string GiftCardName { get; set; }

        /// <summary>
        /// Gets or sets the gift card caption.
        /// </summary>
        /// <value>The gift card caption.</value>
        [JsonProperty("giftCardCaption")]
        public string GiftCardCaption { get; set; }

        /// <summary>
        /// Gets or sets the redemption code.
        /// </summary>
        /// <value>The redemption code.</value>

        [JsonProperty("redemptionCode")]
        public NotNullObserver RedemptionCode { get; set; }

        /// <summary>
        /// Gets or sets the group.
        /// </summary>
        /// <value>The group.</value>

        [JsonProperty("group")]
        [Localizable(false)]
        public string Group { get; set; }

        /// <summary>
        /// Gets or sets the tid.
        /// </summary>
        /// <value>The tid.</value>

        [JsonProperty("tid")]
        public string Tid { get; set; }

        /// <summary>
        /// Gets or sets the due date.
        /// </summary>
        /// <value>The due date.</value>
        [JsonProperty("dueDate")]
        public DateTime? DueDate { get; set; }

        /// <summary>
        /// Gets or sets the connector responses.
        /// </summary>
        /// <value>The connector responses.</value>

        [JsonProperty("connectorResponses")]
        public ConnectorResponses ConnectorResponses { get; set; }
    }
}