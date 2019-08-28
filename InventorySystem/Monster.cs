using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorySystem
{
    class Monster
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
        public string GetName()
        {
            return _name;
        }
        public int GetDamage()
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

        public void Print()
        {
            Console.WriteLine("/n" + _name);
            Console.WriteLine(_health);
            Console.WriteLine(_maxHealth);
            Console.WriteLine(_damage);
            Console.ReadKey();

        }
    }    

}
