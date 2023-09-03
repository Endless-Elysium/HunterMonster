using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HunterMonster;

namespace HunterMonster_Combat
{
    public delegate void BasicATK();
    public delegate void BasicWaterATK();
    public delegate void BasicFireATK();
    public delegate void BasicLeafATK();
    internal class MonsterBrain
    {
        public static event BasicATK OnBasicATK;
        public static event BasicWaterATK OnWaterATK;
        public static event BasicFireATK OnFireATK;
        public static event BasicLeafATK OnLeafATK;
        private static Monster m;
        private static Random rng = new Random();

        public static void Action(int Id, Monster monster)
        {
            m = monster;
            switch (Id)
            {
                case 0:
                    DinoRaptorATK();
                    break;
                case 1:
                    RaptorSaurusATK();
                    break;
                case 2:
                    HazelATK();

                    break;
                case 3:

                    break;
            }
        }

        private static void DinoRaptorATK()
        {
            MonsterBrain.OnBasicATK?.Invoke();
        }

        private static void RaptorSaurusATK()
        {
            if (rng.Next(4) == 3 && m.Head.HP > 0)
            {
                MonsterBrain.OnWaterATK?.Invoke();
            } else
            {
                MonsterBrain.OnBasicATK?.Invoke();
            }
        }

        private static void HazelATK()
        {
            int r = rng.Next(3);
            Console.WriteLine(r);
            if (r == 1 && m.Arms.HP > 0)
            {
                MonsterBrain.OnLeafATK?.Invoke();
            } else
            {
                MonsterBrain.OnBasicATK?.Invoke();
            }
            
            if (r == 1 && m.Firedef > -20)
            {
                MonsterBrain.OnFireATK?.Invoke();
            } else if (m.Firedef > -20)
            {
                Console.WriteLine("Hazelfern is burning");
                return;
            }
            

        }







    }
}
