using System;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using CroweConsoleApp;
using CroweConsoleApp.Interfaces;

namespace CroweSample.Tests
{
    [TestClass]
    public class Test_1
    {
        [TestMethod]
        public async Task TestMethod1()
        {
            //Arrange
            var mockWriter = new Mock<IWriter>();
            var mockRepos = new Mock<IValueRepository>();
            string mockValue = "Hello World mock";
            mockRepos.Setup(arg => arg.GetHelloText()).ReturnsAsync(mockValue);

            //Act
            ConsoleApp app = new ConsoleApp(mockWriter.Object, mockRepos.Object);
            string msgText = await app.GetValue();

            // Assert
            Assert.AreEqual(mockValue, msgText);
        }
    }
}
