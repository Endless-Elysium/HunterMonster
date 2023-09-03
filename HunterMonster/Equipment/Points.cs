using HunterMonster;
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
        public string Name = "None";
        public int Id { get; set; } = -1;
        

        public static readonly List<Points> Mats = new()
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
            new Points
            {
                Name = "HazelMat"
            },
        };

        public static void GetReward(Monster m)
        {
            Points.Mats[0].Amount += m.Drops.GoldReward.Amount;
            if (m.Drops.Reward1 != null) Points.Mats[m.Drops.Reward1.Id].Amount += m.Drops.Reward1.Amount;
            if (m.Drops.Reward2 != null) Points.Mats[m.Drops.Reward2.Id].Amount += m.Drops.Reward2.Amount;
            if (m.Drops.Reward3 != null) Points.Mats[m.Drops.Reward3.Id].Amount += m.Drops.Reward3.Amount;
            Ui.DrawReward(m);

        }

    }
}
