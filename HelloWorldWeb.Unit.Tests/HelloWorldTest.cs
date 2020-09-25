using HelloWorldWeb.Controllers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HelloWorldWeb.Unit.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CheckResultType_ViewResult_Ok()
        {
            // Arrange
            var controller = new HomeController();

            // Act
            var result = controller.Index();
            
            // Assert
            Assert.IsInstanceOfType(result, typeof(ViewResult));
        }

    }
}
