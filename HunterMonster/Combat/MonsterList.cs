using HunterMonster;
using HunterMonster_Equipment;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HunterMonster_Combat
{
    internal class MonsterListClass
    {

        public List<Monster> monsters = new()
        {
            new Monster
            {
                // Main
                Name = "DinoRaptor",
                HP = 4,
                RandomDamage = 3,

                // Rewards
                Drops = new MonsterDrops
                {
                    GoldReward =
                    {
                        Amount = 100,
                    },
                    Reward1 = new Points
                    {
                        Name = "DinoMat",
                        Amount = 30,
                        Id = 1,
                    },
                },

                // Parts
                Head = new MonsterPart
                {
                    Name = "Head",
                    HP = 8,
                    Speed = 1,
                    Physatk = 6,
                    Bonus = 18,
                },
                Body = new MonsterPart
                {
                    Name = "Body",
                    HP = 12,
                    Speed = 4,
                    Physatk = 1,
                    Physdef = 2,
                    Waterdef = 4,
                    Firedef = -2,
                    Leafdef = 2,
                    Bonus = 12,
                },


            }, // DinoRaptor

            new Monster
            {
                // Main
                Name = "RaptorSaurus",
                HP = 8,
                RandomDamage = 5,

                // Rewards
                Drops = new MonsterDrops
                {
                    GoldReward =
                    {
                        Amount = 250,
                    },
                    Reward1 = new Points
                    {
                        Name = "SaurusMat",
                        Amount = 60,
                        Id = 2,
                    },
                    Reward2 = new Points
                    {
                        Name = "DinoMat",
                        Amount = 40,
                        Id = 1,
                    }
                },

                // Parts
                Head = new MonsterPart
                {
                    Name = "Head",
                    HP = 10,
                    Speed = 2,
                    Wateratk = 12,
                    Physatk = 8,
                    Bonus = 20,
                },
                Body = new MonsterPart
                {
                    Name = "Body",
                    HP = 25,
                    Speed = 5,
                    Physatk = 2,
                    Physdef = 4,
                    Waterdef = 4,
                    Firedef = -3,
                    Bonus = 18,
                },
                Tail = new MonsterPart
                {
                    Name = "Tail",
                    HP = 8,
                    Speed = 1,
                    Physatk = 2,
                    Bonus = 14,
                },
        }, // RaptorSaurus

            new Monster
            {

                // Main
                Name = "Hazelferna",
                HP = 18,
                RandomDamage = 7,

                // Rewards
                Drops = new MonsterDrops
                {
                    GoldReward =
                    {
                        Amount = 400,
                    },
                    Reward1 = new Points
                    {
                        Name = "HazelMat",
                        Amount = 40,
                        Id = 1,
                    },
                },

                Head = new MonsterPart
                {
                    Name = "Face",
                    HP = 35,
                    Physatk = 5,
                    Physdef = 5,
                    Leafatk = 5,
                    Leafdef = 10,
                    Firedef = -5,
                    Bonus = 18,
                },
                Arms = new MonsterPart
                {
                    Name = "Vines",
                    HP = 20,
                    Physatk = 8,
                    Leafatk = 10,
                    Leafdef = 5,
                    Firedef = -8,
                    Bonus = 10,
                },
                Body = new MonsterPart
                {
                    Name = "Base",
                    HP = 50,
                    Leafatk = 5,
                    Leafdef = 10,
                    Firedef = -10,
                    Bonus = 20,
                }
            },
        };

    }
}
