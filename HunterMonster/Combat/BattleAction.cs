using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HunterMonster;
using HunterMonster_Equipment;

namespace HunterMonster_Combat
{
    internal class BattleAction
    {
        static Random rng = new Random();
        private static int PATKDEFCAL(int ATK, int DEF)
        {
            if (ATK == 0) return 0;
            if (ATK - DEF <= 0) return 1;
            return ATK - DEF;
        }

        private static int ATKBONUS(bool a, bool b, bool c, bool d, int damage)
        {
            int E = 0;
            if (a) E += rng.Next(damage + 1);
            if (b) E += rng.Next(damage + 1);
            if (c) E += rng.Next(damage + 1);
            if (d) E += rng.Next(damage + 1);

            return E;
        }
        private static int MATKDEFCAL (int ATK, int DEF)
        {

            if (ATK == 0) return 0;
            if (ATK - DEF < 0) return 0;
            return ATK - DEF;
        }

        public static (Hunter, Monster) PlayerAttack(Hunter hunter, Monster m)
        {
            bool HeadAlive = m.Head.HP > 0; 
            bool ArmAlive = m.Arms.HP > 0;
            bool BodyAlive = m.Body.HP > 0;
            bool TailAlive = m.Tail.HP > 0;
            int AB = ATKBONUS(!HeadAlive, !ArmAlive, !BodyAlive, !TailAlive, m.RandomDamage);

            int PlayerAtk = PATKDEFCAL(hunter.PhysDamage + rng.Next(AB + 1), m.Physdef);
            Console.WriteLine(PlayerAtk);
            int PlayerWaterAtk = PATKDEFCAL(hunter.WaterDamage, m.Waterdef);
            int PlayerFireAtk = PATKDEFCAL(hunter.FireDamage, m.Firedef);
            int PlayerLeafAtk = PATKDEFCAL(hunter.LeafDamage, m.Leafdef);


            Ui.DrawMonster(m);
            string part = Ui.StringPlayerInput();


            if (HeadAlive && part == "A")
            {
                Console.WriteLine($"You attacked the {m.Head.Name}");
                Console.WriteLine($"{m.Name} took {PlayerAtk + PlayerWaterAtk + PlayerFireAtk + PlayerLeafAtk + hunter.DarkDamage}!!");
                m.AtkHead(PlayerAtk + PlayerWaterAtk + PlayerFireAtk + PlayerLeafAtk + hunter.DarkDamage);
            } else if (ArmAlive && part == "B")
            {
                Console.WriteLine($"You attacked the {m.Arms.Name}");
                Console.WriteLine($"{m.Name} took {PlayerAtk + PlayerWaterAtk + PlayerFireAtk + PlayerLeafAtk + hunter.DarkDamage}!!");
                m.AtkArm(PlayerAtk + PlayerWaterAtk + PlayerFireAtk + PlayerLeafAtk + hunter.DarkDamage);
            } else if (BodyAlive && part == "C")
            {
                Console.WriteLine($"You attacked the {m.Body.Name}");
                Console.WriteLine($"{m.Name} took {PlayerAtk + PlayerWaterAtk + PlayerFireAtk + PlayerLeafAtk + hunter.DarkDamage}!!");
                m.AtkBody(PlayerAtk + PlayerWaterAtk + PlayerFireAtk + PlayerLeafAtk + hunter.DarkDamage);
            } else if (TailAlive && part == "D")
            {
                Console.WriteLine($"You attacked the {m.Tail.Name}");
                Console.WriteLine($"{m.Name} took {PlayerAtk + PlayerWaterAtk + PlayerFireAtk + PlayerLeafAtk + hunter.DarkDamage}!!");
                m.AtkTail(PlayerAtk + PlayerWaterAtk + PlayerFireAtk + PlayerLeafAtk + hunter.DarkDamage);
            } else
            {
                Console.WriteLine($"You attacked the Monster!");
                Console.WriteLine($"{m.Name} took {PlayerAtk + PlayerWaterAtk + PlayerFireAtk + PlayerLeafAtk + hunter.DarkDamage}!!");
                m.HP -= PlayerAtk + PlayerWaterAtk + PlayerFireAtk + PlayerLeafAtk + hunter.DarkDamage;
            }

            if (m.Head.HP <= 0 && m.Arms.HP <= 0 && m.Body.HP <= 0 && m.Tail.HP <= 0)
            {
                m.HP = 0;
            }

            return (hunter, m);
        }

        public static int PhysMonsterATK(Monster m, Hunter h)
        {
            int MATK = MATKDEFCAL(m.Physatk, h.PhysDef);
            Console.WriteLine($"{m.Name} attacked you for {MATK} damage!!");
            h.HP -= MATK;



            return h.HP;
        }

        public static int WaterMonsterATK(Monster m, Hunter h)
        {
            int MATK = MATKDEFCAL(m.Wateratk, h.WaterDef);
            Console.WriteLine($"{m.Name} attacked you with WATER DAMAGE for {MATK} damage!!");
            h.HP -= MATK;



            return h.HP;
        }





    }
}
