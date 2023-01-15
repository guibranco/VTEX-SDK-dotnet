// ***********************************************************************
// Assembly         : VTEX.Health
// Author           : Guilherme Branco Stracini
// Created          : 01-15-2023
//
// Last Modified By : Guilherme Branco Stracini
// Last Modified On : 01-15-2023
// ***********************************************************************
// <copyright file="IVtexHealthClient.cs" company="Guilherme Branco Stracini">
//     © 2020 Guilherme Branco Stracini. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
namespace VTEX.Health
{
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Interface IVtexHealthClient
    /// </summary>
    public interface IVtexHealthClient
    {
        /// <summary>
        /// Gets the platform statues asynchronous.
        /// </summary>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>Task&lt;IEnumerable&lt;PlatformStatus&gt;&gt;.</returns>
        Task<IEnumerable<PlatformStatus>> GetPlatformStatuesAsync(CancellationToken cancellationToken);
    }
}
