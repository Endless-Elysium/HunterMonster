using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Metrics;
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
        private static int PATKDEFCAL(int ATK, int WATK, int FATK, int LATK, int DATK, int DEF, int WDEF, int FDEF, int LDEF)
        {
            int trueATK = 0;

            if (ATK > 0)
            {
                ATK -= DEF;
                if (ATK < 0) ATK = 1;
                trueATK += ATK;
            }

            if (WATK > 0)
            {
                WATK -= WDEF;
                if (WATK < 0) WATK = 1;
                trueATK += WATK;
            }

            if (FATK > 0)
            {
                FATK -= FDEF;
                if (FATK < 0) FATK = 1;
                trueATK += FATK;
            }

            if (LATK > 0)
            {
                LATK -= LDEF;
                if (LATK < 0) LATK = 1;
                trueATK += LATK;
            }

            
            return trueATK + DATK;
        }

        private static double ATKBONUS(bool a, bool b, bool c, bool d, int damage)
        {
            const int CritGain = 5;
            int E = CritGain;
            if (a)
            {
                E += rng.Next(damage + 1);
                E += CritGain;
            }
            if (b)
            {
                E += rng.Next(damage + 1);
                E += CritGain;
            }
            if (c)
            {
                E += rng.Next(damage + 1);
                E += CritGain;
            }
            if (d)
            {
                E += rng.Next(damage + 1);
                E += CritGain;
            }

            if (E > 50)
            {
                return 50;
            }
            return E;
        }
        private static int MATKDEFCAL (int ATK, int DEF)
        {

            if (ATK == 0) return 0;
            if (ATK - DEF < 0) return 0;
            return ATK - DEF;
        }

        public static (Hunter, Monster) PlayerAttack(Hunter h, Monster m)
        {
            bool HeadAlive = m.Head.HP > 0;
            bool ArmAlive = m.Arms.HP > 0;
            bool BodyAlive = m.Body.HP > 0;
            bool TailAlive = m.Tail.HP > 0;
            double AB = ATKBONUS(!HeadAlive, !ArmAlive, !BodyAlive, !TailAlive, m.RandomDamage + h.Spe / 2);

            int PlayerAtk = PATKDEFCAL(h.PhysDamage, h.WaterDamage, h.FireDamage, h.LeafDef, h.DarkDamage, m.Physdef, m.Waterdef, m.Firedef, m.Leafdef);
            if (h.WeaponType == 2) AB *= 4;
            Console.WriteLine(PlayerAtk);
            PlayerAtk += (int) (PlayerAtk * (AB / 100));
            Console.WriteLine("AB" + PlayerAtk);

            Ui.DrawMonster(m);
            string part = Ui.StringPlayerInput();



            if (HeadAlive && part == "A")
            {
                Console.WriteLine($"You attacked the {m.Head.Name}");
                Console.WriteLine($"{m.Name} took {PlayerAtk}!!");
                m.AtkHead(PlayerAtk);
                if (h.WeaponType == 1) m.AtkHead(Blade2ndATK(PlayerAtk, m.Name));

            } else if (ArmAlive && part == "B")
            {
                Console.WriteLine($"You attacked the {m.Arms.Name}");
                Console.WriteLine($"{m.Name} took {PlayerAtk}!!");
                m.AtkArm(PlayerAtk);
                if (h.WeaponType == 1) m.AtkArm(Blade2ndATK(PlayerAtk, m.Name));
            } else if (BodyAlive && part == "C")
            {
                Console.WriteLine($"You attacked the {m.Body.Name}");
                Console.WriteLine($"{m.Name} took {PlayerAtk}!!");
                m.AtkBody(PlayerAtk);
                if (h.WeaponType == 1) m.AtkBody(Blade2ndATK(PlayerAtk, m.Name));
            } else if (TailAlive && part == "D")
            {
                Console.WriteLine($"You attacked the {m.Tail.Name}");
                Console.WriteLine($"{m.Name} took {PlayerAtk}!!");
                m.AtkTail(PlayerAtk);
                if (h.WeaponType == 1) m.AtkTail(Blade2ndATK(PlayerAtk, m.Name));
            } else
            {
                Console.WriteLine($"You attacked the Monster!");
                Console.WriteLine($"{m.Name} took {PlayerAtk}!!");
                m.HP -= PlayerAtk;
            }

            if (m.Head.HP <= 0 && m.Arms.HP <= 0 && m.Body.HP <= 0 && m.Tail.HP <= 0)
            {
                m.HP = 0;
            }

            return (h, m);
        }


        private static int Blade2ndATK(int ATK, string m)
        {
            if (rng.Next(6) != 5) return 0;


            Console.WriteLine($"Your swift attacks allowed you to strike once more!");
            Console.WriteLine($"{m} took {ATK}!!");

            return ATK;

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

        public static int FireMonsterATK(Monster m, Hunter h)
        {
            int MATK = MATKDEFCAL(m.Fireatk, h.FireDef);
            Console.WriteLine($"{m.Name} attacked you with FIRE DAMAGE for {MATK} damage!!");
            h.HP -= MATK;



            return h.HP;
        }
        public static int LeafMonsterATK(Monster m, Hunter h)
        {
            int MATK = MATKDEFCAL(m.Leafatk, h.LeafDef);
            Console.WriteLine($"{m.Name} attacked you with LEAF DAMAGE for {MATK} damage!!");
            h.HP -= MATK;



            return h.HP;
        }




    }
}
