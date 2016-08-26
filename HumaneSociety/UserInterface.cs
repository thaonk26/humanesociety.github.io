using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSociety
{
    class UserInterface
    {
        Adopter adopter;
        DataBase dataBase;
        Dog dog;
        public void Decision()
        {
            Console.WriteLine("Hello there! Welcome to Nathan's Humane Center");
            Console.WriteLine("Would you like to Adopt a pet or Donate a pet?");
            string answer = Console.ReadLine();
            if (answer == "adopt")
            {
                dataBase.ShowInventory();
                AdoptAPet();
            }else
            {
                DonateAPet();
            }
        }
        public Adopter AdoptAPet()
        {
            
            Console.WriteLine("Can I get your name?");
            adopter.name = Console.ReadLine();
            Console.WriteLine("We have a variety of Cats and Dogs\nWhat kind of pet would you like to adopt today?");
            adopter.petPreference = Console.ReadLine();
            switch (adopter.petPreference)
            {
                case "dog":
                    return null;
                case "cat":
                    return null;
                default:
                    return null;
            }
        }
        public Animal DonateAPet()
        {
            //List<Cage> addCage = new List<Cage>();
            Console.WriteLine("What kind of animal is it?");
            string kindOfAnimal = Console.ReadLine();
            Console.WriteLine("What is its name");
            string name = Console.ReadLine();
            Console.WriteLine("What is the pets age?");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Do you know what breed it is?");
            string breed = Console.ReadLine();
            Console.WriteLine("What color is the {0}?", kindOfAnimal);
            string color = Console.ReadLine();
            Console.WriteLine("Has the {0} recieved it's shots? (type 'true' or 'false')", kindOfAnimal);
            bool shots = Convert.ToBoolean(Console.ReadLine());
            switch (kindOfAnimal)
            {
                case "dog":
                    return new Dog(name, age, shots, breed, color);
                case "cat":
                    return new Cat(name, age, shots, breed, color);
                default:

                    return null;
            }            
        }
    }
}
