using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using ConsoleApp;
using Moq;

namespace MoqTests.mock
{
    public class MoqMockTest
    {

        [Fact]
        public void SendHelloToAhvazShouldSendHelloMessageToAhvaz()
        {
            #region Arrange
            var sut = new Village("tehran", "Iran");
            var dest = new Village("Ahvaz", "Iran");
            var mockAnimalTrainer = new Mock<IAnimalTrainer>();
            sut.getAnimalTrainer(mockAnimalTrainer.Object);
            mockAnimalTrainer.Setup(x => x.GetPigoens(dest, "Hello")).Returns(new Pigeons(dest, "Hello"));
            #endregion

            #region Act
            sut.SendHelloToAhvaz();
            #endregion

            #region Assert
            mockAnimalTrainer.Verify(proc => proc.GetPigoens(It.Is<Village>(x => x.Name == "Ahvaz"), "Hello"), Times.Exactly(1));
            #endregion
        }

    }
}
