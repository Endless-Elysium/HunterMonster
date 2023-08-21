using HunterMonster_Combat;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HunterMonster_Equipment
{
    internal class Points
    {
        public int Amount = 0;
        public string Name;

        

        public static readonly List<Points> Mats = new List<Points>()
        {
            new Points
            {
                Name = "Gold",
                Amount = 1000,
            },
            new Points
            {
                Name = "DinoMat",
            },
            new Points
            {
                Name = "SaurusMat",
            },
        };

        public static void GetReward(Monster m, int Id)
        {
            MonsterListClass mList = new MonsterListClass();


            Points.Mats[Id + 1].Amount += m.Reward;
            Console.WriteLine($"Got {m.Reward}MATS({m.Name}:{Points.Mats[Id + 1].Amount})");
            Console.WriteLine($"Got {m.Reward * 4}Gold({"Gold"}:{Points.Mats[0].Amount}))");
            switch (Id)
            {
                case 0:
                    break; 
                case 1:
                    Points.Mats[1].Amount += m.Reward * 2;
                    Console.WriteLine($"Got {m.Reward * 2}MATS({mList.monsters[0].Name}:{Points.Mats[1].Amount})");
                    break;

                default:
                    break;
            }
        }

    }
}
