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
            //0: Courtyard
            //1: Cast;e Gate
            //2: GraveYard
            //3: Village
            //                                           N, S, E, W

            scene courtyard = new scene("Ze Courtyard",  1, 3, -1, 2, "Ze courtyard is a wide and open to the sky. With a \nsmall garden nearby. There are exits to the north, south, east, and west");
            scene castleGate = new scene("Castle Gate",  -1, 0, -1, -1, "There is a massive gate at the entrance to the \ncastle. It appers to be locked. There is an exit to the south");
            scene graveyard = new scene("Graveyard",    -1, -1, 0, -1, "The graveyard is pretty spooky. Nonetheless, you pay respects. There is an exit to the east.");
            scene village = new scene("Village",       0, -1, -1, -1, "This is the village. There are abunch of buildings, I guess. There is an exit to the west.");


            scene[] scenes = { courtyard, castleGate, graveyard, village };
            Map map = new Map(0, scenes);
            /*
            map.PrintCurrentScene();
            map.CurrentSceneID = 1;
            map.PrintCurrentScene();
            map.CurrentSceneID = 2;
            map.PrintCurrentScene();
            map.CurrentSceneID = 3;
            map.PrintCurrentScene();
            map.CurrentSceneID = 4;
            map.PrintCurrentScene();
            */
            map.Menu();

            //Console.ReadKey();
            return;




            Monster UwU = new Monster("UwU", 10, 4);
            Monster OwO = new Monster("0w0", 10, 4);
            Monster VwU = new Monster("VwU", 5, 6);
            Monster YwU = new Monster("YwU", 5, 6);
            Character myself = new Mage("Me :)");

            entity_303[] UwO = { UwU, OwO };
            entity_303[] VwY = { VwU, YwU };

            myself.OpenInventory();

            Encounter encounter = new Encounter(UwO, VwY);
            encounter.Print();
            encounter.Start();


            Console.ReadKey();
            return;


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
