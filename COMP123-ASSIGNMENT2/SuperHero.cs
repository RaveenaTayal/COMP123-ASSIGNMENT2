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
            Console.WriteLine("The Super Hero {0} has super powers !!!!!", base.name);
            for (int cnt = 0; cnt < 3; cnt++)
            {
                Console.WriteLine(superPowers[cnt]);
            }
        }
    }
}
