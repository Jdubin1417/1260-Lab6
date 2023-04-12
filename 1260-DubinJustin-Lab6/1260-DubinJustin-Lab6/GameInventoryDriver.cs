using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1260_DubinJustin_Lab6
{
    public class GameInventoryDriver
    {
        public static void Main()
        {
            Backpack myBackpack = new Backpack();

            myBackpack.Add(new Clue("Letter", "A threatening letter from Fred", .1, 0));
            myBackpack.Add(new Weapon("Sword", "A bright shiny sword", 10.0, 25.0));
            myBackpack.Add(new Consumable("Aspirin", "A little something for your aching head", .5, 1.0));
            myBackpack.Add(new Consumable("Chocolate cake", "Delicious cake", 2.0, 7.5));
            myBackpack.Add(new Weapon("Battle Axe", "A wicked looking battle axe", 15.0, 35.0));
            myBackpack.Add(new Clue("Shirt", "A bloody shirt", 2.0, 0));
            myBackpack.Add(new Weapon("Pole Arm", "A heavy stick for hitting things", 8.0, 10.0));
            myBackpack.Add(new Consumable("Bandages", "A box of assorted bandages", .6, 1.0));

            Console.WriteLine(myBackpack.ListWeapons());
            Console.WriteLine(myBackpack.ListClues());
            Console.WriteLine(myBackpack.ListConsumables());
        }
    }
}
