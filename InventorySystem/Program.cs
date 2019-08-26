using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorySystem
{
    class Program
    {
        static void Main(string[] args)
        {
            //Inventory inventory = new Inventory();
            //inventory.Menu();
            string name = "";
            string choice = "";

            while (choice != "1" && choice != "2")
            {


                Console.WriteLine("Enter name of party member 1:");
                 name = Console.ReadLine();
                //display menu]
                Console.WriteLine("\nChoose a job");
                Console.WriteLine("1: Mage");
                Console.WriteLine("2: Rogue");
                choice = Console.ReadLine();
            }
            Character player;
            if (choice == "1")
            {
                player = new Mage(name);
            }
            else if (choice == "2")
            {
                player = new Rogue(name);
            }
            else 
            {
                player = new Character(name);
            }
            player.Print();

            player.OpenInventory();
            
            Rogue Leo = new Rogue("Leo");
            Mage Ryobi = new Mage("Ryobi");
            Leo.Print();
            Console.WriteLine("");
            Ryobi.Print();
            Console.WriteLine("");

            choice = "";
            while (choice != "0")
            {



                //display menu]
                Console.WriteLine("\nWhose inventory");
                Console.WriteLine("0: Exit");
                Console.WriteLine("1: " + player.Name());
                Console.WriteLine("2: " + Leo.Name());
                Console.WriteLine("3: " + Ryobi.Name());
                choice = Console.ReadLine();
                if (choice == "1")
                {
                    Console.WriteLine(player.Name());
                    player.OpenInventory();
                }
                else if (choice == "2")
                {
                    Console.WriteLine(Leo.Name());
                    Leo.Print();
                    Leo.OpenInventory();
                }
                else if (choice == "3")
                {
                    Console.WriteLine(Ryobi.Name());
                    Ryobi.Print();
                    Ryobi.OpenInventory();
                }
            }
            player.Experience = 30;
            player.Experience = player.Experience + 50;
            player.Experience++;
            player.Experience += 40;
            player.Experience += 40;
            player.Experience += 100;
            player.Experience += 100;

            int[] testArry = new int[4];

            testArry[0] = 1;
            testArry[1] = 3;
            testArry[2] = 5;
            testArry[3] = 7;

            int[] testArray2 = { 2, 3, 6, 8 };

            string[] stringArry = new string[3];

            Character[] party = { player, Leo, Ryobi, new Character("Like") };
            


            Console.ReadKey();
        }
    }
}
