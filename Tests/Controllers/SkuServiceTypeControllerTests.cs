using NUnit.Framework;
using VTEX.Controllers;
using VTEX.Models;
using Microsoft.AspNetCore.Mvc;

namespace VTEX.Tests.Controllers
{
    public class SkuServiceTypeControllerTests
    {
        private SkuServiceTypeController _controller;

        [SetUp]
        public void Setup()
        {
            _controller = new SkuServiceTypeController();
        }
    }

        [Test]
        public void CreateSkuServiceType_ReturnsOk()
        {
            var result = _controller.CreateSkuServiceType(new SkuServiceTypeDto());
            Assert.IsInstanceOf<OkResult>(result);
        }

        [Test]
        public void UpdateSkuServiceType_ReturnsOk()
        {
            var result = _controller.UpdateSkuServiceType(1, new SkuServiceTypeDto());
}
