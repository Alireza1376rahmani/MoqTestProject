using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp;

namespace MoqTests.spy
{
    class SpyAnimalTrainer : IAnimalTrainer
    {
        public string SendedMessage { get; set; }
        public string Destination { get; set; }

        public Pigeons GetPigoens(Village destination, string message)
        {
            SendedMessage = message;
            Destination = destination.Name;
            return new Pigeons(destination, message);
        }
    }
}
