﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HunterMonster.Equipment
{
    internal class DefArmor
    {
        int _physDef = 0;
        int _waterDef = 0;
        int _fireDef = 0;
        int _leafDef = 0;
        int _HPBonus = 0;
        int _atkBonus = 0;
        int _eleBonus = 0;

        public int PhysDef { get { return _physDef; } init { _physDef = value; } }
        public int WaterDef { get { return _waterDef; } init { _waterDef = value; } }
        public int FireDef { get { return _fireDef; } init { _fireDef = value; } }
        public int LeafDef { get { return _leafDef; } init { _leafDef = value; } }
        public int HPBonus { get { return _HPBonus; } init { _HPBonus = value; } }
        public int AtkBonus { get { return _atkBonus; } init { _atkBonus = value; } }
        public int EleBonus { get { return _eleBonus; } init { _eleBonus = value; } }

    }
}