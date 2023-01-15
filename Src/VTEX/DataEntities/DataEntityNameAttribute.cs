// ***********************************************************************
// Assembly         : VTEX
// Author           : Guilherme Branco Stracini
// Created          : 01-15-2023
//
// Last Modified By : Guilherme Branco Stracini
// Last Modified On : 01-16-2023
// ***********************************************************************
// <copyright file="DataEntityNameAttribute.cs" company="Guilherme Branco Stracini">
//     © 2020 Guilherme Branco Stracini. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
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
        /// Initializes a new instance of the <see cref="DataEntityNameAttribute" /> class.
        /// </summary>
        /// <param name="entityName">Name of the entity.</param>
        public DataEntityNameAttribute(string entityName)
        {
            EntityName = entityName;
        }

        /// <summary>
        /// Gets the name of the entity.
        /// </summary>
        /// <value>The name of the entity.</value>
        public string EntityName { get; }
    }
}
