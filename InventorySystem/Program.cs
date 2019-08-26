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

            Character player = new Character("Zion");
            player.Print();

            Character Leo = new Character("Leo");
            Character Ryobi = new Character("Ryobi");
            Leo.Print();
            Ryobi.Print();

            player.Experience = 30;
            player.Experience = player.Experience + 50;
            player.Experience++;
            player.Experience += 40;
            player.Experience += 40;
            player.Experience += 100;
            player.Experience += 100;
            player.Experience += 100;
            player.Experience += 100;
            player.Experience += 100;
            player.Experience += 100;
            player.Experience += 100;
            player.Experience += 100;
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
