using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSociety
{
    class Animal
    {
        public int age { get; set; }
        public string name { get; set; }
        public bool shots { get; set; }
        protected int price { get; private set; }
        public Animal(string Name, int Age, bool Shots)
        {
            this.name = Name;
            this.age = Age;
            this.shots = Shots;
        }        
        public void Display()
        {
            Console.WriteLine("{0} is {1} and costs {3}", name, age, price);
        }
    }
}
