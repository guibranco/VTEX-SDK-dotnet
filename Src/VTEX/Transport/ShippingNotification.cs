// ***********************************************************************
// Assembly         : IntegracaoService.VTEX
// Author           : Guilherme Branco Stracini
// Created          : 12-20-2016
//
// Last Modified By : Guilherme Branco Stracini
// Last Modified On : 12-20-2016
// ***********************************************************************
// <copyright file="ShippingNotification.cs" company="Guilherme Branco Stracini ME">
//     © 2016 Guilherme Branco Stracini, All Rights Reserved
// </copyright>
// <summary></summary>
// ***********************************************************************

namespace VTEX.Transport
{
    using System.ComponentModel;
    using CrispyWaffle.Extensions;
    using CrispyWaffle.Serialization;
    using Enums;
    using Newtonsoft.Json;

    /// <summary>
    /// A notificacao de envio dto.
    /// </summary>
    /// <remarks>Versão: 1.51.2928.607
    /// Autor: Guilherme Branco Stracini
    /// Data: 31/03/2014.</remarks>

    [Serializer(SerializerFormat.JSON)]
    public sealed class ShippingNotification
    {
        /// <summary>
        /// Gets or sets the type.
        /// </summary>
        /// <value>The type.</value>
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Browsable(false)]
        [JsonProperty("type")]
        public string TypeInternal
        {
            get => Type.GetInternalValue();
            set => Type = EnumExtensions.GetEnumByInternalValueAttribute<InvoiceType>(value);
        }

        /// <summary>
        /// Gets or sets the type.
        /// </summary>
        /// <value>
        /// The type.
        /// </value>
        [JsonIgnore]
        public InvoiceType Type { get; set; }

        /// <summary>
        /// Gets or sets the invoice number.
        /// </summary>
        /// <value>The invoice number.</value>

        [JsonProperty("invoiceNumber")]
        public string InvoiceNumber { get; set; }

        /// <summary>
        /// Gets or sets the invoice value.
        /// </summary>
        /// <value>The invoice value.</value>

        [JsonProperty("invoiceValue")]
        public int InvoiceValue { get; set; }

        /// <summary>
        /// Gets or sets the Key of the invoice.
        /// </summary>
        /// <value>The invoice key.</value>

        [JsonProperty("invoiceKey")]
        public string InvoiceKey { get; set; }

        /// <summary>
        /// Gets or sets URL of the invoice.
        /// </summary>
        /// <value>The invoice URL.</value>

        [JsonProperty("invoiceUrl")]
        [Localizable(false)]
        public string InvoiceUrl { get; set; }

        /// <summary>
        /// Gets or sets the courier.
        /// </summary>
        /// <value>The courier.</value>

        [JsonProperty("courier")]
        public string Courier { get; set; }

        /// <summary>
        /// Gets or sets the tracking number.
        /// </summary>
        /// <value>The tracking number.</value>

        [JsonProperty("trackingNumber")]
        public string TrackingNumber { get; set; }

        /// <summary>
        /// Gets or sets the tracking url.
        /// </summary>
        /// <value>The tracking url.</value>

        [JsonProperty("trackingUrl")]
        [Localizable(false)]
        public string TrackingUrl { get; set; }

        /// <summary>
        /// Gets or sets the issuance date.
        /// </summary>
        /// <value>The issuance date.</value>

        [JsonProperty("issuanceDate")]
        public string IssuanceDate { get; set; }

        /// <summary>
        /// Gets or sets the embedded invoice.
        /// </summary>
        /// <value>The embedded invoice.</value>
        [JsonProperty("embeddedInvoice")]
        public string EmbeddedInvoice { get; set; }

        /// <summary>
        /// Gets or sets the courier status.
        /// </summary>
        /// <value>The courier status.</value>
        [JsonProperty("courierStatus")]
        public CourierStatus CourierStatus { get; set; }

        /// <summary>
        /// Gets or sets the items.
        /// </summary>
        /// <value>The items.</value>
        [JsonProperty("items")]
        public ItemOfInvoice[] Items { get; set; }
    }
}
