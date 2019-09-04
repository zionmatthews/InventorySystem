using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace InventorySystem
{
    class Map
    {
        private int _currentLocation = 0; //ID of the current scene
        private scene[] _sceneList;        //List of all the scenes on the map
        private entity_303[] _players;

        public Map(int startingSceneID, scene[] scenes, entity_303[] players)
        {
            _currentLocation = startingSceneID;
            _sceneList = scenes;
            _players = players;
        }

        public void PrintCurrentScene()
        {
            if (_currentLocation >= 0 && _currentLocation < _sceneList.Length)
            {
                //Print the current scene's name and description
                Console.WriteLine("");
                Console.WriteLine(_sceneList[_currentLocation].GetName());
                Console.WriteLine(_sceneList[_currentLocation].GetDescription());
            }
            else
            {
                Console.WriteLine("\nInvalid scene ID");
            }
        }

        public int CurrentSceneID
        {
            get
            {
                return _currentLocation;
            }
            set
            {
                //If value is on the map
                if (value >= 0 && value < _sceneList.Length)
                {
                    //Change to the new scene
                    _currentLocation = value;
                }
                //Otherwise
                else
                {
                    //print an error
                    Console.WriteLine("\nInvalid scene ID");
                }
            }
        }

        public void Menu()
        {
            string choice = "";
            while (choice != "0")
            {
                //Let the player know where they are
                PrintCurrentScene();

                //Priont the menu
                Console.WriteLine("\nMenu:");
                Console.WriteLine("0: Exit");
                Console.WriteLine("1: Travel");
                Console.WriteLine("2: Save");
                Console.WriteLine("3: Load");
                Console.WriteLine("4: Search");
                //Get the player's chocie
                choice = Console.ReadLine();
                if (choice == "1")
                {
                    Travel();
                }
                else if (choice == "2")
                {
                    Save("save.txt");
                }
                else if (choice == "3")
                {
                    Load("save.txt");
                }
                else if (choice == "4")
                {
                    Search();
                }
            }
        }

        public void Travel()
        {
            int destination = -1;
            //If the current scene is valid...
            if (_currentLocation >= 0 && _currentLocation < _sceneList.Length)
            {


                //...Ask the player where to go
                destination = _sceneList[_currentLocation].ChooseExit();
            }
            //If the destination is on the map..
            if (destination >= 0 && destination < _sceneList.Length)
            {
                //...Go there
                CurrentSceneID = destination;
            }
            else
            //Othereise..
            {
                // Tell the player
                Console.WriteLine("There is nothing in tthat direction.");
            }
            CheckForMonster();
           
              
        }

        public void Search()
        {
            //If the current scene is valid...
            if (_currentLocation >= 0 && _currentLocation < _sceneList.Length)
            {
                //..Search the room
                Console.WriteLine(_sceneList[_currentLocation].GetHidden());
            }
        }

        public void CheckForMonster()
        {
            if (_currentLocation >= 0 && _currentLocation < _sceneList.Length)
            {
                scene currentScene = _sceneList[_currentLocation];
                if (currentScene.GetCleared() == false)
                {
                    Encounter encounter = new Encounter(_players, currentScene.GetEnemies());
                    encounter.Start();
                }
            }
        }

        public void Save(string path)
        {
            //create a writer for the file at our path
            StreamWriter writer = File.CreateText(path);
            //Write to it the same way we write to the console
            writer.WriteLine(CurrentSceneID);
            //Close it
            writer.Close();
        }

        public void Load(string path)
        {
            if (File.Exists(path))
            {


                //Create a reader object for the file at our path
                StreamReader reader = File.OpenText(path);
                //Write to it the same way we read from the console
                CurrentSceneID = Convert.ToInt32(reader.ReadLine());
                //close it
                reader.Close();
            }
            else
            {
                Console.WriteLine("Save file not found.");
            }
        }
    }
}
