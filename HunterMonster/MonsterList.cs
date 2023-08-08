using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HunterMonster
{
    internal class MonsterListClass
    {

        public List<Monster> monsters = new List<Monster>()
        {
            new Monster
            {
                Name = "DinoRaptor",
                Reward = 10,
                Head = new MonsterPart
                {
                    Name = "Head",
                    HP = 8,
                    Speed = 1,
                    Physatk = 6,
                    Bonus = 15,
                },
                Arms = new MonsterPart
                {

                },
                Body = new MonsterPart
                {
                    Name = "Head",
                    HP = 12,
                    Speed = 4,
                    Physatk = 1,
                    Physdef = 2,
                    Waterdef = 4,
                    Firedef = -2,
                    Leafdef = 2,
                    Bonus = 8,
                },
                Tail = new MonsterPart
                {

                },
                
            }
        };
    }
}
