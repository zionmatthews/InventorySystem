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
        private string _hidden;
        private Entity_303[] _enemies;
        private bool _cleared = false;
        private Entity_303[] enemies;

        public scene(string name, int northID, int southID, int eastID, int westID, string description, Entity_303[] _enemies)
        {
            _name = name;
            _description = description;
            _north = northID;
            _south = southID;
            _east = eastID;
            _west = westID;
            _enemies = enemies;
            _hidden = "Nothing was found.";
            if (_enemies.Length == 0)
            {
                _cleared = true;
            }
        }

        public scene(string name, int northID, int southID, int eastID, int westID, string description, string _hidden, Entity_303[] _enemies)
        {
            _name = name;
            _description = description;
            _north = northID;
            _south = southID;
            _east = eastID;
            _west = westID;
            _enemies = enemies;
            _hidden = _hidden;
            if (_enemies.Length == 0)
            {
                _cleared = true;
            }
        }

        public scene(string v1, int v2, int v3, int v4, int v5, Entity_303[] empty, string v6)
        {
        }

        public scene(string v1, int v2, int v3, int v4, int v5, object vwy, string v6)
        {
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

        public Entity_303[] GetEnemies()
        {
            return _enemies;
        }

        public bool GetCleared()
        {
            return _cleared;
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

        public string GetHidden()
        {
            return _hidden;
        }
    }


}
