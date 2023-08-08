using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HunterMonster.Equipment;
namespace HunterMonster
{
    internal class Hunter
    {

        public int HP = 100;
        public int Skill = 1;

        public int PhysDamage = 0;
        public int WaterDamage = 0;
        public int FireDamage = 0;
        public int LeafDamage = 0;
        public int DarkDamage = 0;

        public int PhysDef = 0;
        public int WaterDef = 0;
        public int FireDef = 0;
        public int LeafDef = 0;



        private Weapon _MyWeapon = EquipmentListClass.weapons[0];
        public Weapon Weapon
        {
            get { return _MyWeapon; }
            set
            {
                _MyWeapon = value;
                PhysDamage = _MyWeapon.PhysDamage + _MyArmor.Armoratk;
                WaterDamage = _MyWeapon.WaterDamage + _MyArmor.ArmoreleAtk;
                FireDamage = _MyWeapon.FireDamage + _MyArmor.ArmoreleAtk;
                LeafDamage = _MyWeapon.LeafDamage + _MyArmor.ArmoreleAtk;
                DarkDamage = _MyWeapon.DarkDamage;
            }
        }
        private Armor _MyArmor;
        public Armor MyArmor
        {
            get { return _MyArmor; }
            set
            {
                _MyArmor = value;
                HP = 100 + _MyArmor.Armorhp;
                PhysDef = _MyArmor.ArmorphysDef;
                WaterDef = _MyArmor.ArmorwaterDef;
                FireDef = _MyArmor.ArmorfireDef;
                LeafDef = _MyArmor.ArmorleafDef;
            }
        }
        public Hunter()
        {
            if (MyArmor == null)
            {
                MyArmor = new Armor();
            }
            MyArmor.OnArmorChanged += Update;
        }

        private void Update()
        {
            HP = 100 + _MyArmor.Armorhp;
            PhysDef = _MyArmor.ArmorphysDef;
            WaterDef = _MyArmor.ArmorwaterDef;
            FireDef = _MyArmor.ArmorfireDef;
            LeafDef = _MyArmor.ArmorleafDef;
        }
    }
}
