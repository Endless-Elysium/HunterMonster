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
            new Weapon() {Name = "Iron Sword", Speed = 5, PhysDamage = 2, id = 1010  },
            new Weapon() {Name = "Iron GreatSword", Speed = 3, PhysDamage = 9, id = 2010  },
        };

        static public List<Helmet> Helmets = new List<Helmet>()
        {
            new Helmet {Name = "Broken Helmet", PhysDef = 1, id = 0010 },
            new Helmet {Name = "Iron Helm", PhysDef = 3, id = 1010 },
        };
        static public List<ChestPlate> ChestPlates = new List<ChestPlate>()
        {
            new ChestPlate {Name = "Barely armor", PhysDef = 1, id = 0020, },
            new ChestPlate {Name = "Iron Chest", PhysDef = 5, id = 1020, HPBonus = 10 },
        };
        
    }
}
