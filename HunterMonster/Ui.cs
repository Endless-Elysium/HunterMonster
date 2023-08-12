using HunterMonster.Equipment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HunterMonster
{
    internal class Ui
    {

        static int IntPlayerInput()
        {
            int Input = -1;
            while (Input == -1)
            {
                try
                {
                    Input = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Enter a number");
                    return -1;
                }

            }
            return Input;
        }
        static string StringPlayerInput()
        {
            string Input = "";
            while (Input =="")
            {
                try
                {
                    Input = Console.ReadLine();
                }
                catch (Exception)
                {
                    Console.WriteLine("Enter something");
                    return "";
                }
            }
            return Input;
        }

        public static Weapon DrawWeaponCraft()
        {
            int Input;
            int i = 0;
            Console.WriteLine($"{"WEAPONS",11}");
            Console.WriteLine($"{"NUM",7}|{"NAME",16}|{"COST",9}|{"SPE",3}|{"PHYS",4}|{"WATR",4}|{"FIRE",4}|{"LEAF",4}|{"DARK",4}|");
            foreach (Weapon w in EquipmentListClass.weapons)
            {
                i++;
                string e = (w.CostType == 1) ? "G" : "P";
                Console.WriteLine($"{i,5}- |{w.Name,16}|{w.Cost,8}{e}|{w.Speed,3}|{w.PhysDamage,4}|{w.WaterDamage,4}|{w.FireDamage,4}|{w.LeafDamage,4}|{w.DarkDamage,4}|");
            }
            return EquipmentListClass.weapons[1];
        }
    }
}
