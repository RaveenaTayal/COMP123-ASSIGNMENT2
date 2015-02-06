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

            Console.Write("Suggest a name for your hero: ");
            String name = Console.ReadLine();

            //---Creating an object for SuperHero class
            SuperHero superHero = new SuperHero(name);
            superHero.showPowers();
            superHero.show();
            superHero.fight();

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();

        }
    }
}
