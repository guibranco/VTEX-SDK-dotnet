namespace VTEX.DataEntities
{
    using System;
    using CrispyWaffle.Serialization;
    using Newtonsoft.Json;
    using ValueObjects;

    /// <summary>
    /// The client data entity class.
    /// </summary>
    /// <seealso cref="IDataEntity" />
    [DataEntityName("CL")]
    [Serializer(SerializerFormat.Json, false)]
    public class Client : IDataEntity
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the user identifier.
        /// </summary>
        /// <value>
        /// The user identifier.
        /// </value>
        [JsonProperty("userId")]
        public Guid UserId { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="Client"/> is approved.
        /// </summary>
        /// <value>
        ///   <c>true</c> if approved; otherwise, <c>false</c>.
        /// </value>
        [JsonProperty("approved")]
        public bool Approved { get; set; }

        /// <summary>
        /// Gets or sets the document.
        /// </summary>
        /// <value>
        /// The document.
        /// </value>
        [JsonProperty("document")]
        public string Document { get; set; }

        /// <summary>
        /// Gets or sets the type of the document.
        /// </summary>
        /// <value>
        /// The type of the document.
        /// </value>
        [JsonProperty("documentType")]
        public string DocumentType { get; set; }

        /// <summary>
        /// Gets or sets the email.
        /// </summary>
        /// <value>
        /// The email.
        /// </value>
        [JsonProperty("email")]
        public string Email { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this instance is corporate.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this instance is corporate; otherwise, <c>false</c>.
        /// </value>
        [JsonProperty("isCorporate")]
        public bool IsCorporate { get; set; }

        /// <summary>
        /// Gets or sets the home phone.
        /// </summary>
        /// <value>
        /// The home phone.
        /// </value>
        [JsonProperty("homePhone")]
        public string HomePhone { get; set; }

        /// <summary>
        /// Gets or sets the first name.
        /// </summary>
        /// <value>
        /// The first name.
        /// </value>
        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        /// <summary>
        /// Gets or sets the last name.
        /// </summary>
        /// <value>
        /// The last name.
        /// </value>
        [JsonProperty("lastName")]
        public string LastName { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this instance is newsletter opt in.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this instance is newsletter opt in; otherwise, <c>false</c>.
        /// </value>
        [JsonProperty("isNewsletterOptIn")]
        public bool IsNewsletterOptIn { get; set; }

        /// <summary>
        /// Gets or sets the birth date.
        /// </summary>
        /// <value>
        /// The birth date.
        /// </value>
        [JsonProperty("birthDate")]
        public DateTime? BirthDate { get; set; }

        /// <summary>
        /// Gets or sets the cart tag.
        /// </summary>
        /// <value>
        /// The cart tag.
        /// </value>
        [JsonProperty("carttag")]
        public Tag CartTag { get; set; }

        /// <summary>
        /// Gets or sets the checkout tag.
        /// </summary>
        /// <value>
        /// The checkout tag.
        /// </value>
        [JsonProperty("checkouttag")]
        public Tag CheckoutTag { get; set; }

        /// <summary>
        /// Gets or sets the corporate document.
        /// </summary>
        /// <value>
        /// The corporate document.
        /// </value>
        [JsonProperty("corporateDocument")]
        public string CorporateDocument { get; set; }

        /// <summary>
        /// Gets or sets the name of the corporate.
        /// </summary>
        /// <value>
        /// The name of the corporate.
        /// </value>
        [JsonProperty("corporateName")]
        public string CorporateName { get; set; }

        /// <summary>
        /// Gets or sets the gender.
        /// </summary>
        /// <value>
        /// The gender.
        /// </value>
        [JsonProperty("gender")]
        public string Gender { get; set; }

        /// <summary>
        /// Gets or sets the is free state registration.
        /// </summary>
        /// <value>
        /// The is free state registration.
        /// </value>
        [JsonProperty("isFreeStateRegistration")]
        public bool IsFreeStateRegistration { get; set; }

    }
}
