using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class Zoo
    {
        private readonly int ticketFee;

        public Zoo(IAnimalTrainer animalTrainer, int ticketFee)
        {
            this.ticketFee = ticketFee;
        }

        public int BuyTicketByMoney(int money)
        {
            int NumberOfTickets = (int)(money/ticketFee);
            return NumberOfTickets;
        }

    }
}
