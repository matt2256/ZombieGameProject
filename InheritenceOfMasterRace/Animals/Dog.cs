using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritenceOfMasterRace
{
    //Class for creating different a dog.
    class Dog : Animal
    {
        //Constructor for being able to inherit stats class
        public Dog(string name, string lastName, byte hP, byte strenght, byte inteligens, byte agility, byte stamina, byte constitution, byte wisdom, byte charisma) : base(name, lastName, hP, strenght, inteligens, agility, stamina, constitution, wisdom, charisma) { }

        
    }
}
