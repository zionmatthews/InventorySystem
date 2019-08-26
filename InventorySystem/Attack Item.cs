using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorySystem
{
    class Attack_Item : Item
    {
        private int _damage;

        public int Damage
        {
            get
            {
                return _damage;
            }
        }
        public Attack_Item(string newname, int newdamage, int newweight)
        {
            Name = newname;
            _damage = newdamage;
            weight = newweight;
        }
    }
}
