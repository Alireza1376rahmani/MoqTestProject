namespace ConsoleApp
{
    public class Pigeons
    {
        private readonly Village destination;
        private readonly string message;

        public Pigeons(Village destination, string message)
        {
            this.destination = destination;
            this.message = message;

            destination.RecieveNewMessage();
        }
    }
}