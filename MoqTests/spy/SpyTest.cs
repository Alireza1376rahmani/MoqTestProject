using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using ConsoleApp;


namespace MoqTests.spy
{
    public class SpyTest
    {
        [Fact]
        public void SendHelloToAhvazShouldSendHelloMessageToAhvaz()
        {
            #region Arrange
            var sut = new Village("tehran", "Iran");
            var spyAnimalTrainer = new SpyAnimalTrainer();
            sut.getAnimalTrainer(spyAnimalTrainer);
            var expectedDestination = "Ahvaz";
            var ExpectedMessage = "Hello";
            #endregion

            #region Act
            sut.SendHelloToAhvaz();
            #endregion

            #region Assert
            Assert.Equal(expectedDestination, spyAnimalTrainer.Destination);
            Assert.Equal(ExpectedMessage, spyAnimalTrainer.SendedMessage);
            #endregion
        }


    }
}
