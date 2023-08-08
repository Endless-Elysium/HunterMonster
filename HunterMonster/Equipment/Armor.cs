using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HunterMonster.Equipment
{
    delegate void ArmorChange();
    internal class Armor
    {
        public event ArmorChange OnArmorChanged;
        public int ArmorphysDef { get; protected set; }
        public int ArmorwaterDef { get; protected set; }
        public int ArmorfireDef { get; protected set; }
        public int ArmorleafDef { get; protected set; }
        public int Armorhp { get; protected set; }
        public int Armoratk { get; protected set; }
        public int ArmoreleAtk { get; protected set; }

        private Helmet _Myhelmet;
        public Helmet helmet 
        { 
            get { return _Myhelmet; }
            set 
            { 
                _Myhelmet = value;
                Update();
            }
        }
        private ChestPlate _Mychestplate;
        public ChestPlate chestPlate
        {
            get { return _Mychestplate; }
            set
            {
                _Mychestplate = value;
                Update();
            }
        }
        private void Update()
        {
            ArmorphysDef = _Myhelmet.PhysDef + _Mychestplate.PhysDef;
            ArmorwaterDef = _Myhelmet.WaterDef + _Mychestplate.WaterDef;
            ArmorfireDef = _Myhelmet.FireDef + _Mychestplate.FireDef;
            ArmorleafDef = _Myhelmet.LeafDef + _Mychestplate.LeafDef;
            Armorhp = _Myhelmet.HPBonus + _Mychestplate.HPBonus;
            Armoratk = _Myhelmet.AtkBonus + _Mychestplate.AtkBonus;
            ArmoreleAtk = _Myhelmet.EleBonus + _Mychestplate.EleBonus;
            OnArmorChanged?.Invoke();
        }
        public Armor()
        {
            _Myhelmet = EquipmentListClass.Helmets[0];
            _Mychestplate = EquipmentListClass.ChestPlates[0];
            Update();
        }
    }
}
