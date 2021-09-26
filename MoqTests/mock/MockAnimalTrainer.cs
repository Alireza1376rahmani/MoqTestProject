
using ConsoleApp;

namespace MoqTests.mock
{
    class MockAnimalTrainer : IAnimalTrainer
    {
        public Pigeons GetPigoens(Village destination, string message)
        {
            if(message != "Hello")
                throw new System.Exception("the message was not Hello");
            if (destination.Name != "Ahvaz")
                throw new System.Exception("the destination was not Ahvaz");
            return new Pigeons(destination, message);
        }
    }
}
