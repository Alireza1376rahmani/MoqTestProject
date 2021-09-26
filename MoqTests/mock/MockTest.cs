
using Xunit;
using ConsoleApp;
using Moq;
using System;

namespace MoqTests.mock
{
    public class MockTest
    {
        [Fact]
        public void SendHelloToAhvazShouldSendHelloMessageToAhvaz()
        {
            #region Arrange
            var sut = new Village("tehran", "Iran");
            var MockAnimalTrainer = new MockAnimalTrainer();
            sut.getAnimalTrainer(MockAnimalTrainer);
            #endregion

            #region Act
            var exception = Record.Exception(()=>sut.SendHelloToAhvaz());
            #endregion

            #region Assert
            Assert.Null(exception);
            #endregion
        }
    }
}
