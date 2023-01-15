namespace VTEX.Transport
{
    using CrispyWaffle.Serialization;

    /// <summary>
    /// The specification field class.
    /// </summary>
    [Serializer(SerializerFormat.Json)]
    public sealed class SpecificationField
    {
        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the category identifier.
        /// </summary>
        /// <value>
        /// The category identifier.
        /// </value>
        public int? CategoryId { get; set; }

        /// <summary>
        /// Gets or sets the field identifier.
        /// </summary>
        /// <value>
        /// The field identifier.
        /// </value>
        public int FieldId { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this instance is active.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this instance is active; otherwise, <c>false</c>.
        /// </value>
        public bool IsActive { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this instance is required.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this instance is required; otherwise, <c>false</c>.
        /// </value>
        public bool IsRequired { get; set; }

        /// <summary>
        /// Gets or sets the field type identifier.
        /// </summary>
        /// <value>
        /// The field type identifier.
        /// </value>
        public int FieldTypeId { get; set; }

        /// <summary>
        /// Gets or sets the name of the field type.
        /// </summary>
        /// <value>
        /// The name of the field type.
        /// </value>
        public string FieldTypeName { get; set; }

        /// <summary>
        /// Gets or sets the field value identifier.
        /// </summary>
        /// <value>
        /// The field value identifier.
        /// </value>
        public string FieldValueId { get; set; }

        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        /// <value>
        /// The description.
        /// </value>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this instance is stock product details.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this instance is stock product details; otherwise, <c>false</c>.
        /// </value>
        public bool IsStockProductDetails { get; set; }

        /// <summary>
        /// Gets or sets the position.
        /// </summary>
        /// <value>
        /// The position.
        /// </value>
        public int Position { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this instance is wizard.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this instance is wizard; otherwise, <c>false</c>.
        /// </value>
        public bool IsWizard { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this instance is top menu link active.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this instance is top menu link active; otherwise, <c>false</c>.
        /// </value>
        public bool IsTopMenuLinkActive { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this instance is side menu link active.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this instance is side menu link active; otherwise, <c>false</c>.
        /// </value>
        public bool IsSideMenuLinkActive { get; set; }

        /// <summary>
        /// Gets or sets the default value.
        /// </summary>
        /// <value>
        /// The default value.
        /// </value>
        public string DefaultValue { get; set; }

        /// <summary>
        /// Gets or sets the field group identifier.
        /// </summary>
        /// <value>
        /// The field group identifier.
        /// </value>
        public int FieldGroupId { get; set; }

        /// <summary>
        /// Gets or sets the name of the field group.
        /// </summary>
        /// <value>
        /// The name of the field group.
        /// </value>
        public string FieldGroupName { get; set; }

    }
}
