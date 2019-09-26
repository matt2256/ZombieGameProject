using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritenceOfMasterRace
{
    class Knight : Humanoid
    {
        public Knight(string name, string lastName, byte hP, byte strength, byte intelligence, byte agility, byte stamina, byte constitution, byte wisdom, byte charisma, byte mana) : base(name, lastName, hP, strength, intelligence, agility, stamina, constitution, wisdom, charisma, mana)
        {

        }

        public void SwingSword(string name, string lastName)
        {
            Console.WriteLine($"{name} {lastName} cut you with a sword!!!");
        }

    }
}
