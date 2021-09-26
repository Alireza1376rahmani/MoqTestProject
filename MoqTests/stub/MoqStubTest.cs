using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using ConsoleApp;
using Moq;

namespace MoqTests.stub
{
    public class MoqStubTest
    {
        [Fact]
        public void NumberOfMessagesShouldBeOneAfterRecievingOneMessage()
        {
            #region Arrange
            var someVillage = new Village("ramsar", "shomal");
            var sut = new Village("sut", "someWhere");
            var animalTrainer = new Mock<IAnimalTrainer>();
            animalTrainer.Setup(x => x.GetPigoens(sut,"some text")).Returns(new Pigeons(sut,"someText"));
            someVillage.getAnimalTrainer(animalTrainer.Object);
            int expected = 1;
            #endregion

            #region Act
            someVillage.SendMessageTo(sut, "some message");
            #endregion

            #region Assert
            Assert.Equal(expected, sut.NumberOfRecievedMessages);
            #endregion
        }
    }
}
