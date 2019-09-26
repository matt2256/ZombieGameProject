using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritenceOfMasterRace
{
    //class for zombies
    //This class is used for creating a zombie
    class Zombie : Creatures
    {
        public Zombie(string name, string lastName, byte hP, byte strenght, byte inteligens, byte agility, byte stamina, byte constitution, byte wisdom, byte charisma) : base(name, lastName, hP, strenght, inteligens, agility, stamina, constitution, wisdom, charisma) { }
    }
}
