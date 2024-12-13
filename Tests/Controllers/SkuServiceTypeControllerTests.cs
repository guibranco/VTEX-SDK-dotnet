using NUnit.Framework;
using VTEX.Controllers;
using VTEX.Models;

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
}