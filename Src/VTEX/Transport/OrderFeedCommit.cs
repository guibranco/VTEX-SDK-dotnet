// ***********************************************************************
// Assembly         : VTEX
// Author           : Guilherme Branco Stracini
// Created          : 01-15-2023
//
// Last Modified By : Guilherme Branco Stracini
// Last Modified On : 01-16-2023
// ***********************************************************************
// <copyright file="OrderFeedCommit.cs" company="Guilherme Branco Stracini">
//     © 2020 Guilherme Branco Stracini. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
namespace VTEX.Transport
{
    using CrispyWaffle.Serialization;

    /// <summary>
    /// The order feed commit class.
    /// </summary>
    [Serializer(SerializerFormat.Json)]
    public class OrderFeedCommit
    {
        /// <summary>
        /// Gets or sets the commit token.
        /// </summary>
        /// <value>The commit token.</value>
        public string CommitToken { get; set; }
    }
}
