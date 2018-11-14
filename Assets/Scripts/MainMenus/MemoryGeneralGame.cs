﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class MemoryGeneralGame {

    public List<Unit> unitsInRoster;
    public List<Unit> unitsInParty;
    public EnemiesInMap enemiesInMaps;
    public AreaGroupHolder heldGameType;
    public EquipmentOwned itemsOwned;
    public ShopWares shopWares;
    public int gold;
    public LevelCompletion levelCompletion;
    public LevelHolder levelHolder;
    public List<CurrentLevel> currentLevels;
    public CurrentLevel currentLevel;
    public string currentLevelID;
    public string doISave;
	public MemoryGeneralGame()
    {
        unitsInRoster = new List<Unit>();
        unitsInParty = new List<Unit>();
        itemsOwned = new EquipmentOwned();
        shopWares = new ShopWares();
        enemiesInMaps = new EnemiesInMap();
        levelHolder = new LevelHolder();
        levelCompletion = new LevelCompletion();
        currentLevels = new List<CurrentLevel>();
        heldGameType = new AreaGroupHolder();
        currentLevelID = "";
        doISave = "";
        gold = 0;
    }
}
