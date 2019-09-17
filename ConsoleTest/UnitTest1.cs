using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;
using Moq;
using CroweConsoleApp;
using CroweConsoleApp.Interfaces;

namespace ConsoleTest
{
    [TestClass]
    public class UnitTest1
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
