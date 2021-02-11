using System.Reflection;
using API;
using API.Controllers;
using Microsoft.AspNetCore.Hosting;
using Moq;
using Xunit;

namespace Tests
{
    public class HomeControllerTests
    {
        [Fact]
        public void Get_ReturnsAppDetails()
        {
            // Arrange.
            var appDetails = new AppDetails(Assembly.GetAssembly(typeof(HomeControllerTests)), new Mock<IWebHostEnvironment>().Object);
            var homeController = new HomeController(appDetails);

            // Act.
            var result = homeController.Get();

            // Assert.
            Assert.NotNull(result);
        }
    }
}
