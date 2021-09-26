
using Xunit;
using ConsoleApp;
using Moq;

namespace MoqTests.dummy
{
    public class MoqDummyTest
    {
        [Fact]
        public void BuyTickerByMoney_ShouldReturnCorrectNumberOfTicket()
        {
            #region Arrange
            var animalTrainerMock = new Mock<IAnimalTrainer>();
            Zoo sut = new Zoo(animalTrainerMock.Object, 100);
            int money = 200;
            int expected = 2;
            #endregion

            #region Act
            int act = sut.BuyTicketByMoney(200);
            #endregion

            #region Assert
            Assert.Equal(expected, act);
            #endregion
        }
    }
}
