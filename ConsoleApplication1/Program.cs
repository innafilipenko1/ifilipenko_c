using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    using ConsoleApplication1.Realization;

    class Program
    {
        static void Main(string[] args)
        {
/*            CanYouDrinkAlcohol p = new CanYouDrinkAlcohol();
            p.StartProgram();*/

            EncupsulationProgramm ep = new EncupsulationProgramm();
            ep.SayHello();

        }
    }
}
