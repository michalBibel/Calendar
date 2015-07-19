using System.Web.Mvc;
using Calendar.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

namespace Calendar.Tests.Controllers
{
    [TestFixture]
    public class HomeControllerTest
    {
        private HomeController _controller;

        [SetUp]
        public void Setup()
        {
            _controller = new HomeController();
        }

        [Test]
        public void Index()
        {
            // Act
            var result = _controller.Index() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        [Test]
        public void About()
        {
            // Act
            var result = _controller.About() as ViewResult;

            // Assert
            Assert.AreEqual("Your application description page.", result.ViewBag.Message);
        }

        [Test]
        public void Contact()
        {
            // Act
            ViewResult result = _controller.Contact() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }
    }
}
