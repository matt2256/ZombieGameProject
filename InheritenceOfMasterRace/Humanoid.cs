using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritenceOfMasterRace
{
    class Humanoid : Stats
    {// Mana only for Humanoids
        protected byte mana;

        // Inheriting the constructor from Stats
        public Humanoid(string name, string lastName, byte hP, byte strength, byte intelligence, byte agility, byte stamina, byte constitution, byte wisdom, byte charisma, byte mana) : base(name, lastName, hP, strength, intelligence, agility, stamina, constitution, wisdom, charisma)
        {
            Mana = mana;
        }

        public byte Mana
        {
            get { return mana; }
            set { mana = value; }
        }

        // Methods that can be used by Humanoids
        public void Punch(string name, string lastName)
        {
            Console.WriteLine($"{name} {lastName} punched you!!!");
        }

        public void Kick(string name, string lastName)
        {
            Console.WriteLine($"{name} {lastName} kicked you!!!");
        }

    }
}
