using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorySystem
{
    class Rogue : Character
    {
        public Rogue(string name) : base(name)
        {
            _health = 500;
            _mana = 30;
            _strength = 9;
            _dexterity = 1;
            _wisdom = 3;
        }
    }
}
