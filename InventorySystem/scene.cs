using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorySystem
{
    class scene
    {
        private string _name;
        private string _description;
        private int _north;
        private int _south;
        private int _east;
        private int _west;

        public scene(string name, int northID, int southID, int eastID, int westID, string description)
        {
            _name = name;
            _description = description;
            _north = northID;
            _south = southID;
            _east = eastID;
            _west = westID;
        }

        //Return the name
        public string GetName()
        {
            return _name;
        }

        public string GetDescription()
        {
            return _description;
        }

        public int ChooseExit()
        {
            string choice = "";
            while (choice != "N" && choice != "S" && choice != "E" && choice != "W")
            {
                Console.WriteLine("\n Where would you like to go?");
                Console.WriteLine("N: North");
                Console.WriteLine("S: South");
                Console.WriteLine("E: East");
                Console.WriteLine("W: West");
                choice = Console.ReadLine();
                //Set choice to caps
                choice = choice.ToUpper();
            }

            if (choice == "N")
            {
                return _north;
            }
            else if (choice == "S")
            {
                return _south;
            }
            else if (choice == "E")
            {
                return _east;
            }
            else if (choice == "W")
            {
                return _west;
            }
            else
            {
                /*If we somehow an invalid choice, we can return -1.
                We have to make sure the Map knows not to attempt to
                travel*/
                return -1;
            }
            
        }
    }


}
