using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorySystem
{
    class Inventory
    {
        private int _damage = 0;
        private float _gold = 0.00f;
        private string _choice = "";
        private int _protection = 0;
        private float _amount = 0.00f;
        private Attack_Item[] _weaponList = new Attack_Item[10];
        private Attack_Item sword = new Attack_Item("Master Sword", 10, 3);
        private Attack_Item sword2 = new Attack_Item("Not Master Sword", 10, 3);
        private Attack_Item[] weapons = new Attack_Item[3];

        public Inventory()
        {
            Attack_Item[] weaponBag = { sword , sword2};
            weapons = weaponBag;
        }
        public void Menu()
        {



            while (_choice != "0")
            {
                //Display menu
                Console.WriteLine("\nMenu");
                Console.WriteLine("0: Exit");
                Console.WriteLine("1: Equip Weapon");
                Console.WriteLine("2: Unequip Weapon");
                Console.WriteLine("3: Add Gold");
                Console.WriteLine("4: Subtract Gold");
                Console.WriteLine("5: Equip Armor");
                Console.WriteLine("6: Unequip Armor");
                Console.WriteLine("7: Buy Potions");

                //Get input
                _choice = Console.ReadLine();
                Console.WriteLine("");

                //check input
                if (_choice == "1")
                {
                    EquipWeapon();
                }


                else if (_choice == "2")
                {
                    UnequipWeapon();
                }
                else if (_choice == "3")
                {
                    Console.WriteLine("How much gold?");
                    float addedGold = Convert.ToSingle(Console.ReadLine());
                    AddGold(addedGold);
                }
                else if (_choice == "4")
                {
                    Console.WriteLine("How much gold");
                    float subtractedGold = Convert.ToSingle(Console.ReadLine());
                    SubtractGold(subtractedGold);
                }
                else if (_choice == "5")
                {
                    Armor();
                }
                else if (_choice == "6")
                {
                    UnequipArmor();
                }
                else if (_choice == "7")
                {
                    Potions(_amount);
                }
            }
        }

        

        public void EquipWeapon()
        {
            //Weapons
            Console.WriteLine("Choose your weapon!!!");
            Console.WriteLine("1: Battle axe");
            Console.WriteLine("2: Sword");
            Console.WriteLine("3: Hammer");
            Console.WriteLine("4: Dagger");
            Console.WriteLine("5:  Go Back");

            _choice = Console.ReadLine();

            if (_choice == "1")
            {
                Console.WriteLine("You now have the Battle Axe!");
                _damage = 30;
                Console.WriteLine("Damage:" + _damage);
            }
            else if (_choice == "2")
            {
                Console.WriteLine("You now have a sword");
                _damage = 40;
                Console.WriteLine("Damage:" + _damage);
            }
            else if (_choice == "3")
            {
                Console.WriteLine("You now have a Hammer");
                _damage = 50;
                Console.WriteLine("Damage:" + _damage);
            }
            else if (_choice == "4")
            {
                Console.WriteLine("You now have Dagger");
                _damage = 60;
                Console.WriteLine("Damage:" + _damage);
            }
            else if (_choice == "5")
            {
                Menu();
            }

        }

        public void UnequipWeapon()
        {

            Console.WriteLine("Unquipped a weapon!");
            _damage = 10;
            Console.WriteLine("Damage:" + _damage);

        }

        public void AddGold(float amount)
        {
            Console.WriteLine("Got " + amount + " gold!");
            _gold += amount;
            Console.WriteLine("Gold: " + _gold);
        }
        public void SubtractGold(float amount)
        {
            if (_gold <= 0)
            {
                Console.WriteLine("Sorry, you don't have any.");
                return;
            }


            Console.WriteLine("Lost " + amount + " gold!");
            _gold -= amount;
            Console.WriteLine("Gold: " + _gold);


        }
        public void Armor()
        {
            //Armor
            Console.WriteLine("Choose your Armor");
            Console.WriteLine("1: Chain Armor");
            Console.WriteLine("2: Iron Armor");
            Console.WriteLine("3: Redstone Armor");
            Console.WriteLine("4: Diamond Armor");
            Console.WriteLine("5:  Go Back");

            _choice = Console.ReadLine();

            if (_choice == "1")
            {
                Console.WriteLine("You now have Chain Armor ");
                _protection = 30;
                Console.WriteLine("Protection:" + _protection);
            }
            else if (_choice == "2")
            {
                Console.WriteLine("You now have Iron Armor");
                _protection = 40;
                Console.WriteLine("Protection:" + _protection);
            }
            else if (_choice == "3")
            {
                Console.WriteLine("You now have Redstone Armor");
                _protection = 50;
                Console.WriteLine("Protection:" + _protection);
            }
            else if (_choice == "4")
            {
                Console.WriteLine("You now have Diamond Armor");
                _protection = 60;
                Console.WriteLine("Protection:" + _protection);
            }
            else if (_choice == "5")
            {
                Menu();
            }
        }
        public void UnequipArmor()
        {
            Console.WriteLine("Unequiped Armor");
            _protection = 10;
            Console.WriteLine("Protection:" + _protection);
        }

        public void Potions(float amount)
        {
            //potions
            Console.WriteLine("Select and buy your potion");
            Console.WriteLine("1: Speed potion");
            Console.WriteLine("2: Strenth potion");
            Console.WriteLine("3: Fire potion");
            Console.WriteLine("4: Water potion");
            Console.WriteLine("5:  Go back");

            _choice = Console.ReadLine();
            //It cost 25 gold to buy any potions

            if (_gold <= 24)
            {
                Console.WriteLine("You don't have enought to buy this.");
                return;
            }
            else if (_choice == "1")
            {
                Console.WriteLine("You now have Speed potion");

                Console.WriteLine("Lost " + amount + " gold!");
                _gold -= amount;
                Console.WriteLine("Gold: " + _gold);

            }
            if (_choice == "2")
            {
                Console.WriteLine("You now have Strenth potion ");

                Console.WriteLine("Lost " + amount + " gold!");
                _gold -= amount;
                Console.WriteLine("Gold: " + _gold);
            }
            if (_choice == "3")
            {
                Console.WriteLine("You now have Fire potion");

                Console.WriteLine("Lost " + amount + " gold!");
                _gold -= amount;
                Console.WriteLine("Gold: " + _gold);
            }
            if (_choice == "4")
            {
                Console.WriteLine("You now have Water potion");

                Console.WriteLine("Lost " + amount + " gold!");
                _gold -= amount;
                Console.WriteLine("Gold: " + _gold);
            }
            if (_choice == "5")
            {
                Menu();
            }
        }
    }

}
