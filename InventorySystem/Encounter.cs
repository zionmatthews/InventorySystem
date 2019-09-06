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
        private Entity_303[] _goodMonsters;
        private Entity_303[] _badMonsters;
        private Entity_303[] _goodTeam;
        private Entity_303[] _badTeam;

        public Encounter(Entity_303[] team1, Entity_303[] team2)
        {
            _goodMonsters = team1;
            _badMonsters = team2;
        }

        public void Print()
        {
            //The good monsters
            for (int i = 0; i <_goodMonsters.Length; i++)
            {
                Entity_303 currentMonster = _goodMonsters[i];
                currentMonster.Print();
            }
            //The bad monsters
            for (int i = 0; i <_badMonsters.Length; i++)
            {
                Entity_303 currentMonster = _badMonsters[i];
                currentMonster.Print();
            }
        }

        public void BegainRound()
        {
           for (int i = 0; i <_goodMonsters.Length; i++)
           {
                Entity_303 currentMonster = _goodMonsters[i];
                currentMonster.Fight(_badMonsters);

           }
           for (int i = 0; i <_badMonsters.Length; i++)
           {
                Entity_303 currentMonster = _badMonsters[i];
                currentMonster.Fight(_goodMonsters);
           }
        }
        private int GetTotalXP(Entity_303[] entity_303)
        {
            int total = 0;
            for (int i = 0; i < _goodMonsters.Length; i++)
            {
                total += _goodMonsters[i].GetXp();
            }
            return total;
        }

        public void Start()
        {
            Console.WriteLine("\n Begain!!!");
            bool stillFighting = true;
            while (stillFighting)
            {
                //check if team 1 is alive
                bool goodIsAlive = true;
                bool badIsAlive = false;
                for (int i = 0; i < _goodMonsters.Length; i++)
                {
                    Entity_303 currentMonster = _goodMonsters[i];
                    if (currentMonster.Health > 0)
                    {
                        /*our team is alive and not dead, break out
                        of the loop*/
                        goodIsAlive = true;
                        break;
                    }
                    else if (currentMonster.Health <= 0)
                    {
                        //our team may be dead
                        goodIsAlive = false;
                    }
                }   //check if team2 is alive
                bool team2 = true;
                int totalBadHealth = 0;
                    for (int i = 0; i < _badMonsters.Length; i++)
                    {
                        Entity_303 currentMonster = _badMonsters[i];
                        //Total up the health of each monster on this team
                        totalBadHealth += currentMonster.Health;


                        team2 = totalBadHealth > 0;
                    }
                    stillFighting = false;
                    if (goodIsAlive)
                    {
                          foreach (Entity_303 cr in _goodTeam)
                          {
                             if (cr is Character)
                             {
                               Character ch = (Character)cr;
                               ch.Experience += GetTotalXP(_badTeam);
                             }

                          }
                    }
                    else if (badIsAlive)
                    {
                       foreach (Entity_303 cr in _badTeam)
                       {
                          if (cr is Character)
                          {
                            Character ch = (Character)cr;
                            ch.Experience += GetTotalXP(_goodTeam);
                          }
                       }
                    }
                     Print();
            } 
        }
    }
}
