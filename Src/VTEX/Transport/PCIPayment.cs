// ***********************************************************************
// Assembly         : VTEX
// Author           : Guilherme Branco Stracini
// Created          : 01-15-2023
//
// Last Modified By : Guilherme Branco Stracini
// Last Modified On : 01-15-2023
// ***********************************************************************
// <copyright file="PCIPayment.cs" company="Guilherme Branco Stracini">
//     © 2020 Guilherme Branco Stracini. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
namespace VTEX.Transport
{
    using CrispyWaffle.Serialization;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Linq;

    /// <summary>
    /// Class PCI payment. This class cannot be inherited.
    /// </summary>
    [Serializer(SerializerFormat.Json)]
    public sealed class PciPayment
    {
        #region Public methods

        /// <summary>
        /// Gets the field by the name.
        /// </summary>
        /// <param name="fieldName">Name of the field.</param>
        /// <returns>PciPaymentField.</returns>
        public PciPaymentField GetFieldByName([Localizable(false)] string fieldName)
        {
            return Fields.SingleOrDefault(f => f.Name.Equals(fieldName, StringComparison.InvariantCultureIgnoreCase));
        }

        #endregion

        #region Public properties

        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>The identifier.</value>
        public string Id { get; set; }
        /// <summary>
        /// Gets or sets the payment system.
        /// </summary>
        /// <value>The payment system.</value>
        public int PaymentSystem { get; set; }
        /// <summary>
        /// Gets or sets the name of the payment system.
        /// </summary>
        /// <value>The name of the payment system.</value>
        public string PaymentSystemName { get; set; }
        /// <summary>
        /// Gets or sets the name of the merchant.
        /// </summary>
        /// <value>The name of the merchant.</value>
        public string MerchantName { get; set; }
        /// <summary>
        /// Gets or sets the group.
        /// </summary>
        /// <value>The group.</value>
        public string Group { get; set; }
        /// <summary>
        /// Gets or sets the is custom.
        /// </summary>
        /// <value>The is custom.</value>
        public bool IsCustom { get; set; }
        /// <summary>
        /// Gets or sets the allow installments.
        /// </summary>
        /// <value>The allow installments.</value>
        public bool AllowInstallments { get; set; }
        /// <summary>
        /// Gets or sets a value indicating whether [requires authentication].
        /// </summary>
        /// <value><c>true</c> if [requires authentication]; otherwise, <c>false</c>.</value>
        public bool RequiresAuthentication { get; set; }
        /// <summary>
        /// Gets or sets a value indicating whether [allow issuer].
        /// </summary>
        /// <value><c>true</c> if [allow issuer]; otherwise, <c>false</c>.</value>
        public bool AllowIssuer { get; set; }
        /// <summary>
        /// Gets or sets a value indicating whether [allow notification].
        /// </summary>
        /// <value><c>true</c> if [allow notification]; otherwise, <c>false</c>.</value>
        public bool AllowNotification { get; set; }
        /// <summary>
        /// Gets or sets the is available.
        /// </summary>
        /// <value>The is available.</value>
        public bool IsAvailable { get; set; }
        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        /// <value>The description.</value>
        public string Description { get; set; }
        /// <summary>
        /// Gets or sets the authorization date.
        /// </summary>
        /// <value>The authorization date.</value>
        public DateTime? AuthorizationDate { get; set; }
        /// <summary>
        /// Gets or sets the self.
        /// </summary>
        /// <value>The self.</value>
        public Self Self { get; set; }
        /// <summary>
        /// Gets or sets the tid.
        /// </summary>
        /// <value>The tid.</value>
        public string Tid { get; set; }
        /// <summary>
        /// Gets or sets the nsu.
        /// </summary>
        /// <value>The nsu.</value>
        public string Nsu { get; set; }
        /// <summary>
        /// Gets or sets the return code.
        /// </summary>
        /// <value>The return code.</value>
        public string ReturnCode { get; set; }
        /// <summary>
        /// Gets or sets the return message.
        /// </summary>
        /// <value>The return message.</value>
        public string ReturnMessage { get; set; }
        /// <summary>
        /// Gets or sets the status.
        /// </summary>
        /// <value>The status.</value>
        public string Status { get; set; }
        /// <summary>
        /// Gets or sets the connector.
        /// </summary>
        /// <value>The connector.</value>
        public string Connector { get; set; }
        /// <summary>
        /// Gets or sets the connector responses.
        /// </summary>
        /// <value>The connector responses.</value>
        public ConnectorResponses ConnectorResponses { get; set; }
        /// <summary>
        /// Gets or sets the connector response.
        /// </summary>
        /// <value>The connector response.</value>
        public ConnectorResponse ConnectorResponse { get; set; }
        /// <summary>
        /// Gets or sets the show connector responses.
        /// </summary>
        /// <value>The show connector responses.</value>
        public bool ShowConnectorResponses { get; set; }
        /// <summary>
        /// Gets or sets the value.
        /// </summary>
        /// <value>The value.</value>
        public int Value { get; set; }
        /// <summary>
        /// Gets or sets the installments interest rate.
        /// </summary>
        /// <value>The installments interest rate.</value>
        public int InstallmentsInterestRate { get; set; }
        /// <summary>
        /// Gets or sets the installments value.
        /// </summary>
        /// <value>The installments value.</value>
        public int InstallmentsValue { get; set; }
        /// <summary>
        /// Gets or sets the reference value.
        /// </summary>
        /// <value>The reference value.</value>
        public int ReferenceValue { get; set; }
        /// <summary>
        /// Gets or sets the installments.
        /// </summary>
        /// <value>The installments.</value>
        public int Installments { get; set; }
        /// <summary>
        /// Gets or sets the currency code.
        /// </summary>
        /// <value>The currency code.</value>
        public string CurrencyCode { get; set; }
        /// <summary>
        /// Gets or sets the provider.
        /// </summary>
        /// <value>The provider.</value>
        public NotNullObserver Provider { get; set; }
        /// <summary>
        /// Gets or sets the fields.
        /// </summary>
        /// <value>The fields.</value>
        public IReadOnlyCollection<PciPaymentField> Fields { get; set; }

        /// <summary>
        /// Gets or sets the sheets.
        /// </summary>
        /// <value>The sheets.</value>
        public List<Sheet> Sheets { get; set; }

        /// <summary>
        /// Gets or sets the original payment identifier.
        /// </summary>
        /// <value>The original payment identifier.</value>
        public NotNullObserver OriginalPaymentId { get; set; }

        #endregion
    }
}
