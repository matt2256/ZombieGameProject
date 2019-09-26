using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritenceOfMasterRace
{
    class Program
    {
        //main method
        static void Main(string[] args)
        {
            //creating new NPC´s object from class´s 
            Dog Charlie = new Dog("Charlie ", "Greatman ", 50, 0, 45, 45, 50, 30, 10, 200);
            Zombie Klementine = new Zombie("Klementine ", "Charlston ", 30, 0, 0, 0, 0, 0, 0, 0);

            //Writing out to the console what the different NPC`s  does 

            //What the dog (Charlie) does
            Charlie.Growl(Charlie.Name, Charlie.LastName);
            Charlie.Bite(Charlie.Name, Charlie.LastName);
            Console.WriteLine("");
            Console.WriteLine("");

            //What the Zombie (Klementine) does
            Klementine.Punch(Klementine.Name, Klementine.LastName);
            Klementine.Bite(Klementine.Name, Klementine.LastName);

            Dwarf dwarf = new Dwarf("Patrick", "Holst", 200, 10, 0, 12, 234, 0, 20, 54, 43);
            dwarf.Punch(dwarf.Name, dwarf.LastName);
            dwarf.Kick(dwarf.Name, dwarf.LastName);
            Console.WriteLine(dwarf.Mana);

            Knight knight = new Knight("Patrick", "Holst", 200, 10, 0, 12, 234, 0, 20, 54, 43);
            knight.Punch(knight.Name, knight.LastName);
            knight.Kick(knight.Name, knight.LastName);
            knight.SwingSword(knight.Name, knight.LastName);

            Human human = new Human("Patrick", "Holst", 200, 10, 0, 12, 234, 0, 20, 54, 43);
            human.Punch(human.Name, human.LastName);
            human.Kick(human.Name, human.LastName);



            Console.ReadKey();
        }
    }
}


    