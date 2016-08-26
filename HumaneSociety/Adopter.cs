using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSociety
{
    class Adopter
    {
        public string name;
        public string petPreference;
        List<Animal> animal;
        public Adopter()
        {
            
        }
        public void AdoptingPet()
        {
            animal = new List<Animal>();

        }
    }
}
