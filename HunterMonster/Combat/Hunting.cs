using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using HunterMonster;
using HunterMonster_Equipment;
using static HunterMonster_Combat.MonsterBrain;

namespace HunterMonster_Combat
{
    internal class Hunting
    {
        private static Monster ?Target;

        private static Hunter ?Player;

        public static void Begin(int index, Hunter hunter)
        {
            int Id = index - 1;
            MonsterListClass mList = new MonsterListClass();
            SetValues(mList.monsters[Id], hunter);
            while (Target.HP > 0)
            {
                Console.WriteLine($"HP: {Player.HP}");
                if (Target.Speed > Player.Spe)
                {
                    MonsterBrain.Action(Id, Target);
                    if (Player.HP <= 0)
                    {
                        break;
                    }
                    PATK();
                } else
                {
                    PATK();
                    if (Target.HP <= 0)
                    {
                        break;
                    }
                    MonsterBrain.Action(Id, Target);
                    if (Player.HP <= 0)
                    {
                        break;
                    }
                }
            }
            mList = null;
            Unsub();
            if (Player.HP > 0)
            {
                Console.WriteLine("You win!");
                Points.GetReward(Target, Id);
            } else
            {
                Console.WriteLine("You lost...");
            }

        }


        private static void PATK()
        {
            var c = BattleAction.PlayerAttack(Player, Target);
            Player = c.Item1;
            Target = c.Item2;
        }

        private static void BasicMonsterATK()
        {
            Player.HP = BattleAction.PhysMonsterATK(Target, Player);
        }
        private static void WaterBasicMonsterATK()
        {
            Player.HP = BattleAction.WaterMonsterATK(Target, Player);
        }
        private static void SetValues(Monster monster, Hunter hunter)
        {
            Target = monster;
            Player = hunter;

            MonsterBrain.OnBasicATK += BasicMonsterATK;
            MonsterBrain.OnWaterATK += WaterBasicMonsterATK;
        }
        
        private static void Unsub()
        {
            MonsterBrain.OnBasicATK -= BasicMonsterATK;
            MonsterBrain.OnWaterATK -= WaterBasicMonsterATK;
        }

        
    }
}
