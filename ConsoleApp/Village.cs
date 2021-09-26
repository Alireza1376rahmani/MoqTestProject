

namespace ConsoleApp
{
    public class Village
    {
        private IAnimalTrainer AnimalTrainer;

        public Village(string name, string address)
        {
            Name = name;
            Address = address;
            NumberOfRecievedMessages = 0;
        }

        public string Name { get; }
        public string Address { get; }
        public int NumberOfRecievedMessages { get; set; }

        public void getAnimalTrainer(IAnimalTrainer animalTrainer)
        {
            this.AnimalTrainer = animalTrainer;
        }

        public void SendMessageTo(Village destination, string message)
        {
            Pigeons pigeons = AnimalTrainer.GetPigoens(destination, message);
        }

        public void RecieveNewMessage()
        {
            NumberOfRecievedMessages ++;
        }

        public void SendHelloToAhvaz()
        {
            var dest = new Village("Ahvaz", "Iran");
            //SendMessageTo(dest, "Hello");
            Pigeons pigeons = AnimalTrainer.GetPigoens(dest, "Hello");
        }
    }
}
