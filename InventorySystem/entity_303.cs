using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorySystem
{
    class entity_303
    {
        
        protected int _health = 100;
        protected int _maxHealth = 100;


        public virtual void Fight(entity_303 target)
        {

        }

        public virtual void Fight(entity_303[] targets)
        {

        }

        public virtual int GetDamage()
        {
            return 0;
        }
        public virtual string GetName()
        {
            return "";
        }

        public virtual int GetDefense()
        {
            return 0;
        }

        public virtual void GetXp()
        {

        }

        public virtual void Print()
        {

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
    }
}
