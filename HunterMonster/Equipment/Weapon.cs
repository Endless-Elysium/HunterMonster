using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HunterMonster.Equipment
{
    internal class Weapon
    {
        public string Name { get; init; } = "";

        public int Cost { get; init; }
        public int CostType { get; init; }
        public int Id { get; init; }
        public int Speed { get; init; }
        public int PhysDamage { get; init; } = 0;
        public int WaterDamage { get; init; } = 0;
        public int FireDamage { get; init; } = 0;
        public int LeafDamage { get; init; } = 0;
        public int DarkDamage { get; init; } = 0;








    }
}
