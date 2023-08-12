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
            new Weapon() {Name = "Broken Sword", Speed = 2, PhysDamage = 1, DarkDamage = 2, Cost = 100, CostType = 1, id = 0010},
            new Weapon() {Name = "Iron Sword", Speed = 5, PhysDamage = 5, Cost = 1000, CostType = 1, id = 1010  },
            new Weapon() {Name = "Iron GreatSword", Speed = 3, PhysDamage = 9, Cost = 1700, CostType = 1, id = 1020  },
        };

        static public List<Helmet> Helmets = new List<Helmet>()
        {
            new Helmet {Name = "Broken Helmet", PhysDef = 1, id = 0010 },
            new Helmet {Name = "Iron Helm", PhysDef = 3, id = 1010 },
            new Helmet {Name = "Hunter's Helm", PhysDef = 6, FireDef = 5, WaterDef = 5, LeafDef = 5, SpeBonus = -1, HPBonus = 20, id = 1020 },
        };
        static public List<ChestPlate> ChestPlates = new List<ChestPlate>()
        {
            new ChestPlate {Name = "Barely armor", PhysDef = 1, id = 0010, },
            new ChestPlate {Name = "Iron Chest", PhysDef = 5,  HPBonus = 10, id = 1010 },
            new ChestPlate {Name = "HunterPlate", PhysDef = 12, FireDef = 5, WaterDef = 5, LeafDef = 5, SpeBonus = -2, AtkBonus = 5, id = 1020 },
        };
        
    }
}
