using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HunterMonster_Combat
{
    delegate void PartAtk();
    internal class MonsterPart
    {
        public int Bonus { get; set; } = 0;
        public string Name { get; set; } = "";
        private int _hp = 0;
        public int HP
        {
            get { return _hp; }
            set
            {
                _hp = value;
            }
        }

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
