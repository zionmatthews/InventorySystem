using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorySystem
{
    class Encounter
    {
        private int _goodMonster;
        private Monster[] _goodMonsters;
        private Monster[] _badMonsters;

        public Encounter(Monster[] team1, Monster[] team2)
        {
            _goodMonsters = team1;
            _badMonsters = team2;
        }

        public void Print()
        {
            //The good monsters
            for (int i = 0; i <_goodMonsters.Length; i++)
            {
                Monster currentMonster = _goodMonsters[i];
                currentMonster.Print();
            }
            //The bad monsters
            for (int i = 0; i <_badMonsters.Length; i++)
            {
                Monster currentMonster = _badMonsters[i];
                currentMonster.Print();
            }
        }

        public void BegainRound()
        {
           for (int i = 0; i <_goodMonsters.Length; i++)
           {
                Monster currentMonster = _goodMonsters[i];
                currentMonster.Fight(_badMonsters);

           }
           for (int i = 0; i <_badMonsters.Length; i++)
           {
                Monster currentMonster = _badMonsters[i];
                currentMonster.Fight(_goodMonsters);
           }
        }

        public void Start()
        {
            Console.WriteLine("\n Begain!!!");
            bool stillFighting = true;
            while (stillFighting)
            {
                //check if team 1 is alive
                bool team1 = true;
                for (int i = 0; i < _goodMonsters.Length; i++)
                {
                    Monster currentMonster = _goodMonsters[i];
                    if (currentMonster.Health > 0)
                    {
                        /*our team is alive and not dead, break out
                        of the loop*/
                        team1 = true;
                        break;
                    }
                    else if (currentMonster.Health <= 0)
                    {
                        //our team may be dead
                        team1 = false;
                    }
                }   //check if team2 is alive
                bool team2 = true;
                int totalBadHealth = 0;
                    for (int i = 0; i < _badMonsters.Length; i++)
                    {
                        Monster currentMonster = _badMonsters[i];
                        //Total up the health of each monster on this team
                        totalBadHealth += currentMonster.Health;


                        team2 = totalBadHealth > 0;
                    }
                    //if both teams are alive
                    if (team1 && team2)
                    {
                          stillFighting = true;
                        BegainRound();
                    }
                    else
                    {
                       //stop
                       stillFighting = false;
                    }
                     Print();
            } 
        }
    }
}
