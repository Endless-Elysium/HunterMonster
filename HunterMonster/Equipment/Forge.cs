using HunterMonster_Equipment;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HunterMonster.Equipment
{
    internal class Forge
    {
        public static Hunter ForgeEquipment(Hunter hunter)
        {
            Console.WriteLine("What would you like to forge?");
            Console.WriteLine("press 1 for Weapons");
            Console.WriteLine("press 2 for Helmets");
            Console.WriteLine("press 3 for Chestplates");
            int input = Ui.IntPlayerInput();
            Console.WriteLine("    G is for gold");
            Console.WriteLine("    P is for monster mats");
            Console.WriteLine("    -press 0 to quit-");
            if (input == 1)
            {
                hunter = ForgeWeapon(hunter);

            }
            else if (input == 2)
            {
                hunter = ForgeHelmet(hunter);
            }
            else if (input == 3)
            {
                hunter = ForgeChestPlate(hunter);
            }
            else
            {
                return hunter;
            }
            return hunter;
        }
        private static Hunter ForgeWeapon(Hunter hunter)
        {
            int input;
            Ui.DrawWeaponCraft();
            input = Ui.IntPlayerInput();
            if (input == 0) return hunter;
            if (Points.Mats[EquipmentListClass.weapons[input - 1].CostType].Amount >= EquipmentListClass.weapons[input - 1].Cost)
            {
                hunter.MyWeapon = EquipmentListClass.weapons[input - 1];
            }
            else
            {
                Console.WriteLine("Not enough");
            }
            return hunter;
        }
        private static Hunter ForgeHelmet(Hunter hunter)
        {
            int input;
            Ui.DrawHelmetCraft();
            input = Ui.IntPlayerInput();
            if (input == 0) return hunter;
            try
            {
                if (Points.Mats[EquipmentListClass.Helmets[input - 1].CostType].Amount >= EquipmentListClass.Helmets[input - 1].Cost)
                {
                    hunter.MyArmor.Helmet = EquipmentListClass.Helmets[input - 1];
                }
                else
                {
                    Console.WriteLine("Not enough");
                }
        }
            catch (Exception)
            {
                Console.WriteLine("Enter a valid number.");
            }

            return hunter;
        }
        private static Hunter ForgeChestPlate(Hunter hunter)
        {
            int input;
            Ui.DrawChestPlateCraft();
            input = Ui.IntPlayerInput();
            if (input == 0) return hunter;
            try
            {
                if (Points.Mats[EquipmentListClass.ChestPlates[input - 1].CostType].Amount >= EquipmentListClass.ChestPlates[input - 1].Cost)
                {
                    hunter.MyArmor.ChestPlate = EquipmentListClass.ChestPlates[input - 1];
                }
                else
                {
                    Console.WriteLine("Not enough");
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Enter a vaild number.");
            }
            return hunter;
        }
    }
}
