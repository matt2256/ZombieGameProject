using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritenceOfMasterRace
{
    class Human : Humanoid
    {
        
            public Human(string name, string lastName, byte hP, byte strength, byte intelligence, byte agility, byte stamina, byte constitution, byte wisdom, byte charisma, byte mana) : base(name, lastName, hP, strength, intelligence, agility, stamina, constitution, wisdom, charisma, mana)
            {

            }
        

    }
}
