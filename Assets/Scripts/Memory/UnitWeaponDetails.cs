﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class UnitWeaponDetails {

    public string name;
    public int might;
    public int weight;
    public int hitrate;
    public float critrate;
    public int critchance;
    public int range;
    public bool magic;
    public bool physical;
    public string unlocks;
    public List<string> moreUnlocks;
    public string type;
    public int rank;
    public int xp;
    public List<UnitUniqueWeaponXp> uniqueWeaponXps;
    public UnitWeaponEffects effects;
    public UnitWeaponDetails()
    {
        name = "";
        might = 0;
        weight = 0;
        hitrate = 0;
        critrate = 0;
        critchance = 0;
        magic = false;
        physical = false;
        type = "";
        rank = 0;
        xp = 0;
        moreUnlocks = new List<string>();
        uniqueWeaponXps = new List<UnitUniqueWeaponXp>();
        effects = new UnitWeaponEffects();
    }
}
