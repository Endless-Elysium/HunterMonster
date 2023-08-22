using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HunterMonster_Equipment;

namespace HunterMonster
{
    internal class MonsterDrops
    {


        public Points GoldReward { get; set; }

        public Points? Reward1 { get; set; }
        public Points? Reward2 { get; set; }
        public Points? Reward3 { get; set; }


        public MonsterDrops()
        {
            GoldReward = new Points()
            {
                Name = "Gold",
                Amount = 0,
                Id = 0,
            };
        }
    }
}
