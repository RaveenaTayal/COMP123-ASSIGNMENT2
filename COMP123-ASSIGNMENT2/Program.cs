using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_ASSIGNMENT2
{
    class Program
    {
        static void Main(string[] args)
        {

            //---Creating an object for SuperHero class
            SuperHero superHero = new SuperHero("Spider Man");
            superHero.showPowers();
            superHero.fight();

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();

        }
    }
}
