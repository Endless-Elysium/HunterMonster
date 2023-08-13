using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HunterMonster.Equipment
{
    internal class EquipmentListClass : DefArmor
    {
        static public List<Weapon> weapons = new List<Weapon>()
        {
            new Weapon() {Name = "Broken Sword", Speed = 2, PhysDamage = 1, DarkDamage = 2, Cost = 100, CostType = 0, Id = 0010},
            new Weapon() {Name = "Iron Sword", Speed = 5, PhysDamage = 5, Cost = 1000, CostType = 0, Id = 1010  },
            new Weapon() {Name = "Iron GreatSword", Speed = 3, PhysDamage = 9, Cost = 1700, CostType = 0, Id = 1020  },
            new Weapon() {Name = "DinoBlade", Speed = 6, PhysDamage = 8, Cost = 100, CostType = 1, Id = 1030  },
            new Weapon() {Name = "LargeRaptorBlade", Speed = 5, PhysDamage = 12, Cost = 200, CostType = 2, Id = 1040  },
        };

        static public List<DefArmor> Helmets = new List<DefArmor>()
        {
            new DefArmor {Name = "Broken Helmet", PhysDef = 1, Cost = 50, CostType = 0, Id = 0010  },
            new DefArmor {Name = "Iron Helm", PhysDef = 3, Cost = 300, CostType = 0, Id = 1010 },
            new DefArmor {Name = "Hunter's Helm", PhysDef = 6, FireDef = 5, WaterDef = 5, LeafDef = 5, SpeBonus = -2, HPBonus = 20, Cost = 800, CostType = 0, Id = 1020 },
        };
        static public List<DefArmor> ChestPlates = new List<DefArmor>()
        {
            new DefArmor {Name = "Barely armor", PhysDef = 1, Cost = 80, CostType = 0, Id = 0010, },
            new DefArmor {Name = "Iron Chest", PhysDef = 5,  HPBonus = 10, Cost = 500, CostType = 0, Id = 1010 },
            new DefArmor {Name = "HunterPlate", PhysDef = 12, FireDef = 5, WaterDef = 5, LeafDef = 5, SpeBonus = -2, AtkBonus = 5, Cost = 900, CostType = 0, Id = 1020 },
        };
    }
}
