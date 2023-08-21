using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HunterMonster_Combat
{
    internal class MonsterListClass
    {

        public List<Monster> monsters = new List<Monster>()
        {
            new Monster
            {
                Name = "DinoRaptor",
                HP = 4,
                RandomDamage = 3,
                Reward = 10,
                Head = new MonsterPart
                {
                    Name = "Head",
                    HP = 8,
                    Speed = 1,
                    Physatk = 6,
                    Bonus = 15,
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
                    Bonus = 8,
                },


            }, // DinoRaptor

            new Monster
            {
                Name = "RaptorSaurus",
                HP = 8,
                RandomDamage = 5,
                Reward = 15,
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
                    Bonus = 12,
                },
                Tail = new MonsterPart
                {
                    Name = "Tail",
                    HP = 8,
                    Speed = 1,
                    Physatk = 2,
                    Bonus = 10,
                },
        } // RaptorSaurus
        };

    }
}
