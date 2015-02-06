/*
 *Author: Raveena Tayal
 *Last Modified on 2/6/2015
 *Program Description: Create a SuperHero class with superPowers array to hold three random powers out of a list 
 *                     of powers. Also display them using a method. Implement the class by creating an object and
 *                     call showPowers() method.
 *                     
 *Revision History: 
 *                 Revision: 5
 *                 Modified: 2/6/2015(11:50 am)
 *                 Author: Raveena Tayal
 *                 Log Entry: Modified the program and added revision history 
 *                 -----------------------------------------------------------------------
 *                 Revision: 4
 *                 Modified: 2/6/2015(11:37 am)
 *                 Author: Raveena Tayal             
 *                 Log Entry: Added extra functionality to the program
 *                 -----------------------------------------------------------------------
 *                 Revision: 3
 *                 Modified: 2/6/2015(11:34 am)
 *                 Author: Raveena Tayal
 *                 Log Entry: Implemented SuperHero class by creating an object in Program.cs
 *                 -----------------------------------------------------------------------
 *                 Revision: 2
 *                 Modified: 2/6/2015(11:19 am)
 *                 Author: Raveena Tayal
 *                 Log Entry: Added showPowers() method to display the super powers
 *                 -----------------------------------------------------------------------
 *                 Revision: 1
 *                 Modified: 2/6/2015(11:12 am)
 *                 Author: Raveena Tayal
 *                 Log Entry: Created SuperHero class that generates three random powers
 *                 -----------------------------------------------------------------------
 */



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_ASSIGNMENT2
{
    //Creating SuperHero subclass of Hero superclass 
    class SuperHero : Hero
    {

        //-------------------------------PRIVATE PROPERTIES-------------------------------
        private string[] superPowers;
        private string[] powersList = { "Super Speed", "Super Strength", "Body Armour", "Flight", "Fire Generation", "Weather Control" };

        //Instantiating object for pre-defined Random class
        Random rand = new Random();

        //-------------------------------CONSTRUCTOR--------------------------------------
        public SuperHero(string name)
            : base(name)
        {
            this.superPowers = new string[3]; //Initialising superPowers array
            generateRandomPowers();     //Calling generateRandomPowers() method
        }

        //---Method to generate three random super powers---------------------------------
        void generateRandomPowers()
        {
            int numPowers = powersList.Length;  //Number of powers
            int cnt = 0; //Index of elements in superArray
            while (cnt < 3)
            {
                int randomNumber = rand.Next(0, numPowers);
                //Check whether the power is already taken or not
                if (powersList[randomNumber] != "")
                {
                    superPowers[cnt] = powersList[randomNumber];  //Assign power to the superPowers array
                    powersList[randomNumber] = "";
                    cnt++;
                }
            }
        }

        //---Method to display powers ----------------------------------------------------        
        public void showPowers()
        {
            Console.WriteLine("YAY!!!");
            Console.WriteLine("The Super Hero {0} has super powers !!!!!", base.name);
            Console.WriteLine("Wanna see what those powers are????");
            Console.WriteLine("-------------------");
            for (int cnt = 0; cnt < 3; cnt++)
            {
                Console.WriteLine(superPowers[cnt]);
            }
            Console.WriteLine("-------------------");
        }
    }
}
