using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritenceOfMasterRace
{
    //Class for creating different creature, etc. zombies.
    class Creatures : Stats
    {
        //Constructor for being able to inherit stats class
        public Creatures(string name, string lastName, byte hP, byte strenght, byte inteligens, byte agility, byte stamina, byte constitution, byte wisdom, byte charisma) : base(name, lastName, hP, strenght, inteligens, agility, stamina, constitution, wisdom, charisma) { }

        //method for when creatues puch
        public void Punch(string name, string lastName)
        {
            Console.WriteLine($"{name} {lastName} just puched you! you just fell back. HAHA");
        }

        //method for when creatures bites
        public void Bite(string name, string lastName)
        {
            Console.WriteLine($"{name} {lastName} just bit you. You are now effect by posion. HAHAHA you are slowly dieing");
        }
    }
}
