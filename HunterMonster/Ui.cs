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

        public static int IntPlayerInput()
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
        public static string StringPlayerInput()
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

        public static void DrawWeaponCraft()
        {
            int i = 0;
            Console.WriteLine($"{"WEAPONS",11}");
            Console.WriteLine($"{"NUM",7}|{"NAME",16}|{"COST",9}|{"SPE",3}|{"PHYS",4}|{"WATR",4}|{"FIRE",4}|{"LEAF",4}|{"DARK",4}|");
            foreach (Weapon w in EquipmentListClass.weapons)
            {
                i++;
                string e = (w.CostType == 0) ? "G" : "P";
                Console.WriteLine($"{i,5}- |{w.Name,16}|{w.Cost,8}{e}|{w.Speed,3}|{w.PhysDamage,4}|{w.WaterDamage,4}|{w.FireDamage,4}|{w.LeafDamage,4}|{w.DarkDamage,4}|");
            }
        }
        public static void DrawHelmetCraft()
        {
            int i = 0;
            Console.WriteLine($"{"WEAPONS",11}");
            Console.WriteLine($"{"NUM",7}|{"NAME",16}|{"COST",9}|{"SPE",3}|{"PHYS",4}|{"WATR",4}|{"FIRE",4}|{"LEAF",4}|{"ATK+",4}|{"ELE+",4}|{"HP++",4}|");
            foreach (DefArmor h in EquipmentListClass.Helmets)
            {
                i++;
                string e = (h.CostType == 0) ? "G" : "P";
                Console.WriteLine($"{i,5}- |{h.Name,16}|{h.Cost,8}{e}|{h.SpeBonus,3}|{h.PhysDef,4}|{h.WaterDef,4}|{h.FireDef,4}|{h.LeafDef,4}|{h.AtkBonus,4}|{h.EleBonus,4}|{h.HPBonus,4}|");
            }
        }
        public static void DrawChestPlateCraft()
        {
            {
                int i = 0;
                Console.WriteLine($"{"WEAPONS",11}");
                Console.WriteLine($"{"NUM",7}|{"NAME",16}|{"COST",9}|{"SPE",3}|{"PHYS",4}|{"WATR",4}|{"FIRE",4}|{"LEAF",4}|{"ATK+",4}|{"ELE+",4}|{"HP++",4}|");
                foreach (DefArmor c in EquipmentListClass.ChestPlates)
                {
                    i++;
                    string e = (c.CostType == 0) ? "G" : "P";
                    Console.WriteLine($"{i,5}- |{c.Name,16}|{c.Cost,8}{e}|{c.SpeBonus,3}|{c.PhysDef,4}|{c.WaterDef,4}|{c.FireDef,4}|{c.LeafDef,4}|{c.AtkBonus,4}|{c.EleBonus,4}|{c.HPBonus,4}|");
                }
            }
        }
    }
}
