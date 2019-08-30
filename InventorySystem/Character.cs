using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorySystem
{
    class Character : entity_303
    {
        private string _name = "";
        private int _xp = 0;
        private int _level = 1;
        private int[] _requiredXP = { 100, 300, 600, 1000 };

        private Inventory inventory = new Inventory();

        protected int _health = 100;
        protected int _mana = 100;
        protected int _strength = 5;
        protected int _dexterity = 5;
        protected int _wisdom = 5;

        public Character(string name)
        {
            _name = name;
            _health = 100;
            _maxHealth = 100;
        }
        public override string GetName()
        {
            return _name;
        }

        public override int GetDamage()
        {
            return _strength + inventory.GetItemDamage();
        }
        public string Name()
        {
            return _name;
        }

        public void Print()
        {
            Console.WriteLine(_name);
            Console.WriteLine("Level: " + _level);
            Console.WriteLine("Experience: " + _xp);
            Console.WriteLine("Health: " + _health);
            Console.WriteLine("Mana: " + _mana);
            Console.WriteLine("Strength: " + _dexterity);
            Console.WriteLine("Wisdom: " + _wisdom);
            Console.WriteLine("Comabt Damage: " + _strength );
            Console.WriteLine("");
        }

        public void OpenInventory()
        {
            inventory.Menu();
        }

        public int Experience
        {
            get
            {
                return _xp;
            }
            set
            {
                _xp = value;
                Console.WriteLine(_name + " gained experience and now has " + _xp);
                if (_level <= _requiredXP.Length)
                {


                    if (_xp >= _requiredXP[_level - 1])
                    {
                        _level++;
                        Console.WriteLine(_name + "'s level increased to " + _level + "!");
                    }
                }
            }
        }



        public void weaponAccess()
        {

        }

        public override void Fight(entity_303 target)
        {
            if (Health <= 0)
            {
                return;
            }
            int damage = GetDamage();
            target.Health -= damage;
            Console.WriteLine(GetName() + "attacks! " + target.GetName() + " takes " + damage);

        }
        public override  void Fight(entity_303[] targets)
        {
            if (Health <= 0)
            {
                return;
            }

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

            }


        }
    }
}
