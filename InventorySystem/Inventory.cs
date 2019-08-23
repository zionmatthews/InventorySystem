using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorySystem
{
    class Inventory
    {
        int damage = 0;
        float gold = 0.00f;
        string choice = "";
        int protection = 0;
        float amount = 0.00f;
        public void Menu()
        {



            while (choice != "0")
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
                choice = Console.ReadLine();
                Console.WriteLine("");

                //check input
                if (choice == "1")
                {
                    EquipWeapon();
                }


                else if (choice == "2")
                {
                    UnequipWeapon();
                }
                else if (choice == "3")
                {
                    Console.WriteLine("How much gold?");
                    float addedGold = Convert.ToSingle(Console.ReadLine());
                    AddGold(addedGold);
                }
                else if (choice == "4")
                {
                    Console.WriteLine("How much gold");
                    float subtractedGold = Convert.ToSingle(Console.ReadLine());
                    SubtractGold(subtractedGold);
                }
                else if (choice == "5")
                {
                    Armor();
                }
                else if (choice == "6")
                {
                    UnequipArmor();
                }
                else if (choice == "7")
                {
                    Potions(amount);
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

            choice = Console.ReadLine();

            if (choice == "1")
            {
                Console.WriteLine("You now have the Battle Axe!");
                damage = 30;
                Console.WriteLine("Damage:" + damage);
            }
            else if (choice == "2")
            {
                Console.WriteLine("You now have a sword");
                damage = 40;
                Console.WriteLine("Damage:" + damage);
            }
            else if (choice == "3")
            {
                Console.WriteLine("You now have a Hammer");
                damage = 50;
                Console.WriteLine("Damage:" + damage);
            }
            else if (choice == "4")
            {
                Console.WriteLine("You now have Dagger");
                damage = 60;
                Console.WriteLine("Damage:" + damage);
            }
            else if (choice == "5")
            {
                Menu();
            }

        }

        public void UnequipWeapon()
        {

            Console.WriteLine("Unquipped a weapon!");
            damage = 10;
            Console.WriteLine("Damage:" + damage);

        }

        public void AddGold(float amount)
        {
            Console.WriteLine("Got " + amount + " gold!");
            gold += amount;
            Console.WriteLine("Gold: " + gold);
        }
        public void SubtractGold(float amount)
        {
            if (gold <= 0)
            {
                Console.WriteLine("Sorry, you don't have any.");
                return;
            }


            Console.WriteLine("Lost " + amount + " gold!");
            gold -= amount;
            Console.WriteLine("Gold: " + gold);


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

            choice = Console.ReadLine();

            if (choice == "1")
            {
                Console.WriteLine("You now have Chain Armor ");
                protection = 30;
                Console.WriteLine("Protection:" + protection);
            }
            else if (choice == "2")
            {
                Console.WriteLine("You now have Iron Armor");
                protection = 40;
                Console.WriteLine("Protection:" + protection);
            }
            else if (choice == "3")
            {
                Console.WriteLine("You now have Redstone Armor");
                protection = 50;
                Console.WriteLine("Protection:" + protection);
            }
            else if (choice == "4")
            {
                Console.WriteLine("You now have Diamond Armor");
                protection = 60;
                Console.WriteLine("Protection:" + protection);
            }
            else if (choice == "5")
            {
                Menu();
            }
        }
        public void UnequipArmor()
        {
            Console.WriteLine("Unequiped Armor");
            protection = 10;
            Console.WriteLine("Protection:" + protection);
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

            choice = Console.ReadLine();

            if (gold <= 24)
            {
                Console.WriteLine("You don't have enought to buy this.");
                return;
            }
            else if (choice == "1")
            {
                Console.WriteLine("You now have Speed potion");

                Console.WriteLine("Lost " + amount + " gold!");
                gold -= amount;
                Console.WriteLine("Gold: " + gold);

            }
            if (choice == "2")
            {
                Console.WriteLine("You now have Strenth potion ");

                Console.WriteLine("Lost " + amount + " gold!");
                gold -= amount;
                Console.WriteLine("Gold: " + gold);
            }
            if (choice == "3")
            {
                Console.WriteLine("You now have Fire potion");

                Console.WriteLine("Lost " + amount + " gold!");
                gold -= amount;
                Console.WriteLine("Gold: " + gold);
            }
            if (choice == "4")
            {
                Console.WriteLine("You now have Water potion");

                Console.WriteLine("Lost " + amount + " gold!");
                gold -= amount;
                Console.WriteLine("Gold: " + gold);
            }
            if (choice == "5")
            {
                Menu();
            }
        }
    }

}
