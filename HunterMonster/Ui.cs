using HunterMonster_Equipment;
using HunterMonster_Combat;
using System;
using System.Collections.Generic;
using System.Drawing;
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
            return Input.ToUpper();
        }

        public static void DrawMainMenu()
        {
            Console.WriteLine("_____");
            Console.WriteLine("_____");

            Console.WriteLine("    1 for PlayerInfo");
            Console.WriteLine("    2 for Hunting");
            Console.WriteLine("    3 for Forging");
        }

        public static void DrawStats(Hunter h)
        {
            Console.WriteLine($"{"MAIN",5}");
            Console.WriteLine($"  HP:{h.HP}");
            Console.WriteLine($"  SPEED:{h.Spe}");
            Console.WriteLine($"  SKILL:{h.Skill}");
            Console.WriteLine();

            Console.WriteLine($"{" EQUIPMENT",6}");
            Console.WriteLine($"  Current WEAPON:{h.MyWeapon.Name}");
            Console.WriteLine($"  Current HELMET:{h.MyArmor.helmet.Name}");
            Console.WriteLine($"  Current CHESTPLATE:{h.MyArmor.chestPlate.Name}");


            Console.WriteLine();
            Console.WriteLine($"{"ATK",4}");
            Console.WriteLine($"  PHYS:{h.PhysDamage}");
            Console.WriteLine($"  WATR:{h.WaterDamage}");
            Console.WriteLine($"  FIRE:{h.FireDamage}");
            Console.WriteLine($"  LEAF:{h.LeafDamage}");
            Console.WriteLine($"  DARK:{h.DarkDamage}");

            Console.WriteLine();
            Console.WriteLine($"{"DEF",4}");
            Console.WriteLine($"  PHYS:{h.PhysDef}");
            Console.WriteLine($"  WATR:{h.WaterDef}");
            Console.WriteLine($"  FIRE:{h.FireDef}");
            Console.WriteLine($"  LEAF:{h.LeafDef}");
            Console.WriteLine();

            Console.WriteLine("----- MATS -----");
            int i = 0;
            foreach (Points p in Points.Mats)
            {
                if (p.Amount > 0)
                {
                    i++;
                    Console.WriteLine($"{p.Name,4}:{p.Amount}");
                }
            }
            if (i < Points.Mats.Count) Console.WriteLine("...");
            Console.WriteLine("----------------");
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
                Console.WriteLine($"{i,7}|{w.Name,16}|{w.Cost,8}{e}|{w.Speed,3}|{w.PhysDamage,4}|{w.WaterDamage,4}|{w.FireDamage,4}|{w.LeafDamage,4}|{w.DarkDamage,4}|");
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
                Console.WriteLine($"{i,7}|{h.Name,16}|{h.Cost,8}{e}|{h.SpeBonus,3}|{h.PhysDef,4}|{h.WaterDef,4}|{h.FireDef,4}|{h.LeafDef,4}|{h.AtkBonus,4}|{h.EleBonus,4}|{h.HPBonus,4}|");
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
                    Console.WriteLine($"{i,7}|{c.Name,16}|{c.Cost,8}{e}|{c.SpeBonus,3}|{c.PhysDef,4}|{c.WaterDef,4}|{c.FireDef,4}|{c.LeafDef,4}|{c.AtkBonus,4}|{c.EleBonus,4}|{c.HPBonus,4}|");
                }
            }
        }


        public static void DrawMonsterList()
        {
            MonsterListClass list = new MonsterListClass();
            Console.WriteLine("-----");
            Console.WriteLine($"{"NUM",7}|{"NAME",16}|{"HP",5}|");
            foreach(Monster m in list.monsters)
            {
                Console.WriteLine($"{list.monsters.IndexOf(m) + 1,7}|{m.Name,16}|{m.HP,5}|");
            }
            list = null;
        }
        public static void DrawMonster(Monster m)
        {
            Console.WriteLine($"Where to attack?",6);

            if (m.Head != null && m.Head.HP > 0 )
            {

                Console.WriteLine($"{"A",4} - {m.Head.Name}");
            }
            if (m.Arms != null && m.Arms.HP > 0)
            {
                Console.WriteLine($"{"B",4} - {m.Arms.Name}");
            }
            if (m.Body != null && m.Body.HP > 0)
            {

                Console.WriteLine($"{"C",4} - {m.Body.Name}");
            }
            if (m.Tail != null && m.Tail.HP > 0)
            {
                Console.WriteLine($"{"D",4} - {m.Tail.Name}");
            }
        }
    }
}
