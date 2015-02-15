using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StoreApplication.Controllers;
using System.Web.Mvc;

namespace StoreApplication.Tests
{
    [TestClass]
    public class ProductControllerTest
    {
        [TestMethod]
        public void TestDetailsView()
        {
            var controller = new ProductController();
            var result = controller.Details(2) as ViewResult;
            Assert.AreEqual("Details", result.ViewName);
        }

        [TestMethod]
        public void TestIndexView()
        {
            var controller = new ProductController();
            var result = controller.Index() as ViewResult;
            Assert.AreEqual("Index", result.ViewName);
        }
    }
}
