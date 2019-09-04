using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorySystem
{
    class Monster : entity_303
    {   
        private string _name = "Lynx";
        private int _health = 100;
        private int _damage = 20;
        private int _maxHealth = 100;

        public Monster(string name, int health, int damage)
        {
            _name = name;
            _health = health;
            _maxHealth = health;
            _damage = damage;
        }
        public override string GetName()
        {
            return _name;
        }
        public override int GetDamage()
        {
            return _damage;
        }
        
        public int Health
        {
            get
            {
                return _health;
            }
            set
            {
                _health = value;
                if (_health > _maxHealth)
                {
                    _health = _maxHealth;
                }
                else if (_health < 0)
                {
                    _health = 0;
                }
            }

        }



        public  void Print()
          {
            Console.WriteLine("\n" + _name);
            Console.WriteLine(_health);
            Console.WriteLine(_maxHealth);
            Console.WriteLine(_damage);
            Console.ReadKey();

        }
        public override void Fight(entity_303 target)
        {
            if(Health <= 0)
            {
                return;
            }
            int damage = GetDamage();            
            target.Health -= damage;
            Console.WriteLine(GetName() + "attacks! " + target.GetName() + " takes " + damage);

        }
        public void Fight(entity_303[] targets)
        {
            if (Health <= 0)
            {
                return;
            }

            
            int choice = Program.random.Next(0, targets.Length);
            Fight(targets[choice]);
            /*
            bool validInput = false;
            while (!validInput)
            {
                Console.WriteLine("\nWho will " + GetName() + " fight? ");
               

                for (int i = 0; i < targets.Length; i++)
                {
                    string targetName = targets[i].GetName();
                    Console.WriteLine(i + ": " + targetName);
                }

                string input = Console.ReadLine();
                int choice = Convert.ToInt32(input);
                
                if (choice >= 0 && choice < targets.Length)
                {
                    validInput = true;

                    Fight(targets[choice]);
                }

            }*/

                 
        }
    }    

}
