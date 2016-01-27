using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Web.Http;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HelloWorldWebAPI;
using HelloWorldWebAPI.Controllers;

namespace HelloWorldWebAPI.Tests
{
    [TestClass]
    public class HelloWorldUnitTest
    {
        [TestMethod]
        public void GetReturnsProduct()
        {
            // Arrange
            var controller = new HelloWorldController();
            controller.Request = new HttpRequestMessage();
            controller.Configuration = new HttpConfiguration();

            // Act
            var response = controller.Get();

            // Assert
         
           // Assert.IsTrue(true);
            Assert.AreEqual("Hello ", response);
        }
    }
}
