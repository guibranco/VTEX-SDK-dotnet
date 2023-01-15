// ***********************************************************************
// Assembly         : VTEX
// Author           : Guilherme Branco Stracini
// Created          : 01-15-2023
//
// Last Modified By : Guilherme Branco Stracini
// Last Modified On : 01-16-2023
// ***********************************************************************
// <copyright file="Payment.cs" company="Guilherme Branco Stracini">
//     © 2020 Guilherme Branco Stracini. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
namespace VTEX.Transport
{
    using CrispyWaffle.Serialization;
    using Newtonsoft.Json;
    using System;
    using System.ComponentModel;
    using VTEX.Transport.OrderAggregate;

    /// <summary>
    /// Class Payment. This class cannot be inherited.
    /// </summary>
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
        /// <value>The name of the gift card.</value>
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

        /// <summary>
        /// Gets or sets the gift card provider.
        /// </summary>
        /// <value>The gift card provider.</value>
        [JsonProperty("giftCardProvider")]
        public NotNullObserver GiftCardProvider { get; set; }


        /// <summary>
        /// Gets or sets the gift card as discount.
        /// </summary>
        /// <value>The gift card as discount.</value>
        [JsonProperty("giftCardAsDiscount")]
        public NotNullObserver GiftCardAsDiscount { get; set; }

        /// <summary>
        /// Gets or sets the koin URL.
        /// </summary>
        /// <value>The koin URL.</value>
        [JsonProperty("koinUrl")]
        public string KoinUrl { get; set; }

        /// <summary>
        /// Gets or sets the account identifier.
        /// </summary>
        /// <value>The account identifier.</value>
        [JsonProperty("accountId")]
        public string AccountId { get; set; }

        /// <summary>
        /// Gets or sets the parent account identifier.
        /// </summary>
        /// <value>The parent account identifier.</value>
        [JsonProperty("parentAccountId")]
        public string ParentAccountId { get; set; }

        /// <summary>
        /// Gets or sets the bank issued invoice identification number.
        /// </summary>
        /// <value>The bank issued invoice identification number.</value>
        [JsonProperty("bankIssuedInvoiceIdentificationNumber")]
        public string BankIssuedInvoiceIdentificationNumber { get; set; }

        /// <summary>
        /// Gets or sets the bank issued invoice identification number formatted.
        /// </summary>
        /// <value>The bank issued invoice identification number formatted.</value>
        [JsonProperty("bankIssuedInvoiceIdentificationNumberFormatted")]
        public string BankIssuedInvoiceIdentificationNumberFormatted { get; set; }

        /// <summary>
        /// Gets or sets the bank issued invoice bar code number.
        /// </summary>
        /// <value>The bank issued invoice bar code number.</value>
        [JsonProperty("bankIssuedInvoiceBarCodeNumber")]
        public string BankIssuedInvoiceBarCodeNumber { get; set; }

        /// <summary>
        /// Gets or sets the type of the bank issued invoice bar code.
        /// </summary>
        /// <value>The type of the bank issued invoice bar code.</value>
        [JsonProperty("bankIssuedInvoiceBarCodeType")]
        public string BankIssuedInvoiceBarCodeType { get; set; }

        /// <summary>
        /// Gets or sets the billing address.
        /// </summary>
        /// <value>The billing address.</value>
        [JsonProperty("billingAddress")]
        public Address BillingAddress { get; set; }
    }
}