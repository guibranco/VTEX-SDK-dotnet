namespace VTEX.Extensions
{
    using System;
    using DataEntities;

    /// <summary>
    /// The entity extensions class.
    /// </summary>
    public static class EntityExtensions
    {
        /// <summary>
        /// Gets the name of the data entity.
        /// </summary>
        /// <param name="type">The type.</param>
        /// <returns></returns>
        public static string GetDataEntityName(this Type type)
        {
            return type.GetCustomAttributes(typeof(DataEntityNameAttribute), true)
                       is DataEntityNameAttribute[] attributes && attributes.Length == 1
                ? attributes[0].EntityName
                : type.Name.ToUpper().Substring(0, 2);
        }
    }
}
