﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class MemoryGeneralGame {

    public List<Unit> unitsInRoster;
    public List<Unit> unitsInParty;
    public EnemiesInMap enemiesInMaps;
    public EquipmentOwned itemsOwned;
    public ShopWares shopWares;
    public int gold;
    public LevelCompletion levelCompletion;
    public List<CurrentLevel> currentLevels;
    public string currentLevelID;
	public MemoryGeneralGame()
    {
        unitsInRoster = new List<Unit>();
        unitsInParty = new List<Unit>();
        itemsOwned = new EquipmentOwned();
        shopWares = new ShopWares();
        enemiesInMaps = new EnemiesInMap();
        levelCompletion = new LevelCompletion();
        currentLevels = new List<CurrentLevel>();
        currentLevelID = "";
        gold = 0;
    }
}
