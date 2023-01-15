// ***********************************************************************
// Assembly         : VTEX
// Author           : Guilherme Branco Stracini
// Created          : 01-16-2023
//
// Last Modified By : Guilherme Branco Stracini
// Last Modified On : 01-16-2023
// ***********************************************************************
// <copyright file="CommitFeed.cs" company="Guilherme Branco Stracini">
//     © 2020 Guilherme Branco Stracini. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
namespace VTEX.Transport.Feed
{
    using CrispyWaffle.Serialization;

    /// <summary>
    /// Class CommitFeed.
    /// </summary>
    [Serializer(SerializerFormat.Json)]
    public class CommitFeed
    {
        /// <summary>
        /// Gets or sets the handles.
        /// </summary>
        /// <value>The handles.</value>
        public string[] Handles { get; set; }
    }
}
