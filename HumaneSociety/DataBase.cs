using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSociety
{
    class DataBase
    {
        List<Adopter> adopter;
        List<Cage> cages;
        UserInterface ui;
        Cage cage;
        //public string AddAdopter()
        //{


        //}
        public void Decision()
        {
            ui = new UserInterface();
            Console.WriteLine("Hello there! Welcome to Nathan's Humane Center");
            Console.WriteLine("Would you like to Adopt a pet or Donate a pet?");
            string answer = Console.ReadLine();
            if (answer == "adopt")
            {
                ShowInventory();
                PickAPet();
            }
            else if (answer == "donate")
            {
                ui.DonateAPet();
            }
            else
            {
                Console.WriteLine("I'm sorry, that isn't an option\n\nTry Again.");
                Console.ReadLine();

            }
        }
        public void PickAPet()
        {
            string answer = ui.AdoptAPet().petPreference;
            switch (answer)
            {
                case "dog":
                    
                    break;
                case "cat":
                    break;
                default:
                    break;
            }
        }
        public void ShowInventory()
        {

        }
    }
}
