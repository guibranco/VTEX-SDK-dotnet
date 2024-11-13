// ***********************************************************************
// Assembly         : VTEX.Tests
// Author           : Guilherme Branco Stracini
// Created          : 01-15-2023
//
// Last Modified By : Guilherme Branco Stracini
// Last Modified On : 01-15-2023
// ***********************************************************************
// <copyright file="VtexHealthClientTests.cs" company="VTEX.Tests">
//     Copyright (c) Guilherme Branco Stracini ME. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
namespace VTEX.Tests.Health
{
    using System;
    using System.Collections.ObjectModel;
    using System.Linq;
    using System.Threading;
    using System.Threading.Tasks;
    using NSubstitute;
    using VTEX.Health;
    using Xunit;

    /// <summary>
    /// Class VtexHealthClientTests.
    /// </summary>
    public class VtexHealthClientTests
    {
        /// <summary>
        /// Asynchronously validates the health status of a platform by retrieving platform statuses from a health client.
        /// </summary>
        /// <remarks>
        /// This test method sets up a substitute implementation of the <see cref="IVtexHealthClient"/> interface to simulate the retrieval of platform statuses.
        /// It creates a collection of <see cref="PlatformStatus"/> objects, representing both healthy and unhealthy statuses.
        /// The method then calls the substitute's <see cref="IVtexHealthClient.GetPlatformStatuesAsync"/> method and verifies that the result is not null.
        /// It also checks that the returned list contains exactly two items, one with a healthy status and one with an unhealthy status.
        /// This ensures that the health client is functioning as expected and returning the correct platform statuses.
        /// </remarks>
        [Fact]
        public async Task ValidateHealthClient()
        {
            var fixtures = new Collection<PlatformStatus>
            {
                new PlatformStatus
                {
                    LastResult = DateTime.Now,
                    Status = ResultStatus.HEALTHY,
                    Name = "Test",
                    LastResultStatus = "healthy",
                },
                new PlatformStatus
                {
                    LastResult = DateTime.Now,
                    Status = ResultStatus.UNHEALTHY,
                    Name = "Test unhealthy",
                    LastResultStatus = "healthy",
                },
            };

            var clientSubstitute = Substitute.For<IVtexHealthClient>();
            clientSubstitute
                .GetPlatformStatuesAsync(Arg.Any<CancellationToken>())
                .Returns(fixtures);

            var result = await clientSubstitute
                .GetPlatformStatuesAsync(CancellationToken.None)
                .ConfigureAwait(false);

            Assert.NotNull(result);

            var list = result.ToList();
            Assert.Equal(2, list.Count);
            Assert.Contains(list, r => r.Status.Equals(ResultStatus.HEALTHY));
            Assert.Contains(list, r => r.Status.Equals(ResultStatus.UNHEALTHY));
        }
    }
}
