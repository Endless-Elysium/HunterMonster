using HunterMonster.Equipment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HunterMonster
{
    internal class Forge
    {
       public static Hunter ForgeEquipment(Hunter hunter)
        {
            Console.WriteLine("What would you like to forge?");
            Console.WriteLine("1 for Weapons");
            Console.WriteLine("2 for Helmets");
            Console.WriteLine("3 for Chestplates");
            int input = Ui.IntPlayerInput();
            Console.WriteLine("    G for gold");
            Console.WriteLine("    P for monster mats");
            if (input == 1)
            {
                hunter = ForgeWeapon(hunter);

            } else if (input == 2)
            {
                hunter = ForgeHelmet(hunter);
            } else if (input == 3)
            {
                hunter = ForgeChestPlate(hunter);
            } else
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
            if (Points.points[EquipmentListClass.weapons[input - 1].CostType].Amount >= EquipmentListClass.weapons[input - 1].Cost)
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
            try
            {
                if (Points.points[EquipmentListClass.Helmets[input - 1].CostType].Amount >= EquipmentListClass.Helmets[input - 1].Cost)
                {
                    hunter.MyArmor.helmet = EquipmentListClass.Helmets[input - 1];
                }
                else
                {
                    Console.WriteLine("Not enough");
                }
            } catch (Exception e)
            {
                Console.WriteLine("Enter a vaild number.");
            }

            return hunter;
        }
        private static Hunter ForgeChestPlate(Hunter hunter)
        {
            int input;
            Ui.DrawChestPlateCraft();
            input = Ui.IntPlayerInput();
            try
            {
                if (Points.points[EquipmentListClass.ChestPlates[input - 1].CostType].Amount >= EquipmentListClass.ChestPlates[input - 1].Cost)
                {
                    hunter.MyArmor.chestPlate = EquipmentListClass.ChestPlates[input - 1];
                }
                else
                {
                    Console.WriteLine("Not enough");
                }
            } catch (Exception e)
            {
                Console.WriteLine("Enter a vaild number.");
            }

            return hunter;
        }
    }
}
