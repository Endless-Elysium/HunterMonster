using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HunterMonster.Combat
{
    internal class MonsterBase
    {
        public string Name { get; set; } = "";
        public int HP { get; set; }
        public int Speed { get; set; } = 0;

        public int Physatk { get; set; } = 0;
        public int Wateratk { get; set; } = 0;
        public int Fireatk { get; set; } = 0;
        public int Leafatk { get; set; } = 0;
        public int Darkatk { get; set; } = 0;

        public int Physdef { get; set; } = 0;
        public int Waterdef { get; set; } = 0;
        public int Firedef { get; set; } = 0;
        public int Leafdef { get; set; } = 0;
    }
}
