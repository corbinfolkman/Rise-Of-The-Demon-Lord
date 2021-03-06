﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class EquipmentOwned {

    public List<UnitWeapon> weapons;
    public List<UnitAssessory> assessories;
    public List<ItemHolder> items;
    public EquipmentOwned()
    {
        weapons = new List<UnitWeapon>();
        assessories = new List<UnitAssessory>();
        items = new List<ItemHolder>();
    }
}
