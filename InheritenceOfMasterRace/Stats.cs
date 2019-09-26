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
        protected byte maxStat = 250;

        //Constructors
        public Stats(string name, string lastName, byte hP, byte strenght, byte inteligens, byte agility, byte stamina, byte constitution, byte wisdom, byte charisma)
        {
            Name = name;
            LastName = lastName;
            HP = hP;
            Strength = strenght;
            Intelligence = inteligens;
            Agility = agility;
            Stamina = stamina;
            Constitution = constitution;
            Wisdom = wisdom;
            Charisma = charisma;

        }

        //Properties
        public string Name { get; set; }
        public string LastName { get; set; }
        public byte HP
        {
            get { return hP; }
            set
            {
                if (hP < maxStat)
                {
                    hP = value;
                }

                if (hP >= maxStat)
                {
                    hP = maxStat;
                }
            }
        }

        public byte Strength
        {
            get { return strenght; }
            set
            {
                if (strenght < maxStat)
                {
                    strenght = value;
                }

                if (strenght >= maxStat)
                {
                    strenght = maxStat;
                }
            }
        }

        public byte Intelligence
        {
            get { return inteligens; }
            set
            {
                if (inteligens < maxStat)
                {
                    inteligens = value;
                }

                if (inteligens >= maxStat)
                {
                    inteligens = maxStat;
                }
            }
        }

        public byte Agility
        {
            get { return agility; }
            set
            {
                if (agility < maxStat)
                {
                    agility = value;
                }

                if (agility >= maxStat)
                {
                    agility = maxStat;
                }
            }
        }

        public byte Stamina
        {
            get
            {
                return stamina;
            }
            set
            {
                if (stamina < maxStat)
                {
                    stamina = value;
                }
                if (stamina <= maxStat)
                {
                    stamina = maxStat;
                }
            }
        }
        public byte Constitution
        {
            get
            {
                return constitution;
            }
            set
            {
                if (constitution < maxStat)
                {
                    constitution = value;
                }
                if (constitution <= maxStat)
                {
                    constitution = maxStat;
                }
            }
        }
        public byte Wisdom
        {
            get
            {
                return wisdom;
            }
            set
            {
                if (wisdom < maxStat)
                {
                    wisdom = value;
                }
                if (wisdom <= maxStat)
                {
                    wisdom = maxStat;
                }
            }
        }
        public byte Charisma
        {
            get
            {
                return charisma;
            }
            set
            {
                if (charisma < maxStat)
                {
                    charisma = value;
                }
                if (charisma <= maxStat)
                {
                    charisma = maxStat;
                }
            }
        }




    }
}
