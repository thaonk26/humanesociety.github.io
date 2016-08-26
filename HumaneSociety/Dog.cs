using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSociety
{
    class Dog : Animal
    {
        public string breed { get; set; }
        public string color { get; set; }
        public Dog(string Name, int Age, bool Shots, string Breed, string Color) : base(Name, Age, Shots)
        {
            breed = Breed;
            color = Color;
        }
        
        public string SetBreed()
        {
            Console.WriteLine("What is the breed");
            breed = Console.ReadLine();
            return breed;
        }
        public int SetPrice()
        {
            int price = age * 50;
            return price;
        }
    }
}
