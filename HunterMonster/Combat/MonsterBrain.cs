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
    internal class MonsterBrain
    {
        public static event BasicATK OnBasicATK;
        public static event BasicWaterATK OnWaterATK;
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









    }
}
