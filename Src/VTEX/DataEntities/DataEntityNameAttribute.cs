namespace VTEX.DataEntities
{
    using System;

    /// <summary>
    /// The data entity name attribute class.
    /// </summary>
    /// <seealso cref="Attribute" />
    [AttributeUsage(AttributeTargets.Class)]
    public sealed class DataEntityNameAttribute : Attribute
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DataEntityNameAttribute"/> class.
        /// </summary>
        /// <param name="entityName">Name of the entity.</param>
        public DataEntityNameAttribute(string entityName)
        {
            EntityName = entityName;
        }

        /// <summary>
        /// Gets the name of the entity.
        /// </summary>
        /// <value>
        /// The name of the entity.
        /// </value>
        public string EntityName { get; }
    }
}
