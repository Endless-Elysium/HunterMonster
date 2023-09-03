using HunterMonster.Combat;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HunterMonster_Combat
{
    delegate void PartAtk();
    internal class MonsterPart : MonsterBase
    {
        public int Bonus { get; set; } = 0;


    }
}
