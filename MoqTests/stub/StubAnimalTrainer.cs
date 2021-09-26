using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp;

namespace MoqTests.stub
{
    class StubAnimalTrainer : IAnimalTrainer
    {
        public Pigeons GetPigoens(Village destination, string message)
        {
            return new Pigeons(destination, "");
        }
    }
}
