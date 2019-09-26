using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritenceOfMasterRace
{
    //class for creating different animals, etc dogs. 
    class Animal : Stats
    {
        //constructor for being able to inherit stats class
        public Animal(string name, string lastName, byte hP, byte strenght, byte inteligens, byte agility, byte stamina, byte constitution, byte wisdom, byte charisma ) : base (name, lastName, hP, strenght, inteligens, agility, stamina, constitution, wisdom, charisma) { }

        //method for when animals growls 
        public void Growl(string name, string lastName)
        {
            Console.WriteLine($"{name} {lastName} growled at you!");
        }

        //methods for when animals bites 
        public void Bite(string name, string lastName)
        {
            Console.WriteLine($"{name} {lastName} bit you, AW! ");
        }
    }
}
