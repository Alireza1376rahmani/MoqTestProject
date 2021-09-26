using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using ConsoleApp;

namespace MoqTests.stub
{
    public class StubTests
    {

        [Fact]
        public void NumberOfMessagesShouldBeOneAfterRecievingOneMessage()
        {
            #region Arrange
            var someVillage = new Village("ramsar", "shomal");
            var stubAnimalTrainer = new StubAnimalTrainer();
            someVillage.getAnimalTrainer(stubAnimalTrainer);
            var sut = new Village("sut", "someWhere");
            int expected = 1;
            #endregion

            #region Act
            someVillage.SendMessageTo(sut, "some message");
            #endregion

            #region Assert
            Assert.Equal(expected,sut.NumberOfRecievedMessages);
            #endregion
        }

    }
}
