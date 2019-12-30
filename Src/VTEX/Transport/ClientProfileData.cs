// file:	DTOSC\ClientProfileData.cs
//
// summary:	Implements the client profile data class

namespace VTEX.Transport
{
    using CrispyWaffle.Extensions;
    using CrispyWaffle.Serialization;
    using Enums;
    using Newtonsoft.Json;

    /// <summary>
    ///     A client profile data.
    /// </summary>
    ///
    /// <remarks>
    ///     Versão: 1.51.2931.607
    ///     Autor: Guilherme Branco Stracini
    ///     Data: 31/03/2014.
    /// </remarks>

    public sealed class ClientProfileData
    {
        /// <summary>
        ///     Gets or sets the identifier.
        /// </summary>
        ///
        /// <value>
        ///     The identifier.
        /// </value>

        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        ///     Gets or sets the email.
        /// </summary>
        ///
        /// <value>
        ///     The email.
        /// </value>

        [JsonProperty("email")]
        public string Email { get; set; }

        /// <summary>
        ///     Gets or sets the person's first name.
        /// </summary>
        ///
        /// <value>
        ///     The name of the first.
        /// </value>

        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        /// <summary>
        ///     Gets or sets the person's last name.
        /// </summary>
        ///
        /// <value>
        ///     The name of the last.
        /// </value>

        [JsonProperty("lastName")]
        public string LastName { get; set; }

        /// <summary>
        /// Gets or sets the document type internal.
        /// </summary>
        /// <value>
        /// The document type internal.
        /// </value>
        [JsonProperty("documentType")]
        public string DocumentTypeInternal
        {
            get => DocumentType.GetHumanReadableValue();
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    return;
                DocumentType = EnumExtensions.GetEnumByInternalValueAttribute<DocumentType>(value);
            }
        }

        /// <summary>
        /// Gets or sets the type of the document.
        /// </summary>
        /// <value>
        /// The type of the document.
        /// </value>
        [JsonIgnore]
        public DocumentType DocumentType { get; set; }

        /// <summary>
        ///     Gets or sets the document.
        /// </summary>
        ///
        /// <value>
        ///     The document.
        /// </value>

        [JsonProperty("document")]
        public string Document { get; set; }

        /// <summary>
        ///     Gets or sets the phone.
        /// </summary>
        ///
        /// <value>
        ///     The phone.
        /// </value>

        [JsonProperty("phone")]
        public string Phone { get; set; }

        /// <summary>
        ///     Gets or sets the name of the corporate.
        /// </summary>
        ///
        /// <value>
        ///     The name of the corporate.
        /// </value>

        [JsonProperty("corporateName")]
        public string CorporateName { get; set; }

        /// <summary>
        ///     Gets or sets the name of the trade.
        /// </summary>
        ///
        /// <value>
        ///     The name of the trade.
        /// </value>

        [JsonProperty("tradeName")]
        public string TradeName { get; set; }

        /// <summary>
        ///     Gets or sets the corporate document.
        /// </summary>
        ///
        /// <value>
        ///     The corporate document.
        /// </value>

        [JsonProperty("corporateDocument")]
        public string CorporateDocument { get; set; }

        /// <summary>
        ///     Gets or sets the state inscription.
        /// </summary>
        ///
        /// <value>
        ///     The state inscription.
        /// </value>

        [JsonProperty("stateInscription")]
        public string StateInscription { get; set; }

        /// <summary>
        ///     Gets or sets the postal code.
        /// </summary>
        ///
        /// <value>
        ///     The postal code.
        /// </value>

        [JsonProperty("postalCode")]
        public string PostalCode { get; set; }

        /// <summary>
        ///     Gets or sets the corporate phone.
        /// </summary>
        ///
        /// <value>
        ///     The corporate phone.
        /// </value>

        [JsonProperty("corporatePhone")]
        public string CorporatePhone { get; set; }

        /// <summary>
        ///     Gets or sets a value indicating whether this object is corporate.
        /// </summary>
        ///
        /// <value>
        ///     true if this object is corporate, false if not.
        /// </value>

        [JsonProperty("isCorporate")]
        public bool IsCorporate { get; set; }

        /// <summary>
        ///     Gets or sets the identifier of the user profile.
        /// </summary>
        ///
        /// <value>
        ///     The identifier of the user profile.
        /// </value>

        [JsonProperty("userProfileId")]
        public string UserProfileId { get; set; }

        /// <summary>
        /// Gets or sets the customer class.
        /// </summary>
        /// <value>
        /// The customer class.
        /// </value>
        [JsonProperty("customerClass")]
        public NotNullObserver CustomerClass { get; set; }
    }
}