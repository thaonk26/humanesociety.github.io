using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSociety
{
    class Cat : Animal
    {
        public string breed { get; set; }
        public string color { get; set; }
        public Cat(string Name, int Age, bool Shots, string Breed, string Color):base(Name,Age,Shots)
        {
            breed = Breed;
            color = Color;
        }
    }
}
