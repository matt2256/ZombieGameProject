using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritenceOfMasterRace
{
    class Stats
    {
        //Fields
        //The data value is protected so it´s not possible to change the datatype later
        //It is a string because "name" and "lastName" is going to show as letters not as numbers. 
        protected string name;
        protected string lastName;

        //It is a byte, because it dosent need a bigger value input than 256. It also saves alot of memory this way
        protected byte hP;
        protected byte strenght;
        protected byte inteligens;
        protected byte agility;
        protected byte stamina;
        protected byte constitution;
        protected byte wisdom;
        protected byte charisma;

        //Constructors
        public Stats(string name, string lastName, byte hP, byte strenght, byte inteligens, byte agility, byte stamina, byte constitution, byte wisdom, byte charisma)
        {
            Name = name;
            LastName = lastName;
            HP = hP;
            Strenght = strenght;
            Inteligens = inteligens;
            Agility = agility;
            Stamina = stamina;
            Constitution = constitution;
            Wisdom = wisdom;
            Charisma = charisma;
        }

        //Properties
        public string Name { get; set; }
        public string LastName { get; set; }
        public byte HP { get; set; }
        public byte Mana { get; set; }
        public byte Strenght { get; set; }
        public byte Inteligens { get; set; }
        public byte Agility { get; set; }
        public byte Stamina { get; set; }
        public byte Constitution { get; set; }
        public byte Wisdom { get; set; }
        public byte Charisma { get; set; }

        

    }
}
