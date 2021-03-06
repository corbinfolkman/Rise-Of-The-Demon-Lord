﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelUp : MonoBehaviour {

    public static void LevelUpNow()
    {
        UnitHumanClass hum = CurrentGame.game.memoryGeneral.humanClassProgress;
        UnitViraClass vira = CurrentGame.game.memoryGeneral.viraClassProgress;
        UnitImpClass imp = CurrentGame.game.memoryGeneral.impClassProgress;

        foreach (Unit u in CurrentGame.game.memoryGeneral.unitsInParty)
        {
            if (hum.warrior.name == u.unitClass.main.mainClass) CurrentGame.game.memoryGeneral.humanClassProgress.warrior.present = true;
            else if (hum.mage.name == u.unitClass.main.mainClass) CurrentGame.game.memoryGeneral.humanClassProgress.mage.present = true;
            else if (hum.priest.name == u.unitClass.main.mainClass) CurrentGame.game.memoryGeneral.humanClassProgress.priest.present = true;
            else if (hum.rogue.name == u.unitClass.main.mainClass) CurrentGame.game.memoryGeneral.humanClassProgress.rogue.present = true;
            else if (hum.cavalier.name == u.unitClass.main.mainClass) CurrentGame.game.memoryGeneral.humanClassProgress.cavalier.present = true;       
            else if (hum.archer.name == u.unitClass.main.mainClass) CurrentGame.game.memoryGeneral.humanClassProgress.archer.present = true;
            else if (hum.bard.name == u.unitClass.main.mainClass) CurrentGame.game.memoryGeneral.humanClassProgress.bard.present = true;
            else if (hum.knight.name == u.unitClass.main.mainClass) CurrentGame.game.memoryGeneral.humanClassProgress.knight.present = true;
            else if (hum.paladin.name == u.unitClass.main.mainClass) CurrentGame.game.memoryGeneral.humanClassProgress.paladin.present = true;
            else if (hum.sniper.name == u.unitClass.main.mainClass) CurrentGame.game.memoryGeneral.humanClassProgress.sniper.present = true;
            else if (hum.assassin.name == u.unitClass.main.mainClass) CurrentGame.game.memoryGeneral.humanClassProgress.assassin.present = true;
            else if (hum.charger.name == u.unitClass.main.mainClass) CurrentGame.game.memoryGeneral.humanClassProgress.charger.present = true;

            /* else if (vira.chronos.name == u.unitClass.main.mainClass) CurrentGame.game.memoryGeneral.viraClassProgress.chronos.present = true;
             else if (vira.alchemist.name == u.unitClass.main.mainClass) CurrentGame.game.memoryGeneral.viraClassProgress.alchemist.present = true;
             else if (vira.geomancer.name == u.unitClass.main.mainClass) CurrentGame.game.memoryGeneral.viraClassProgress.geomancer.present = true;
             else if (vira.kensai.name == u.unitClass.main.mainClass) CurrentGame.game.memoryGeneral.viraClassProgress.kensai.present = true;
             else if (vira.onmiyoji.name == u.unitClass.main.mainClass) CurrentGame.game.memoryGeneral.viraClassProgress.onmiyoji.present = true;
             else if (vira.wardancer.name == u.unitClass.main.mainClass) CurrentGame.game.memoryGeneral.viraClassProgress.wardancer.present = true;*/

            else if (imp.dread.name == u.unitClass.main.mainClass) CurrentGame.game.memoryGeneral.impClassProgress.dread.present = true;
            else if (imp.fusilier.name == u.unitClass.main.mainClass) CurrentGame.game.memoryGeneral.impClassProgress.fusilier.present = true;
            else if (imp.duelist.name == u.unitClass.main.mainClass) CurrentGame.game.memoryGeneral.impClassProgress.duelist.present = true;
            else if (imp.shrike.name == u.unitClass.main.mainClass) CurrentGame.game.memoryGeneral.impClassProgress.shrike.present = true;
            else if (imp.swashbuckler.name == u.unitClass.main.mainClass) CurrentGame.game.memoryGeneral.impClassProgress.swashbuckler.present = true;
            else if (imp.shadow.name == u.unitClass.main.mainClass) CurrentGame.game.memoryGeneral.impClassProgress.shadow.present = true;
            else if (imp.cannoneer.name == u.unitClass.main.mainClass) CurrentGame.game.memoryGeneral.impClassProgress.cannoneer.present = true;
            else if (imp.darkknight.name == u.unitClass.main.mainClass) CurrentGame.game.memoryGeneral.impClassProgress.darkknight.present = true;
            else if (imp.nightblade.name == u.unitClass.main.mainClass) CurrentGame.game.memoryGeneral.impClassProgress.nightblade.present = true;
            else if (imp.demonRider.name == u.unitClass.main.mainClass) CurrentGame.game.memoryGeneral.impClassProgress.demonRider.present = true;
        }

        MapRewards rewards = GameObject.FindObjectOfType<MapRewards>();
        rewards.unitXp = CurrentGame.game.memoryGeneral.currentLevel.xpReward;
        rewards.weaponXP = CurrentGame.game.memoryGeneral.currentLevel.xpReward;
        int levelUP = 100;
        int pLevelUp = 200;

        if (CurrentGame.game.memoryGeneral.humanClassProgress.warrior.present == true)
        {        
            int totalGain = 0;
            int powerGain = 0;
            int reduce = 0;
            reduce = CurrentGame.game.memoryGeneral.humanClassProgress.warrior.powerLevel - CurrentGame.game.memoryGeneral.currentLevel.powerRanking;
            if (reduce < 1) reduce = 1;
            totalGain = CurrentGame.game.memoryGeneral.humanClassProgress.warrior.xp + (rewards.unitXp / reduce);
            powerGain = totalGain + CurrentGame.game.memoryGeneral.humanClassProgress.warrior.pxp;
            if (totalGain >= levelUP)
            {
                if (powerGain >= pLevelUp)
                {
                    CurrentGame.game.memoryGeneral.humanClassProgress.warrior.pxp = 0;
                    CurrentGame.game.memoryGeneral.humanClassProgress.warrior.powerLevel += 1;
                    CurrentGame.game.memoryGeneral.humanClassProgress.warrior.xp = 0;
                }
                else
                {
                    CurrentGame.game.memoryGeneral.humanClassProgress.warrior.xp = 0;
                    CurrentGame.game.memoryGeneral.humanClassProgress.warrior.pxp = powerGain;
                }

                WarriorLoader.LevelUpClass();
            }
            else
            {
                if (powerGain >= pLevelUp)
                {
                    CurrentGame.game.memoryGeneral.humanClassProgress.warrior.pxp = 0;
                    CurrentGame.game.memoryGeneral.humanClassProgress.warrior.powerLevel += 1;
                    CurrentGame.game.memoryGeneral.humanClassProgress.warrior.xp = totalGain;
                }
                else
                {
                    CurrentGame.game.memoryGeneral.humanClassProgress.warrior.pxp = powerGain;
                    CurrentGame.game.memoryGeneral.humanClassProgress.warrior.xp = totalGain;
                }
            }
        }
        if (CurrentGame.game.memoryGeneral.humanClassProgress.mage.present == true)
        {
          
            int totalGain = 0;
            int powerGain = 0;
            int reduce = 0;
            reduce = CurrentGame.game.memoryGeneral.humanClassProgress.mage.powerLevel - CurrentGame.game.memoryGeneral.currentLevel.powerRanking;
            if (reduce < 1) reduce = 1;
            totalGain = CurrentGame.game.memoryGeneral.humanClassProgress.mage.xp + (rewards.unitXp / reduce);
            powerGain = totalGain + CurrentGame.game.memoryGeneral.humanClassProgress.mage.pxp;
            if (totalGain >= levelUP)
            {
                if (powerGain >= pLevelUp)
                {
                    CurrentGame.game.memoryGeneral.humanClassProgress.mage.pxp = 0;
                    CurrentGame.game.memoryGeneral.humanClassProgress.mage.powerLevel += 1;
                    CurrentGame.game.memoryGeneral.humanClassProgress.mage.xp = 0;
                }
                else
                {
                    CurrentGame.game.memoryGeneral.humanClassProgress.mage.xp = 0;
                    CurrentGame.game.memoryGeneral.humanClassProgress.mage.pxp = powerGain;
                }

                // MageLoader.LevelUpClass();
            }
            else
            {
                if (powerGain >= pLevelUp)
                {
                    CurrentGame.game.memoryGeneral.humanClassProgress.mage.pxp = 0;
                    CurrentGame.game.memoryGeneral.humanClassProgress.mage.powerLevel += 1;
                    CurrentGame.game.memoryGeneral.humanClassProgress.mage.xp = totalGain;
                }
                else
                {
                    CurrentGame.game.memoryGeneral.humanClassProgress.mage.pxp = powerGain;
                    CurrentGame.game.memoryGeneral.humanClassProgress.mage.xp = totalGain;
                }
            }
        }
        if (CurrentGame.game.memoryGeneral.humanClassProgress.priest.present == true)
        {
            int totalGain = 0;
            int powerGain = 0;
            int reduce = 0;
            reduce = CurrentGame.game.memoryGeneral.humanClassProgress.priest.powerLevel - CurrentGame.game.memoryGeneral.currentLevel.powerRanking;
            if (reduce < 1) reduce = 1;
            totalGain = CurrentGame.game.memoryGeneral.humanClassProgress.priest.xp + (rewards.unitXp / reduce);
            powerGain = totalGain + CurrentGame.game.memoryGeneral.humanClassProgress.priest.pxp;
            if (totalGain >= levelUP)
            {
                if (powerGain >= pLevelUp)
                {
                    CurrentGame.game.memoryGeneral.humanClassProgress.priest.pxp = 0;
                    CurrentGame.game.memoryGeneral.humanClassProgress.priest.powerLevel += 1;
                    CurrentGame.game.memoryGeneral.humanClassProgress.priest.xp = 0;
                }
                else
                {
                    CurrentGame.game.memoryGeneral.humanClassProgress.priest.xp = 0;
                    CurrentGame.game.memoryGeneral.humanClassProgress.priest.pxp = powerGain;
                }

                // PriestLoader.LevelUpClass();
            }
            else
            {
                if (powerGain >= pLevelUp)
                {
                    CurrentGame.game.memoryGeneral.humanClassProgress.priest.pxp = 0;
                    CurrentGame.game.memoryGeneral.humanClassProgress.priest.powerLevel += 1;
                    CurrentGame.game.memoryGeneral.humanClassProgress.priest.xp = totalGain;
                }
                else
                {
                    CurrentGame.game.memoryGeneral.humanClassProgress.priest.pxp = powerGain;
                    CurrentGame.game.memoryGeneral.humanClassProgress.priest.xp = totalGain;
                }
            }
        }
        if (CurrentGame.game.memoryGeneral.humanClassProgress.rogue.present == true)
        {
            int totalGain = 0;
            int powerGain = 0;
            int reduce = 0;
            reduce = CurrentGame.game.memoryGeneral.humanClassProgress.rogue.powerLevel - CurrentGame.game.memoryGeneral.currentLevel.powerRanking;
            if (reduce < 1) reduce = 1;
            totalGain = CurrentGame.game.memoryGeneral.humanClassProgress.rogue.xp + (rewards.unitXp / reduce);
            powerGain = totalGain + CurrentGame.game.memoryGeneral.humanClassProgress.rogue.pxp;
            if (totalGain >= levelUP)
            {
                if (powerGain >= pLevelUp)
                {
                    CurrentGame.game.memoryGeneral.humanClassProgress.rogue.pxp = 0;
                    CurrentGame.game.memoryGeneral.humanClassProgress.rogue.powerLevel += 1;
                    CurrentGame.game.memoryGeneral.humanClassProgress.rogue.xp = 0;
                }
                else
                {
                    CurrentGame.game.memoryGeneral.humanClassProgress.rogue.xp = 0;
                    CurrentGame.game.memoryGeneral.humanClassProgress.rogue.pxp = powerGain;
                }

                // RogueLoader.LevelUpClass();
            }
            else
            {
                if (powerGain >= pLevelUp)
                {
                    CurrentGame.game.memoryGeneral.humanClassProgress.rogue.pxp = 0;
                    CurrentGame.game.memoryGeneral.humanClassProgress.rogue.powerLevel += 1;
                    CurrentGame.game.memoryGeneral.humanClassProgress.rogue.xp = totalGain;
                }
                else
                {
                    CurrentGame.game.memoryGeneral.humanClassProgress.rogue.pxp = powerGain;
                    CurrentGame.game.memoryGeneral.humanClassProgress.rogue.xp = totalGain;
                }
            }
        }
        if (CurrentGame.game.memoryGeneral.humanClassProgress.cavalier.present == true)
        {
          
            int totalGain = 0;
            int powerGain = 0;
            int reduce = 0;
            reduce = CurrentGame.game.memoryGeneral.humanClassProgress.cavalier.powerLevel - CurrentGame.game.memoryGeneral.currentLevel.powerRanking;
            if (reduce < 1) reduce = 1;
            totalGain = CurrentGame.game.memoryGeneral.humanClassProgress.cavalier.xp + (rewards.unitXp / reduce);
            powerGain = totalGain + CurrentGame.game.memoryGeneral.humanClassProgress.cavalier.pxp;
            if (totalGain >= levelUP)
            {
                if (powerGain >= pLevelUp)
                {
                    CurrentGame.game.memoryGeneral.humanClassProgress.cavalier.pxp = 0;
                    CurrentGame.game.memoryGeneral.humanClassProgress.cavalier.powerLevel += 1;
                    CurrentGame.game.memoryGeneral.humanClassProgress.cavalier.xp = 0;
                }
                else
                {
                    CurrentGame.game.memoryGeneral.humanClassProgress.cavalier.xp = 0;
                    CurrentGame.game.memoryGeneral.humanClassProgress.cavalier.pxp = powerGain;
                }

                // CavalierLoader.LevelUpClass();
            }
            else
            {
                if (powerGain >= pLevelUp)
                {
                    CurrentGame.game.memoryGeneral.humanClassProgress.cavalier.pxp = 0;
                    CurrentGame.game.memoryGeneral.humanClassProgress.cavalier.powerLevel += 1;
                    CurrentGame.game.memoryGeneral.humanClassProgress.cavalier.xp = totalGain;
                }
                else
                {
                    CurrentGame.game.memoryGeneral.humanClassProgress.cavalier.pxp = powerGain;
                    CurrentGame.game.memoryGeneral.humanClassProgress.cavalier.xp = totalGain;
                }
            }
        }
        if (CurrentGame.game.memoryGeneral.humanClassProgress.bard.present == true)
        {
          
            int totalGain = 0;
            int powerGain = 0;
            int reduce = 0;
            reduce = CurrentGame.game.memoryGeneral.humanClassProgress.bard.powerLevel - CurrentGame.game.memoryGeneral.currentLevel.powerRanking;
            if (reduce < 1) reduce = 1;
            totalGain = CurrentGame.game.memoryGeneral.humanClassProgress.bard.xp + (rewards.unitXp / reduce);
            powerGain = totalGain + CurrentGame.game.memoryGeneral.humanClassProgress.bard.pxp;
            if (totalGain >= levelUP)
            {
                if (powerGain >= pLevelUp)
                {
                    CurrentGame.game.memoryGeneral.humanClassProgress.bard.pxp = 0;
                    CurrentGame.game.memoryGeneral.humanClassProgress.bard.powerLevel += 1;
                    CurrentGame.game.memoryGeneral.humanClassProgress.bard.xp = 0;
                }
                else
                {
                    CurrentGame.game.memoryGeneral.humanClassProgress.bard.xp = 0;
                    CurrentGame.game.memoryGeneral.humanClassProgress.bard.pxp = powerGain;
                }

                // BardLoader.LevelUpClass();
            }
            else
            {
                if (powerGain >= pLevelUp)
                {
                    CurrentGame.game.memoryGeneral.humanClassProgress.bard.pxp = 0;
                    CurrentGame.game.memoryGeneral.humanClassProgress.bard.powerLevel += 1;
                    CurrentGame.game.memoryGeneral.humanClassProgress.bard.xp = totalGain;
                }
                else
                {
                    CurrentGame.game.memoryGeneral.humanClassProgress.bard.pxp = powerGain;
                    CurrentGame.game.memoryGeneral.humanClassProgress.bard.xp = totalGain;
                }
            }
        }
        if (CurrentGame.game.memoryGeneral.humanClassProgress.archer.present == true)
        {
           
            int totalGain = 0;
            int powerGain = 0;
            int reduce = 0;
            reduce = CurrentGame.game.memoryGeneral.humanClassProgress.archer.powerLevel - CurrentGame.game.memoryGeneral.currentLevel.powerRanking;
            if (reduce < 1) reduce = 1;
            totalGain = CurrentGame.game.memoryGeneral.humanClassProgress.archer.xp + (rewards.unitXp / reduce);
            powerGain = totalGain + CurrentGame.game.memoryGeneral.humanClassProgress.archer.pxp;
            if (totalGain >= levelUP)
            {
                if (powerGain >= pLevelUp)
                {
                    CurrentGame.game.memoryGeneral.humanClassProgress.archer.pxp = 0;
                    CurrentGame.game.memoryGeneral.humanClassProgress.archer.powerLevel += 1;
                    CurrentGame.game.memoryGeneral.humanClassProgress.archer.xp = 0;
                }
                else
                {
                    CurrentGame.game.memoryGeneral.humanClassProgress.archer.xp = 0;
                    CurrentGame.game.memoryGeneral.humanClassProgress.archer.pxp = powerGain;
                }

                // ArcherLoader.LevelUpClass();
            }
            else
            {
                if (powerGain >= pLevelUp)
                {
                    CurrentGame.game.memoryGeneral.humanClassProgress.archer.pxp = 0;
                    CurrentGame.game.memoryGeneral.humanClassProgress.archer.powerLevel += 1;
                    CurrentGame.game.memoryGeneral.humanClassProgress.archer.xp = totalGain;
                }
                else
                {
                    CurrentGame.game.memoryGeneral.humanClassProgress.archer.pxp = powerGain;
                    CurrentGame.game.memoryGeneral.humanClassProgress.archer.xp = totalGain;
                }
            }
        }
        if (CurrentGame.game.memoryGeneral.humanClassProgress.assassin.present == true)
        {

            int totalGain = 0;
            int powerGain = 0;
            int reduce = 0;
            reduce = CurrentGame.game.memoryGeneral.humanClassProgress.assassin.powerLevel - CurrentGame.game.memoryGeneral.currentLevel.powerRanking;
            if (reduce < 1) reduce = 1;
            totalGain = CurrentGame.game.memoryGeneral.humanClassProgress.assassin.xp + (rewards.unitXp / reduce);
            powerGain = totalGain + CurrentGame.game.memoryGeneral.humanClassProgress.assassin.pxp;
            if (totalGain >= levelUP)
            {
                if (powerGain >= pLevelUp)
                {
                    CurrentGame.game.memoryGeneral.humanClassProgress.assassin.pxp = 0;
                    CurrentGame.game.memoryGeneral.humanClassProgress.assassin.powerLevel += 1;
                    CurrentGame.game.memoryGeneral.humanClassProgress.assassin.xp = 0;
                }
                else
                {
                    CurrentGame.game.memoryGeneral.humanClassProgress.assassin.xp = 0;
                    CurrentGame.game.memoryGeneral.humanClassProgress.assassin.pxp = powerGain;
                }

                // ArcherLoader.LevelUpClass();
            }
            else
            {
                if (powerGain >= pLevelUp)
                {
                    CurrentGame.game.memoryGeneral.humanClassProgress.assassin.pxp = 0;
                    CurrentGame.game.memoryGeneral.humanClassProgress.assassin.powerLevel += 1;
                    CurrentGame.game.memoryGeneral.humanClassProgress.assassin.xp = totalGain;
                }
                else
                {
                    CurrentGame.game.memoryGeneral.humanClassProgress.assassin.pxp = powerGain;
                    CurrentGame.game.memoryGeneral.humanClassProgress.assassin.xp = totalGain;
                }
            }
        }
        if (CurrentGame.game.memoryGeneral.humanClassProgress.sniper.present == true)
        {

            int totalGain = 0;
            int powerGain = 0;
            int reduce = 0;
            reduce = CurrentGame.game.memoryGeneral.humanClassProgress.sniper.powerLevel - CurrentGame.game.memoryGeneral.currentLevel.powerRanking;
            if (reduce < 1) reduce = 1;
            totalGain = CurrentGame.game.memoryGeneral.humanClassProgress.sniper.xp + (rewards.unitXp / reduce);
            powerGain = totalGain + CurrentGame.game.memoryGeneral.humanClassProgress.sniper.pxp;
            if (totalGain >= levelUP)
            {
                if (powerGain >= pLevelUp)
                {
                    CurrentGame.game.memoryGeneral.humanClassProgress.sniper.pxp = 0;
                    CurrentGame.game.memoryGeneral.humanClassProgress.sniper.powerLevel += 1;
                    CurrentGame.game.memoryGeneral.humanClassProgress.sniper.xp = 0;
                }
                else
                {
                    CurrentGame.game.memoryGeneral.humanClassProgress.sniper.xp = 0;
                    CurrentGame.game.memoryGeneral.humanClassProgress.sniper.pxp = powerGain;
                }

                // ArcherLoader.LevelUpClass();
            }
            else
            {
                if (powerGain >= pLevelUp)
                {
                    CurrentGame.game.memoryGeneral.humanClassProgress.sniper.pxp = 0;
                    CurrentGame.game.memoryGeneral.humanClassProgress.sniper.powerLevel += 1;
                    CurrentGame.game.memoryGeneral.humanClassProgress.sniper.xp = totalGain;
                }
                else
                {
                    CurrentGame.game.memoryGeneral.humanClassProgress.sniper.pxp = powerGain;
                    CurrentGame.game.memoryGeneral.humanClassProgress.sniper.xp = totalGain;
                }
            }
        }
        if (CurrentGame.game.memoryGeneral.humanClassProgress.paladin.present == true)
        {

            int totalGain = 0;
            int powerGain = 0;
            int reduce = 0;
            reduce = CurrentGame.game.memoryGeneral.humanClassProgress.paladin.powerLevel - CurrentGame.game.memoryGeneral.currentLevel.powerRanking;
            if (reduce < 1) reduce = 1;
            totalGain = CurrentGame.game.memoryGeneral.humanClassProgress.paladin.xp + (rewards.unitXp / reduce);
            powerGain = totalGain + CurrentGame.game.memoryGeneral.humanClassProgress.sniper.pxp;
            if (totalGain >= levelUP)
            {
                if (powerGain >= pLevelUp)
                {
                    CurrentGame.game.memoryGeneral.humanClassProgress.paladin.pxp = 0;
                    CurrentGame.game.memoryGeneral.humanClassProgress.paladin.powerLevel += 1;
                    CurrentGame.game.memoryGeneral.humanClassProgress.paladin.xp = 0;
                }
                else
                {
                    CurrentGame.game.memoryGeneral.humanClassProgress.paladin.xp = 0;
                    CurrentGame.game.memoryGeneral.humanClassProgress.paladin.pxp = powerGain;
                }

                // ArcherLoader.LevelUpClass();
            }
            else
            {
                if (powerGain >= pLevelUp)
                {
                    CurrentGame.game.memoryGeneral.humanClassProgress.paladin.pxp = 0;
                    CurrentGame.game.memoryGeneral.humanClassProgress.paladin.powerLevel += 1;
                    CurrentGame.game.memoryGeneral.humanClassProgress.paladin.xp = totalGain;
                }
                else
                {
                    CurrentGame.game.memoryGeneral.humanClassProgress.paladin.pxp = powerGain;
                    CurrentGame.game.memoryGeneral.humanClassProgress.paladin.xp = totalGain;
                }
            }
        }
        if (CurrentGame.game.memoryGeneral.humanClassProgress.knight.present == true)
        {

            int totalGain = 0;
            int powerGain = 0;
            int reduce = 0;
            reduce = CurrentGame.game.memoryGeneral.humanClassProgress.knight.powerLevel - CurrentGame.game.memoryGeneral.currentLevel.powerRanking;
            if (reduce < 1) reduce = 1;
            totalGain = CurrentGame.game.memoryGeneral.humanClassProgress.knight.xp + (rewards.unitXp / reduce);
            powerGain = totalGain + CurrentGame.game.memoryGeneral.humanClassProgress.knight.pxp;
            if (totalGain >= levelUP)
            {
                if (powerGain >= pLevelUp)
                {
                    CurrentGame.game.memoryGeneral.humanClassProgress.knight.pxp = 0;
                    CurrentGame.game.memoryGeneral.humanClassProgress.knight.powerLevel += 1;
                    CurrentGame.game.memoryGeneral.humanClassProgress.knight.xp = 0;
                }
                else
                {
                    CurrentGame.game.memoryGeneral.humanClassProgress.knight.xp = 0;
                    CurrentGame.game.memoryGeneral.humanClassProgress.knight.pxp = powerGain;
                }

                // ArcherLoader.LevelUpClass();
            }
            else
            {
                if (powerGain >= pLevelUp)
                {
                    CurrentGame.game.memoryGeneral.humanClassProgress.knight.pxp = 0;
                    CurrentGame.game.memoryGeneral.humanClassProgress.knight.powerLevel += 1;
                    CurrentGame.game.memoryGeneral.humanClassProgress.knight.xp = totalGain;
                }
                else
                {
                    CurrentGame.game.memoryGeneral.humanClassProgress.knight.pxp = powerGain;
                    CurrentGame.game.memoryGeneral.humanClassProgress.knight.xp = totalGain;
                }
            }

        }
        if (CurrentGame.game.memoryGeneral.humanClassProgress.charger.present == true)
        {

            int totalGain = 0;
            int powerGain = 0;
            int reduce = 0;
            reduce = CurrentGame.game.memoryGeneral.humanClassProgress.charger.powerLevel - CurrentGame.game.memoryGeneral.currentLevel.powerRanking;
            if (reduce < 1) reduce = 1;
            totalGain = CurrentGame.game.memoryGeneral.humanClassProgress.charger.xp + (rewards.unitXp / reduce);
            powerGain = totalGain + CurrentGame.game.memoryGeneral.humanClassProgress.knight.pxp;
            if (totalGain >= levelUP)
            {
                if (powerGain >= pLevelUp)
                {
                    CurrentGame.game.memoryGeneral.humanClassProgress.charger.pxp = 0;
                    CurrentGame.game.memoryGeneral.humanClassProgress.charger.powerLevel += 1;
                    CurrentGame.game.memoryGeneral.humanClassProgress.charger.xp = 0;
                }
                else
                {
                    CurrentGame.game.memoryGeneral.humanClassProgress.charger.xp = 0;
                    CurrentGame.game.memoryGeneral.humanClassProgress.charger.pxp = powerGain;
                }

                // ArcherLoader.LevelUpClass();
            }
            else
            {
                if (powerGain >= pLevelUp)
                {
                    CurrentGame.game.memoryGeneral.humanClassProgress.charger.pxp = 0;
                    CurrentGame.game.memoryGeneral.humanClassProgress.charger.powerLevel += 1;
                    CurrentGame.game.memoryGeneral.humanClassProgress.charger.xp = totalGain;
                }
                else
                {
                    CurrentGame.game.memoryGeneral.humanClassProgress.charger.pxp = powerGain;
                    CurrentGame.game.memoryGeneral.humanClassProgress.charger.xp = totalGain;
                }
            }

        }

        if (CurrentGame.game.memoryGeneral.impClassProgress.dread.present == true)
        {
            int totalGain = 0;
            int powerGain = 0;
            int reduce = 0;
            reduce = CurrentGame.game.memoryGeneral.impClassProgress.dread.powerLevel - CurrentGame.game.memoryGeneral.currentLevel.powerRanking;
            if (reduce < 1) reduce = 1;
            totalGain = CurrentGame.game.memoryGeneral.impClassProgress.dread.xp + (rewards.unitXp / reduce);
            powerGain = totalGain + CurrentGame.game.memoryGeneral.impClassProgress.dread.pxp;
            if (totalGain >= levelUP)
            {
                if (powerGain >= pLevelUp)
                {
                    CurrentGame.game.memoryGeneral.impClassProgress.dread.pxp = 0;
                    CurrentGame.game.memoryGeneral.impClassProgress.dread.powerLevel += 1;
                    CurrentGame.game.memoryGeneral.impClassProgress.dread.xp = 0;
                }
                else
                {
                    CurrentGame.game.memoryGeneral.impClassProgress.dread.xp = 0;
                    CurrentGame.game.memoryGeneral.impClassProgress.dread.pxp = powerGain;
                }

                // DreadLoader.LevelUpClass();
            }
            else
            {
                if (powerGain >= pLevelUp)
                {
                    CurrentGame.game.memoryGeneral.impClassProgress.dread.pxp = 0;
                    CurrentGame.game.memoryGeneral.impClassProgress.dread.powerLevel += 1;
                    CurrentGame.game.memoryGeneral.impClassProgress.dread.xp = totalGain;
                }
                else
                {
                    CurrentGame.game.memoryGeneral.impClassProgress.dread.pxp = powerGain;
                    CurrentGame.game.memoryGeneral.impClassProgress.dread.xp = totalGain;
                }
            }
        }
        if (CurrentGame.game.memoryGeneral.impClassProgress.fusilier.present == true)
        { 
            int totalGain = 0;
            int powerGain = 0;
            int reduce = 0;
            reduce = CurrentGame.game.memoryGeneral.impClassProgress.fusilier.powerLevel - CurrentGame.game.memoryGeneral.currentLevel.powerRanking;
            if (reduce < 1) reduce = 1;
            totalGain = CurrentGame.game.memoryGeneral.impClassProgress.fusilier.xp + (rewards.unitXp / reduce);
            powerGain = totalGain + CurrentGame.game.memoryGeneral.impClassProgress.fusilier.pxp;
            if (totalGain >= levelUP)
            {
                if (powerGain >= pLevelUp)
                {
                    CurrentGame.game.memoryGeneral.impClassProgress.fusilier.pxp = 0;
                    CurrentGame.game.memoryGeneral.impClassProgress.fusilier.powerLevel += 1;
                    CurrentGame.game.memoryGeneral.impClassProgress.fusilier.xp = 0;
                }
                else
                {
                    CurrentGame.game.memoryGeneral.impClassProgress.fusilier.xp = 0;
                    CurrentGame.game.memoryGeneral.impClassProgress.fusilier.pxp = powerGain;
                }

                // FusilierLoader.LevelUpClass();
            }
            else
            {
                if (powerGain >= pLevelUp)
                {
                    CurrentGame.game.memoryGeneral.impClassProgress.fusilier.pxp = 0;
                    CurrentGame.game.memoryGeneral.impClassProgress.fusilier.powerLevel += 1;
                    CurrentGame.game.memoryGeneral.impClassProgress.fusilier.xp = totalGain;
                }
                else
                {
                    CurrentGame.game.memoryGeneral.impClassProgress.fusilier.pxp = powerGain;
                    CurrentGame.game.memoryGeneral.impClassProgress.fusilier.xp = totalGain;
                }
            }
        }  
        if (CurrentGame.game.memoryGeneral.impClassProgress.shrike.present == true)
        {
           
            int totalGain = 0;
            int powerGain = 0;
            int reduce = 0;
            reduce = CurrentGame.game.memoryGeneral.impClassProgress.shrike.powerLevel - CurrentGame.game.memoryGeneral.currentLevel.powerRanking;
            if (reduce < 1) reduce = 1;
            totalGain = CurrentGame.game.memoryGeneral.impClassProgress.shrike.xp + (rewards.unitXp / reduce);
            powerGain = totalGain + CurrentGame.game.memoryGeneral.impClassProgress.shrike.pxp;
            if (totalGain >= levelUP)
            {
                if (powerGain >= pLevelUp)
                {
                    CurrentGame.game.memoryGeneral.impClassProgress.shrike.pxp = 0;
                    CurrentGame.game.memoryGeneral.impClassProgress.shrike.powerLevel += 1;
                    CurrentGame.game.memoryGeneral.impClassProgress.shrike.xp = 0;
                }
                else
                {
                    CurrentGame.game.memoryGeneral.impClassProgress.shrike.xp = 0;
                    CurrentGame.game.memoryGeneral.impClassProgress.shrike.pxp = powerGain;
                }

                // ShrikeLoader.LevelUpClass();
            }
            else
            {
                if (powerGain >= pLevelUp)
                {
                    CurrentGame.game.memoryGeneral.impClassProgress.shrike.pxp = 0;
                    CurrentGame.game.memoryGeneral.impClassProgress.shrike.powerLevel += 1;
                    CurrentGame.game.memoryGeneral.impClassProgress.shrike.xp = totalGain;
                }
                else
                {
                    CurrentGame.game.memoryGeneral.impClassProgress.shrike.pxp = powerGain;
                    CurrentGame.game.memoryGeneral.impClassProgress.shrike.xp = totalGain;
                }
            }
        }
        if (CurrentGame.game.memoryGeneral.impClassProgress.swashbuckler.present == true)
        {
         
          
            int totalGain = 0;
            int powerGain = 0;
            int reduce = 0;
            reduce = CurrentGame.game.memoryGeneral.impClassProgress.swashbuckler.powerLevel - CurrentGame.game.memoryGeneral.currentLevel.powerRanking;
            if (reduce < 1) reduce = 1;
            totalGain = CurrentGame.game.memoryGeneral.impClassProgress.swashbuckler.xp + (rewards.unitXp / reduce);
            powerGain = totalGain + CurrentGame.game.memoryGeneral.impClassProgress.swashbuckler.pxp;
            if (totalGain >= levelUP)
            {
                if (powerGain >= pLevelUp)
                {
                    CurrentGame.game.memoryGeneral.impClassProgress.swashbuckler.pxp = 0;
                    CurrentGame.game.memoryGeneral.impClassProgress.swashbuckler.powerLevel += 1;
                    CurrentGame.game.memoryGeneral.impClassProgress.swashbuckler.xp = 0;
                }
                else
                {
                    CurrentGame.game.memoryGeneral.impClassProgress.swashbuckler.xp = 0;
                    CurrentGame.game.memoryGeneral.impClassProgress.swashbuckler.pxp = powerGain;
                }

                // SwashbulklerLoader.LevelUpClass();
            }
            else
            {
                if (powerGain >= pLevelUp)
                {
                    CurrentGame.game.memoryGeneral.impClassProgress.swashbuckler.pxp = 0;
                    CurrentGame.game.memoryGeneral.impClassProgress.swashbuckler.powerLevel += 1;
                    CurrentGame.game.memoryGeneral.impClassProgress.swashbuckler.xp = totalGain;
                }
                else
                {
                    CurrentGame.game.memoryGeneral.impClassProgress.swashbuckler.pxp = powerGain;
                    CurrentGame.game.memoryGeneral.impClassProgress.swashbuckler.xp = totalGain;
                }
            }
        }
        if (CurrentGame.game.memoryGeneral.impClassProgress.shadow.present == true)
        {
           
            int totalGain = 0;
            int powerGain = 0;
            int reduce = 0;
            reduce = CurrentGame.game.memoryGeneral.impClassProgress.shadow.powerLevel - CurrentGame.game.memoryGeneral.currentLevel.powerRanking;
            if (reduce < 1) reduce = 1;
            totalGain = CurrentGame.game.memoryGeneral.impClassProgress.shadow.xp + (rewards.unitXp / reduce);
            powerGain = totalGain + CurrentGame.game.memoryGeneral.impClassProgress.shadow.pxp;
            if (totalGain >= levelUP)
            {
                if (powerGain >= pLevelUp)
                {
                    CurrentGame.game.memoryGeneral.impClassProgress.shadow.pxp = 0;
                    CurrentGame.game.memoryGeneral.impClassProgress.shadow.powerLevel += 1;
                    CurrentGame.game.memoryGeneral.impClassProgress.shadow.xp = 0;
                }
                else
                {
                    CurrentGame.game.memoryGeneral.impClassProgress.shadow.xp = 0;
                    CurrentGame.game.memoryGeneral.impClassProgress.shadow.pxp = powerGain;
                }

                //ShadowLoader.LevelUpClass();
            }
            else
            {
                if (powerGain >= pLevelUp)
                {
                    CurrentGame.game.memoryGeneral.impClassProgress.shadow.pxp = 0;
                    CurrentGame.game.memoryGeneral.impClassProgress.shadow.powerLevel += 1;
                    CurrentGame.game.memoryGeneral.impClassProgress.shadow.xp = totalGain;
                }
                else
                {
                    CurrentGame.game.memoryGeneral.impClassProgress.shadow.pxp = powerGain;
                    CurrentGame.game.memoryGeneral.impClassProgress.shadow.xp = totalGain;
                }
            }
        }
        if (CurrentGame.game.memoryGeneral.impClassProgress.cannoneer.present == true)
        {

            int totalGain = 0;
            int powerGain = 0;
            int reduce = 0;
            reduce = CurrentGame.game.memoryGeneral.impClassProgress.cannoneer.powerLevel - CurrentGame.game.memoryGeneral.currentLevel.powerRanking;
            if (reduce < 1) reduce = 1;
            totalGain = CurrentGame.game.memoryGeneral.impClassProgress.cannoneer.xp + (rewards.unitXp / reduce);
            powerGain = totalGain + CurrentGame.game.memoryGeneral.impClassProgress.cannoneer.pxp;
            if (totalGain >= levelUP)
            {
                if (powerGain >= pLevelUp)
                {
                    CurrentGame.game.memoryGeneral.impClassProgress.cannoneer.pxp = 0;
                    CurrentGame.game.memoryGeneral.impClassProgress.cannoneer.powerLevel += 1;
                    CurrentGame.game.memoryGeneral.impClassProgress.cannoneer.xp = 0;
                }
                else
                {
                    CurrentGame.game.memoryGeneral.impClassProgress.cannoneer.xp = 0;
                    CurrentGame.game.memoryGeneral.impClassProgress.cannoneer.pxp = powerGain;
                }

                //ShadowLoader.LevelUpClass();
            }
            else
            {
                if (powerGain >= pLevelUp)
                {
                    CurrentGame.game.memoryGeneral.impClassProgress.cannoneer.pxp = 0;
                    CurrentGame.game.memoryGeneral.impClassProgress.cannoneer.powerLevel += 1;
                    CurrentGame.game.memoryGeneral.impClassProgress.cannoneer.xp = totalGain;
                }
                else
                {
                    CurrentGame.game.memoryGeneral.impClassProgress.cannoneer.pxp = powerGain;
                    CurrentGame.game.memoryGeneral.impClassProgress.cannoneer.xp = totalGain;
                }
            }
        }
        if (CurrentGame.game.memoryGeneral.impClassProgress.darkknight.present == true)
        {

            int totalGain = 0;
            int powerGain = 0;
            int reduce = 0;
            reduce = CurrentGame.game.memoryGeneral.impClassProgress.darkknight.powerLevel - CurrentGame.game.memoryGeneral.currentLevel.powerRanking;
            if (reduce < 1) reduce = 1;
            totalGain = CurrentGame.game.memoryGeneral.impClassProgress.darkknight.xp + (rewards.unitXp / reduce);
            powerGain = totalGain + CurrentGame.game.memoryGeneral.impClassProgress.darkknight.pxp;
            if (totalGain >= levelUP)
            {
                if (powerGain >= pLevelUp)
                {
                    CurrentGame.game.memoryGeneral.impClassProgress.darkknight.pxp = 0;
                    CurrentGame.game.memoryGeneral.impClassProgress.darkknight.powerLevel += 1;
                    CurrentGame.game.memoryGeneral.impClassProgress.darkknight.xp = 0;
                }
                else
                {
                    CurrentGame.game.memoryGeneral.impClassProgress.darkknight.xp = 0;
                    CurrentGame.game.memoryGeneral.impClassProgress.darkknight.pxp = powerGain;
                }

                //ShadowLoader.LevelUpClass();
            }
            else
            {
                if (powerGain >= pLevelUp)
                {
                    CurrentGame.game.memoryGeneral.impClassProgress.darkknight.pxp = 0;
                    CurrentGame.game.memoryGeneral.impClassProgress.darkknight.powerLevel += 1;
                    CurrentGame.game.memoryGeneral.impClassProgress.darkknight.xp = totalGain;
                }
                else
                {
                    CurrentGame.game.memoryGeneral.impClassProgress.darkknight.pxp = powerGain;
                    CurrentGame.game.memoryGeneral.impClassProgress.darkknight.xp = totalGain;
                }
            }
        }
        if (CurrentGame.game.memoryGeneral.impClassProgress.demonRider.present == true)
        {

            int totalGain = 0;
            int powerGain = 0;
            int reduce = 0;
            reduce = CurrentGame.game.memoryGeneral.impClassProgress.demonRider.powerLevel - CurrentGame.game.memoryGeneral.currentLevel.powerRanking;
            if (reduce < 1) reduce = 1;
            totalGain = CurrentGame.game.memoryGeneral.impClassProgress.demonRider.xp + (rewards.unitXp / reduce);
            powerGain = totalGain + CurrentGame.game.memoryGeneral.impClassProgress.demonRider.pxp;
            if (totalGain >= levelUP)
            {
                if (powerGain >= pLevelUp)
                {
                    CurrentGame.game.memoryGeneral.impClassProgress.demonRider.pxp = 0;
                    CurrentGame.game.memoryGeneral.impClassProgress.demonRider.powerLevel += 1;
                    CurrentGame.game.memoryGeneral.impClassProgress.demonRider.xp = 0;
                }
                else
                {
                    CurrentGame.game.memoryGeneral.impClassProgress.demonRider.xp = 0;
                    CurrentGame.game.memoryGeneral.impClassProgress.demonRider.pxp = powerGain;
                }

                //ShadowLoader.LevelUpClass();
            }
            else
            {
                if (powerGain >= pLevelUp)
                {
                    CurrentGame.game.memoryGeneral.impClassProgress.demonRider.pxp = 0;
                    CurrentGame.game.memoryGeneral.impClassProgress.demonRider.powerLevel += 1;
                    CurrentGame.game.memoryGeneral.impClassProgress.demonRider.xp = totalGain;
                }
                else
                {
                    CurrentGame.game.memoryGeneral.impClassProgress.demonRider.pxp = powerGain;
                    CurrentGame.game.memoryGeneral.impClassProgress.demonRider.xp = totalGain;
                }
            }
        }
        if (CurrentGame.game.memoryGeneral.impClassProgress.nightblade.present == true)
        {

            int totalGain = 0;
            int powerGain = 0;
            int reduce = 0;
            reduce = CurrentGame.game.memoryGeneral.impClassProgress.nightblade.powerLevel - CurrentGame.game.memoryGeneral.currentLevel.powerRanking;
            if (reduce < 1) reduce = 1;
            totalGain = CurrentGame.game.memoryGeneral.impClassProgress.nightblade.xp + (rewards.unitXp / reduce);
            powerGain = totalGain + CurrentGame.game.memoryGeneral.impClassProgress.nightblade.pxp;
            if (totalGain >= levelUP)
            {
                if (powerGain >= pLevelUp)
                {
                    CurrentGame.game.memoryGeneral.impClassProgress.nightblade.pxp = 0;
                    CurrentGame.game.memoryGeneral.impClassProgress.nightblade.powerLevel += 1;
                    CurrentGame.game.memoryGeneral.impClassProgress.nightblade.xp = 0;
                }
                else
                {
                    CurrentGame.game.memoryGeneral.impClassProgress.nightblade.xp = 0;
                    CurrentGame.game.memoryGeneral.impClassProgress.nightblade.pxp = powerGain;
                }

                //ShadowLoader.LevelUpClass();
            }
            else
            {
                if (powerGain >= pLevelUp)
                {
                    CurrentGame.game.memoryGeneral.impClassProgress.nightblade.pxp = 0;
                    CurrentGame.game.memoryGeneral.impClassProgress.nightblade.powerLevel += 1;
                    CurrentGame.game.memoryGeneral.impClassProgress.nightblade.xp = totalGain;
                }
                else
                {
                    CurrentGame.game.memoryGeneral.impClassProgress.nightblade.pxp = powerGain;
                    CurrentGame.game.memoryGeneral.impClassProgress.nightblade.xp = totalGain;
                }
            }
        }
        CurrentGame.game.memoryGeneral.humanClassProgress.warrior.present = false;
        CurrentGame.game.memoryGeneral.humanClassProgress.mage.present = false;
        CurrentGame.game.memoryGeneral.humanClassProgress.priest.present = false;
        CurrentGame.game.memoryGeneral.humanClassProgress.rogue.present = false;
        CurrentGame.game.memoryGeneral.humanClassProgress.cavalier.present = false;
        CurrentGame.game.memoryGeneral.humanClassProgress.bard.present = false;
        CurrentGame.game.memoryGeneral.humanClassProgress.archer.present = false;
        CurrentGame.game.memoryGeneral.humanClassProgress.knight.present = true;
        CurrentGame.game.memoryGeneral.humanClassProgress.paladin.present = false;
        CurrentGame.game.memoryGeneral.humanClassProgress.sniper.present = false;
        CurrentGame.game.memoryGeneral.humanClassProgress.assassin.present = false;
        CurrentGame.game.memoryGeneral.humanClassProgress.charger.present = false;
        /* CurrentGame.game.memoryGeneral.viraClassProgress.chronos.present = false;
         CurrentGame.game.memoryGeneral.viraClassProgress.alchemist.present = false;
         CurrentGame.game.memoryGeneral.viraClassProgress.geomancer.present = false;
         CurrentGame.game.memoryGeneral.viraClassProgress.kensai.present = false;
         CurrentGame.game.memoryGeneral.viraClassProgress.onmiyoji.present = false;
         CurrentGame.game.memoryGeneral.viraClassProgress.wardancer.present = false;*/

        CurrentGame.game.memoryGeneral.impClassProgress.dread.present = false;
        CurrentGame.game.memoryGeneral.impClassProgress.duelist.present = false;
        CurrentGame.game.memoryGeneral.impClassProgress.fusilier.present = false;
        CurrentGame.game.memoryGeneral.impClassProgress.shadow.present = false;
        CurrentGame.game.memoryGeneral.impClassProgress.shrike.present = false;
        CurrentGame.game.memoryGeneral.impClassProgress.swashbuckler.present = false;
        CurrentGame.game.memoryGeneral.impClassProgress.nightblade.present = false;
        CurrentGame.game.memoryGeneral.impClassProgress.cannoneer.present = false;
        CurrentGame.game.memoryGeneral.impClassProgress.darkknight.present = false;
        CurrentGame.game.memoryGeneral.impClassProgress.demonRider.present = false;


        levelUP = 100;

        foreach (Unit unit in CurrentGame.game.memoryGeneral.unitsInParty)
        {       
            if (unit.inventory.invSlot1.holding != "")
            {
                if (unit.inventory.invSlot1.weapon.inSlot)
                {

                    int totalGain = 0;
                    int reduce = 0;
                    int numr = CurrentGame.game.memoryGeneral.itemsOwned.weapons.FindIndex(x => x.idx == unit.inventory.invSlot1.weapon.idx);
                    if (!CurrentGame.game.memoryGeneral.itemsOwned.weapons[numr].details.uniqueWeaponXps.Exists(x => x.idx == unit.idx))
                    {
                        CurrentGame.game.memoryGeneral.itemsOwned.weapons[numr].details.uniqueWeaponXps.Add(new UnitUniqueWeaponXp(unit.idx));
                        unit.inventory.invSlot1.weapon = CurrentGame.game.memoryGeneral.itemsOwned.weapons[numr];
                    }

                    int numk = CurrentGame.game.memoryGeneral.itemsOwned.weapons[numr].details.uniqueWeaponXps.FindIndex(x => x.idx == unit.idx);
                    reduce = CurrentGame.game.memoryGeneral.itemsOwned.weapons[numr].details.rank - CurrentGame.game.memoryGeneral.currentLevel.powerRanking;
                    if (reduce < 1) reduce = 1;
                    totalGain = CurrentGame.game.memoryGeneral.itemsOwned.weapons[numr].details.uniqueWeaponXps[numk].xp + (rewards.weaponXP / reduce);

                    if (!CurrentGame.game.memoryGeneral.itemsOwned.weapons[numr].details.uniqueWeaponXps[numk].done)
                    {
                        if (totalGain >= levelUP)
                        {

                            unit.inventory.invSlot1.weapon.details.xp = 0;
                            CurrentGame.game.memoryGeneral.itemsOwned.weapons[numr].details.uniqueWeaponXps[numk].done = true;
                            if (!HasSkill(unit.inventory.invSlot1.weapon.details.unlocks, unit.idx))
                            {
                                UnitLearn(CurrentGame.game.memoryGeneral.itemsOwned.weapons[numr].details.unlocks, unit.idx);
                            }
                            if (CurrentGame.game.memoryGeneral.itemsOwned.weapons[numr].details.moreUnlocks.Count > 0)
                            {
                                foreach (string name in CurrentGame.game.memoryGeneral.itemsOwned.weapons[numr].details.moreUnlocks)
                                {
                                    UnitLearn(name, unit.idx);
                                }
                            }
                            unit.inventory.invSlot1.weapon = CurrentGame.game.memoryGeneral.itemsOwned.weapons[numr];

                            // ShadowLoader.LevelUpClass();
                        }
                        else
                        {
                            CurrentGame.game.memoryGeneral.itemsOwned.weapons[numr].details.uniqueWeaponXps[numk].xp = totalGain;
                            unit.inventory.invSlot1.weapon = CurrentGame.game.memoryGeneral.itemsOwned.weapons[numr];
                        }
                    }
                }
                else if (unit.inventory.invSlot1.assessory.inSlot)
                {
                    int totalGain = 0;
                    int reduce = 0;
                    int numr = CurrentGame.game.memoryGeneral.itemsOwned.assessories.FindIndex(x => x.idx == unit.inventory.invSlot1.assessory.idx);
                    if (!CurrentGame.game.memoryGeneral.itemsOwned.assessories[numr].details.uniqueAssessoryXps.Exists(x => x.idx == unit.idx))
                    {
                        CurrentGame.game.memoryGeneral.itemsOwned.assessories[numr].details.uniqueAssessoryXps.Add(new UnitUniqueAssessoryXp(unit.idx));
                        unit.inventory.invSlot1.assessory = CurrentGame.game.memoryGeneral.itemsOwned.assessories[numr];
                    }

                    int numk = CurrentGame.game.memoryGeneral.itemsOwned.assessories[numr].details.uniqueAssessoryXps.FindIndex(x => x.idx == unit.idx);
                    reduce = CurrentGame.game.memoryGeneral.itemsOwned.assessories[numr].details.rank - CurrentGame.game.memoryGeneral.currentLevel.powerRanking;
                    if (reduce < 1) reduce = 1;
                    totalGain = CurrentGame.game.memoryGeneral.itemsOwned.assessories[numr].details.uniqueAssessoryXps[numk].xp + (rewards.weaponXP / reduce);

                    if (!CurrentGame.game.memoryGeneral.itemsOwned.assessories[numr].details.uniqueAssessoryXps[numk].done)
                    {
                        if (totalGain >= levelUP)
                        {

                            unit.inventory.invSlot1.assessory.details.xp = 0;
                            CurrentGame.game.memoryGeneral.itemsOwned.assessories[numr].details.uniqueAssessoryXps[numk].done = true;
                            if (!HasSkill(unit.inventory.invSlot1.assessory.details.unlocks, unit.idx))
                            {
                                UnitLearn(CurrentGame.game.memoryGeneral.itemsOwned.assessories[numr].details.unlocks, unit.idx);
                            }
                            if (CurrentGame.game.memoryGeneral.itemsOwned.assessories[numr].details.moreUnlocks.Count > 0)
                            {
                                foreach (string name in CurrentGame.game.memoryGeneral.itemsOwned.assessories[numr].details.moreUnlocks)
                                {
                                    UnitLearn(name, unit.idx);
                                }
                            }
                            unit.inventory.invSlot1.assessory = CurrentGame.game.memoryGeneral.itemsOwned.assessories[numr];

                            // ShadowLoader.LevelUpClass();
                        }
                        else
                        {
                            CurrentGame.game.memoryGeneral.itemsOwned.assessories[numr].details.uniqueAssessoryXps[numk].xp = totalGain;
                            unit.inventory.invSlot1.assessory = CurrentGame.game.memoryGeneral.itemsOwned.assessories[numr];
                        }
                    }
                }
            }
            if (unit.inventory.invSlot2.holding != "")
            {
                if (unit.inventory.invSlot2.weapon.inSlot)
                {
                    int totalGain = 0;
                    int reduce = 0;
                    int numr = CurrentGame.game.memoryGeneral.itemsOwned.weapons.FindIndex(x => x.idx == unit.inventory.invSlot2.weapon.idx);
                    if (!CurrentGame.game.memoryGeneral.itemsOwned.weapons[numr].details.uniqueWeaponXps.Exists(x => x.idx == unit.idx))
                    {
                        CurrentGame.game.memoryGeneral.itemsOwned.weapons[numr].details.uniqueWeaponXps.Add(new UnitUniqueWeaponXp(unit.idx));
                        unit.inventory.invSlot2.weapon = CurrentGame.game.memoryGeneral.itemsOwned.weapons[numr];
                    }

                    int numk = CurrentGame.game.memoryGeneral.itemsOwned.weapons[numr].details.uniqueWeaponXps.FindIndex(x => x.idx == unit.idx);
                    reduce = CurrentGame.game.memoryGeneral.itemsOwned.weapons[numr].details.rank - CurrentGame.game.memoryGeneral.currentLevel.powerRanking;
                    if (reduce < 1) reduce = 1;
                    totalGain = CurrentGame.game.memoryGeneral.itemsOwned.weapons[numr].details.uniqueWeaponXps[numk].xp + (rewards.weaponXP / reduce);

                    if (!CurrentGame.game.memoryGeneral.itemsOwned.weapons[numr].details.uniqueWeaponXps[numk].done)
                    {
                        if (totalGain >= levelUP)
                        {

                            unit.inventory.invSlot2.weapon.details.xp = 0;
                            CurrentGame.game.memoryGeneral.itemsOwned.weapons[numr].details.uniqueWeaponXps[numk].done = true;
                            if (!HasSkill(unit.inventory.invSlot2.weapon.details.unlocks, unit.idx))
                            {
                                UnitLearn(CurrentGame.game.memoryGeneral.itemsOwned.weapons[numr].details.unlocks, unit.idx);
                            }
                            if (CurrentGame.game.memoryGeneral.itemsOwned.weapons[numr].details.moreUnlocks.Count > 0)
                            {
                                foreach (string name in CurrentGame.game.memoryGeneral.itemsOwned.weapons[numr].details.moreUnlocks)
                                {
                                    UnitLearn(name, unit.idx);
                                }
                            }
                            unit.inventory.invSlot2.weapon = CurrentGame.game.memoryGeneral.itemsOwned.weapons[numr];

                            // ShadowLoader.LevelUpClass();
                        }
                        else
                        {
                            CurrentGame.game.memoryGeneral.itemsOwned.weapons[numr].details.uniqueWeaponXps[numk].xp = totalGain;
                            unit.inventory.invSlot2.weapon = CurrentGame.game.memoryGeneral.itemsOwned.weapons[numr];
                        }
                    }
                }
                else if (unit.inventory.invSlot2.assessory.inSlot)
                {
                    int totalGain = 0;
                    int reduce = 0;
                    int numr = CurrentGame.game.memoryGeneral.itemsOwned.assessories.FindIndex(x => x.idx == unit.inventory.invSlot2.assessory.idx);
                    if (!CurrentGame.game.memoryGeneral.itemsOwned.assessories[numr].details.uniqueAssessoryXps.Exists(x => x.idx == unit.idx))
                    {
                        CurrentGame.game.memoryGeneral.itemsOwned.assessories[numr].details.uniqueAssessoryXps.Add(new UnitUniqueAssessoryXp(unit.idx));
                        unit.inventory.invSlot2.assessory = CurrentGame.game.memoryGeneral.itemsOwned.assessories[numr];
                    }

                    int numk = CurrentGame.game.memoryGeneral.itemsOwned.assessories[numr].details.uniqueAssessoryXps.FindIndex(x => x.idx == unit.idx);
                    reduce = CurrentGame.game.memoryGeneral.itemsOwned.assessories[numr].details.rank - CurrentGame.game.memoryGeneral.currentLevel.powerRanking;
                    if (reduce < 1) reduce = 1;
                    totalGain = CurrentGame.game.memoryGeneral.itemsOwned.assessories[numr].details.uniqueAssessoryXps[numk].xp + (rewards.weaponXP / reduce);

                    if (!CurrentGame.game.memoryGeneral.itemsOwned.assessories[numr].details.uniqueAssessoryXps[numk].done)
                    {
                        if (totalGain >= levelUP)
                        {

                            unit.inventory.invSlot2.assessory.details.xp = 0;
                            CurrentGame.game.memoryGeneral.itemsOwned.assessories[numr].details.uniqueAssessoryXps[numk].done = true;
                            if (!HasSkill(unit.inventory.invSlot2.assessory.details.unlocks, unit.idx))
                            {
                                UnitLearn(CurrentGame.game.memoryGeneral.itemsOwned.assessories[numr].details.unlocks, unit.idx);
                            }
                            if (CurrentGame.game.memoryGeneral.itemsOwned.assessories[numr].details.moreUnlocks.Count > 0)
                            {
                                foreach (string name in CurrentGame.game.memoryGeneral.itemsOwned.assessories[numr].details.moreUnlocks)
                                {
                                    UnitLearn(name, unit.idx);
                                }
                            }
                            unit.inventory.invSlot2.assessory = CurrentGame.game.memoryGeneral.itemsOwned.assessories[numr];

                            // ShadowLoader.LevelUpClass();
                        }
                        else
                        {
                            CurrentGame.game.memoryGeneral.itemsOwned.assessories[numr].details.uniqueAssessoryXps[numk].xp = totalGain;
                            unit.inventory.invSlot2.assessory = CurrentGame.game.memoryGeneral.itemsOwned.assessories[numr];
                        }
                    }
                }
            }
            if (unit.inventory.invSlot3.holding != "")
            {
                if (unit.inventory.invSlot3.weapon.inSlot)
                {
                    int totalGain = 0;
                    int reduce = 0;
                    int numr = CurrentGame.game.memoryGeneral.itemsOwned.weapons.FindIndex(x => x.idx == unit.inventory.invSlot3.weapon.idx);
                    if (!CurrentGame.game.memoryGeneral.itemsOwned.weapons[numr].details.uniqueWeaponXps.Exists(x => x.idx == unit.idx))
                    {
                        CurrentGame.game.memoryGeneral.itemsOwned.weapons[numr].details.uniqueWeaponXps.Add(new UnitUniqueWeaponXp(unit.idx));
                        unit.inventory.invSlot3.weapon = CurrentGame.game.memoryGeneral.itemsOwned.weapons[numr];
                    }

                    int numk = CurrentGame.game.memoryGeneral.itemsOwned.weapons[numr].details.uniqueWeaponXps.FindIndex(x => x.idx == unit.idx);
                    reduce = CurrentGame.game.memoryGeneral.itemsOwned.weapons[numr].details.rank - CurrentGame.game.memoryGeneral.currentLevel.powerRanking;
                    if (reduce < 1) reduce = 1;
                    totalGain = CurrentGame.game.memoryGeneral.itemsOwned.weapons[numr].details.uniqueWeaponXps[numk].xp + (rewards.weaponXP / reduce);

                    if (!CurrentGame.game.memoryGeneral.itemsOwned.weapons[numr].details.uniqueWeaponXps[numk].done)
                    {
                        if (totalGain >= levelUP)
                        {

                            unit.inventory.invSlot3.weapon.details.xp = 0;
                            CurrentGame.game.memoryGeneral.itemsOwned.weapons[numr].details.uniqueWeaponXps[numk].done = true;
                            if (!HasSkill(unit.inventory.invSlot3.weapon.details.unlocks, unit.idx))
                            {
                                UnitLearn(CurrentGame.game.memoryGeneral.itemsOwned.weapons[numr].details.unlocks, unit.idx);
                            }
                            if (CurrentGame.game.memoryGeneral.itemsOwned.weapons[numr].details.moreUnlocks.Count > 0)
                            {
                                foreach (string name in CurrentGame.game.memoryGeneral.itemsOwned.weapons[numr].details.moreUnlocks)
                                {
                                    UnitLearn(name, unit.idx);
                                }
                            }
                            unit.inventory.invSlot3.weapon = CurrentGame.game.memoryGeneral.itemsOwned.weapons[numr];
                            // ShadowLoader.LevelUpClass();
                        }
                        else
                        {
                            CurrentGame.game.memoryGeneral.itemsOwned.weapons[numr].details.uniqueWeaponXps[numk].xp = totalGain;
                            unit.inventory.invSlot3.weapon = CurrentGame.game.memoryGeneral.itemsOwned.weapons[numr];
                        }
                    }

                }
                else if (unit.inventory.invSlot3.assessory.inSlot)
                {
                    int totalGain = 0;
                    int reduce = 0;
                    int numr = CurrentGame.game.memoryGeneral.itemsOwned.assessories.FindIndex(x => x.idx == unit.inventory.invSlot3.assessory.idx);
                    if (!CurrentGame.game.memoryGeneral.itemsOwned.assessories[numr].details.uniqueAssessoryXps.Exists(x => x.idx == unit.idx))
                    {
                        CurrentGame.game.memoryGeneral.itemsOwned.assessories[numr].details.uniqueAssessoryXps.Add(new UnitUniqueAssessoryXp(unit.idx));
                        unit.inventory.invSlot3.assessory = CurrentGame.game.memoryGeneral.itemsOwned.assessories[numr];
                    }

                    int numk = CurrentGame.game.memoryGeneral.itemsOwned.assessories[numr].details.uniqueAssessoryXps.FindIndex(x => x.idx == unit.idx);
                    reduce = CurrentGame.game.memoryGeneral.itemsOwned.assessories[numr].details.rank - CurrentGame.game.memoryGeneral.currentLevel.powerRanking;
                    if (reduce < 1) reduce = 1;
                    totalGain = CurrentGame.game.memoryGeneral.itemsOwned.assessories[numr].details.uniqueAssessoryXps[numk].xp + (rewards.weaponXP / reduce);

                    if (!CurrentGame.game.memoryGeneral.itemsOwned.assessories[numr].details.uniqueAssessoryXps[numk].done)
                    {
                        if (totalGain >= levelUP)
                        {

                            unit.inventory.invSlot3.assessory.details.xp = 0;
                            CurrentGame.game.memoryGeneral.itemsOwned.assessories[numr].details.uniqueAssessoryXps[numk].done = true;
                            if (!HasSkill(unit.inventory.invSlot3.assessory.details.unlocks, unit.idx))
                            {
                                UnitLearn(CurrentGame.game.memoryGeneral.itemsOwned.assessories[numr].details.unlocks, unit.idx);
                            }
                            if (CurrentGame.game.memoryGeneral.itemsOwned.assessories[numr].details.moreUnlocks.Count > 0)
                            {
                                foreach (string name in CurrentGame.game.memoryGeneral.itemsOwned.assessories[numr].details.moreUnlocks)
                                {
                                    UnitLearn(name, unit.idx);
                                }
                            }
                            unit.inventory.invSlot3.assessory = CurrentGame.game.memoryGeneral.itemsOwned.assessories[numr];
                            // ShadowLoader.LevelUpClass();
                        }
                        else
                        {
                            CurrentGame.game.memoryGeneral.itemsOwned.assessories[numr].details.uniqueAssessoryXps[numk].xp = totalGain;
                            unit.inventory.invSlot3.assessory = CurrentGame.game.memoryGeneral.itemsOwned.assessories[numr];
                        }
                    }
                }
            }
            if (unit.inventory.invSlot4.holding != "")
            {
                if (unit.inventory.invSlot4.weapon.inSlot)
                {
                    int totalGain = 0;
                    int reduce = 0;
                    int numr = CurrentGame.game.memoryGeneral.itemsOwned.weapons.FindIndex(x => x.idx == unit.inventory.invSlot4.weapon.idx);
                    if (!CurrentGame.game.memoryGeneral.itemsOwned.weapons[numr].details.uniqueWeaponXps.Exists(x => x.idx == unit.idx))
                    {
                        CurrentGame.game.memoryGeneral.itemsOwned.weapons[numr].details.uniqueWeaponXps.Add(new UnitUniqueWeaponXp(unit.idx));
                        unit.inventory.invSlot4.weapon = CurrentGame.game.memoryGeneral.itemsOwned.weapons[numr];
                    }

                    int numk = CurrentGame.game.memoryGeneral.itemsOwned.weapons[numr].details.uniqueWeaponXps.FindIndex(x => x.idx == unit.idx);
                    reduce = CurrentGame.game.memoryGeneral.itemsOwned.weapons[numr].details.rank - CurrentGame.game.memoryGeneral.currentLevel.powerRanking;
                    if (reduce < 1) reduce = 1;
                    totalGain = CurrentGame.game.memoryGeneral.itemsOwned.weapons[numr].details.uniqueWeaponXps[numk].xp + (rewards.weaponXP / reduce);

                    if (!CurrentGame.game.memoryGeneral.itemsOwned.weapons[numr].details.uniqueWeaponXps[numk].done)
                    {
                        if (totalGain >= levelUP)
                        {

                            unit.inventory.invSlot4.weapon.details.xp = 0;
                            CurrentGame.game.memoryGeneral.itemsOwned.weapons[numr].details.uniqueWeaponXps[numk].done = true;
                            if (!HasSkill(unit.inventory.invSlot4.weapon.details.unlocks, unit.idx))
                            {
                                UnitLearn(CurrentGame.game.memoryGeneral.itemsOwned.weapons[numr].details.unlocks, unit.idx);
                            }
                            if (CurrentGame.game.memoryGeneral.itemsOwned.weapons[numr].details.moreUnlocks.Count > 0)
                            {
                                foreach (string name in CurrentGame.game.memoryGeneral.itemsOwned.weapons[numr].details.moreUnlocks)
                                {
                                    if (!HasSkill(name, unit.idx)) UnitLearn(name, unit.idx);
                                }
                            }
                            unit.inventory.invSlot4.weapon = CurrentGame.game.memoryGeneral.itemsOwned.weapons[numr];
                            // ShadowLoader.LevelUpClass();
                        }
                        else
                        {
                            CurrentGame.game.memoryGeneral.itemsOwned.weapons[numr].details.uniqueWeaponXps[numk].xp = totalGain;
                            unit.inventory.invSlot4.weapon = CurrentGame.game.memoryGeneral.itemsOwned.weapons[numr];
                        }
                    }
                }
                else if (unit.inventory.invSlot4.assessory.inSlot)
                {
                    int totalGain = 0;
                    int reduce = 0;
                    int numr = CurrentGame.game.memoryGeneral.itemsOwned.assessories.FindIndex(x => x.idx == unit.inventory.invSlot4.assessory.idx);
                    if (!CurrentGame.game.memoryGeneral.itemsOwned.assessories[numr].details.uniqueAssessoryXps.Exists(x => x.idx == unit.idx))
                    {
                        CurrentGame.game.memoryGeneral.itemsOwned.assessories[numr].details.uniqueAssessoryXps.Add(new UnitUniqueAssessoryXp(unit.idx));
                        unit.inventory.invSlot4.assessory = CurrentGame.game.memoryGeneral.itemsOwned.assessories[numr];
                    }

                    int numk = CurrentGame.game.memoryGeneral.itemsOwned.assessories[numr].details.uniqueAssessoryXps.FindIndex(x => x.idx == unit.idx);
                    reduce = CurrentGame.game.memoryGeneral.itemsOwned.assessories[numr].details.rank - CurrentGame.game.memoryGeneral.currentLevel.powerRanking;
                    if (reduce < 1) reduce = 1;
                    totalGain = CurrentGame.game.memoryGeneral.itemsOwned.assessories[numr].details.uniqueAssessoryXps[numk].xp + (rewards.weaponXP / reduce);

                    if (!CurrentGame.game.memoryGeneral.itemsOwned.assessories[numr].details.uniqueAssessoryXps[numk].done)
                    {
                        if (totalGain >= levelUP)
                        {

                            unit.inventory.invSlot4.assessory.details.xp = 0;
                            CurrentGame.game.memoryGeneral.itemsOwned.assessories[numr].details.uniqueAssessoryXps[numk].done = true;
                            if (!HasSkill(unit.inventory.invSlot4.assessory.details.unlocks, unit.idx))
                            {
                                UnitLearn(CurrentGame.game.memoryGeneral.itemsOwned.assessories[numr].details.unlocks, unit.idx);
                            }
                            if (CurrentGame.game.memoryGeneral.itemsOwned.assessories[numr].details.moreUnlocks.Count > 0)
                            {
                                foreach (string name in CurrentGame.game.memoryGeneral.itemsOwned.assessories[numr].details.moreUnlocks)
                                {
                                    if (!HasSkill(name, unit.idx)) UnitLearn(name, unit.idx);
                                }
                            }
                            unit.inventory.invSlot4.assessory = CurrentGame.game.memoryGeneral.itemsOwned.assessories[numr];
                            // ShadowLoader.LevelUpClass();
                        }
                        else
                        {
                            CurrentGame.game.memoryGeneral.itemsOwned.assessories[numr].details.uniqueAssessoryXps[numk].xp = totalGain;
                            unit.inventory.invSlot4.assessory = CurrentGame.game.memoryGeneral.itemsOwned.assessories[numr];
                        }
                    }
                }
            }
            if (unit.inventory.invSlot5.holding != "")
            {
                if (unit.inventory.invSlot5.weapon.inSlot)
                {
                    int totalGain = 0;
                    int reduce = 0;
                    int numr = CurrentGame.game.memoryGeneral.itemsOwned.assessories.FindIndex(x => x.idx == unit.inventory.invSlot5.assessory.idx);
                    if (!CurrentGame.game.memoryGeneral.itemsOwned.assessories[numr].details.uniqueAssessoryXps.Exists(x => x.idx == unit.idx))
                    {
                        CurrentGame.game.memoryGeneral.itemsOwned.assessories[numr].details.uniqueAssessoryXps.Add(new UnitUniqueAssessoryXp(unit.idx));
                        unit.inventory.invSlot5.assessory = CurrentGame.game.memoryGeneral.itemsOwned.assessories[numr];
                    }

                    int numk = CurrentGame.game.memoryGeneral.itemsOwned.assessories[numr].details.uniqueAssessoryXps.FindIndex(x => x.idx == unit.idx);
                    reduce = CurrentGame.game.memoryGeneral.itemsOwned.assessories[numr].details.rank - CurrentGame.game.memoryGeneral.currentLevel.powerRanking;
                    if (reduce < 1) reduce = 1;
                    totalGain = CurrentGame.game.memoryGeneral.itemsOwned.assessories[numr].details.uniqueAssessoryXps[numk].xp + (rewards.weaponXP / reduce);

                    if (!CurrentGame.game.memoryGeneral.itemsOwned.assessories[numr].details.uniqueAssessoryXps[numk].done)
                    {
                        if (totalGain >= levelUP)
                        {

                            unit.inventory.invSlot5.assessory.details.xp = 0;
                            CurrentGame.game.memoryGeneral.itemsOwned.assessories[numr].details.uniqueAssessoryXps[numk].done = true;
                            if (!HasSkill(unit.inventory.invSlot5.assessory.details.unlocks, unit.idx))
                            {
                                UnitLearn(CurrentGame.game.memoryGeneral.itemsOwned.assessories[numr].details.unlocks, unit.idx);
                            }
                            if (CurrentGame.game.memoryGeneral.itemsOwned.weapons[numr].details.moreUnlocks.Count > 0)
                            {
                                foreach (string name in CurrentGame.game.memoryGeneral.itemsOwned.weapons[numr].details.moreUnlocks)
                                {
                                    if (!HasSkill(name, unit.idx)) UnitLearn(name, unit.idx);
                                }
                            }
                            unit.inventory.invSlot5.assessory = CurrentGame.game.memoryGeneral.itemsOwned.assessories[numr];
                            // ShadowLoader.LevelUpClass();
                        }
                        else
                        {
                            CurrentGame.game.memoryGeneral.itemsOwned.assessories[numr].details.uniqueAssessoryXps[numk].xp = totalGain;
                            unit.inventory.invSlot5.assessory = CurrentGame.game.memoryGeneral.itemsOwned.assessories[numr];
                        }
                    }
                }
                else if (unit.inventory.invSlot5.assessory.inSlot)
                {
                    int totalGain = 0;
                    int reduce = 0;
                    int numr = CurrentGame.game.memoryGeneral.itemsOwned.assessories.FindIndex(x => x.idx == unit.inventory.invSlot5.assessory.idx);
                    if (!CurrentGame.game.memoryGeneral.itemsOwned.assessories[numr].details.uniqueAssessoryXps.Exists(x => x.idx == unit.idx))
                    {
                        CurrentGame.game.memoryGeneral.itemsOwned.assessories[numr].details.uniqueAssessoryXps.Add(new UnitUniqueAssessoryXp(unit.idx));
                        unit.inventory.invSlot5.assessory = CurrentGame.game.memoryGeneral.itemsOwned.assessories[numr];
                    }

                    int numk = CurrentGame.game.memoryGeneral.itemsOwned.assessories[numr].details.uniqueAssessoryXps.FindIndex(x => x.idx == unit.idx);
                    reduce = CurrentGame.game.memoryGeneral.itemsOwned.assessories[numr].details.rank - CurrentGame.game.memoryGeneral.currentLevel.powerRanking;
                    if (reduce < 1) reduce = 1;
                    totalGain = CurrentGame.game.memoryGeneral.itemsOwned.assessories[numr].details.uniqueAssessoryXps[numk].xp + (rewards.weaponXP / reduce);

                    if (!CurrentGame.game.memoryGeneral.itemsOwned.assessories[numr].details.uniqueAssessoryXps[numk].done)
                    {
                        if (totalGain >= levelUP)
                        {

                            unit.inventory.invSlot5.assessory.details.xp = 0;
                            CurrentGame.game.memoryGeneral.itemsOwned.assessories[numr].details.uniqueAssessoryXps[numk].done = true;
                            if (!HasSkill(unit.inventory.invSlot5.assessory.details.unlocks, unit.idx))
                            {
                                UnitLearn(CurrentGame.game.memoryGeneral.itemsOwned.assessories[numr].details.unlocks, unit.idx);
                            }
                            if (CurrentGame.game.memoryGeneral.itemsOwned.assessories[numr].details.moreUnlocks.Count > 0)
                            {
                                foreach (string name in CurrentGame.game.memoryGeneral.itemsOwned.assessories[numr].details.moreUnlocks)
                                {
                                    UnitLearn(name, unit.idx);
                                }
                            }
                            unit.inventory.invSlot5.assessory = CurrentGame.game.memoryGeneral.itemsOwned.assessories[numr];
                            // ShadowLoader.LevelUpClass();
                        }
                        else
                        {
                            CurrentGame.game.memoryGeneral.itemsOwned.assessories[numr].details.uniqueAssessoryXps[numk].xp = totalGain;
                            unit.inventory.invSlot5.assessory = CurrentGame.game.memoryGeneral.itemsOwned.assessories[numr];
                        }
                    }
                }
            }
        }

    }


   
    /* else if (CurrentGame.game.memoryGeneral.impClassProgress.magus.present == true)
       {
      int levelUP = 100;
      int pLevelUp = 500;
      int totalGain = 0;
      int powerGain = 0;
      int reduce = 0;
      reduce = CurrentGame.game.memoryGeneral.impClassProgress.magus.powerLevel - CurrentGame.game.memoryGeneral.currentLevel.powerRanking;
      if (reduce < 1) reduce = 1;
      totalGain = CurrentGame.game.memoryGeneral.impClassProgress.magus.xp + (rewards.unitXp / reduce);
      powerGain = totalGain + CurrentGame.game.memoryGeneral.impClassProgress.magus.pxp;
      if (totalGain >= levelUP)
      {
          if (powerGain >= pLevelUp)
          {
              CurrentGame.game.memoryGeneral.impClassProgress.magus.pxp = 0;
              CurrentGame.game.memoryGeneral.impClassProgress.magus.powerLevel += 1;
              CurrentGame.game.memoryGeneral.impClassProgress.magus.xp = 0;
          }
          else
          {
              CurrentGame.game.memoryGeneral.impClassProgress.magus.xp = 0;
              CurrentGame.game.memoryGeneral.impClassProgress.magus.pxp = powerGain;
          }

          // MagusLoader.LevelUpClass();
      }
      else
      {
          if (powerGain >= pLevelUp)
          {
              CurrentGame.game.memoryGeneral.impClassProgress.magus.pxp = 0;
              CurrentGame.game.memoryGeneral.impClassProgress.magus.powerLevel += 1;
              CurrentGame.game.memoryGeneral.impClassProgress.magus.xp = totalGain;
          }
          else
          {
              CurrentGame.game.memoryGeneral.impClassProgress.magus.pxp = powerGain;
              CurrentGame.game.memoryGeneral.impClassProgress.magus.xp = totalGain;
          }
      }
    }*/
    /* else if (CurrentGame.game.memoryGeneral.viraClassProgress.chronos.present == true)
     {
         int levelUP = 100;
         int pLevelUp = 500;
         int totalGain = 0;
         int powerGain = 0;
         int reduce = 0;
         reduce = CurrentGame.game.memoryGeneral.viraClassProgress.chronos.powerLevel - CurrentGame.game.memoryGeneral.currentLevel.powerRanking;
         if (reduce < 1) reduce = 1;
         totalGain = CurrentGame.game.memoryGeneral.viraClassProgress.chronos.xp + (rewards.unitXp / reduce);
         powerGain = totalGain + CurrentGame.game.memoryGeneral.viraClassProgress.chronos.pxp;
         if (totalGain >= levelUP)
         {
             if (powerGain >= pLevelUp)
             {
                 CurrentGame.game.memoryGeneral.viraClassProgress.chronos.pxp = 0;
                 CurrentGame.game.memoryGeneral.viraClassProgress.chronos.powerLevel += 1;
                 CurrentGame.game.memoryGeneral.viraClassProgress.chronos.xp = 0;
             }
             else
             {
                 CurrentGame.game.memoryGeneral.viraClassProgress.chronos.xp = 0;
                 CurrentGame.game.memoryGeneral.viraClassProgress.chronos.pxp = powerGain;
             }

             // ChronosLoader.LevelUpClass();
         }
         else
         {
             if (powerGain >= pLevelUp)
             {
                 CurrentGame.game.memoryGeneral.viraClassProgress.chronos.pxp = 0;
                 CurrentGame.game.memoryGeneral.viraClassProgress.chronos.powerLevel += 1;
                 CurrentGame.game.memoryGeneral.viraClassProgress.chronos.xp = totalGain;
             }
             else
             {
                 CurrentGame.game.memoryGeneral.viraClassProgress.chronos.pxp = powerGain;
                 CurrentGame.game.memoryGeneral.viraClassProgress.chronos.xp = totalGain;
             }
         }
     }
     else if (CurrentGame.game.memoryGeneral.viraClassProgress.alchemist.present == true)
     {
         int levelUP = 100;
         int pLevelUp = 500;
         int totalGain = 0;
         int powerGain = 0;
         int reduce = 0;
         reduce = CurrentGame.game.memoryGeneral.viraClassProgress.alchemist.powerLevel - CurrentGame.game.memoryGeneral.currentLevel.powerRanking;
         if (reduce < 1) reduce = 1;
         totalGain = CurrentGame.game.memoryGeneral.viraClassProgress.alchemist.xp + (rewards.unitXp / reduce);
         powerGain = totalGain + CurrentGame.game.memoryGeneral.viraClassProgress.alchemist.pxp;
         if (totalGain >= levelUP)
         {
             if (powerGain >= pLevelUp)
             {
                 CurrentGame.game.memoryGeneral.viraClassProgress.alchemist.pxp = 0;
                 CurrentGame.game.memoryGeneral.viraClassProgress.alchemist.powerLevel += 1;
                 CurrentGame.game.memoryGeneral.viraClassProgress.alchemist.xp = 0;
             }
             else
             {
                 CurrentGame.game.memoryGeneral.viraClassProgress.alchemist.xp = 0;
                 CurrentGame.game.memoryGeneral.viraClassProgress.alchemist.pxp = powerGain;
             }

             // AlchemistLoader.LevelUpClass();
         }
         else
         {
             if (powerGain >= pLevelUp)
             {
                 CurrentGame.game.memoryGeneral.viraClassProgress.alchemist.pxp = 0;
                 CurrentGame.game.memoryGeneral.viraClassProgress.alchemist.powerLevel += 1;
                 CurrentGame.game.memoryGeneral.viraClassProgress.alchemist.xp = totalGain;
             }
             else
             {
                 CurrentGame.game.memoryGeneral.viraClassProgress.alchemist.pxp = powerGain;
                 CurrentGame.game.memoryGeneral.viraClassProgress.alchemist.xp = totalGain;
             }
         }
     }
     else if (CurrentGame.game.memoryGeneral.viraClassProgress.geomancer.present == true)
     {
         int levelUP = 100;
         int pLevelUp = 500;
         int totalGain = 0;
         int powerGain = 0;
         int reduce = 0;
         reduce = CurrentGame.game.memoryGeneral.viraClassProgress.geomancer.powerLevel - CurrentGame.game.memoryGeneral.currentLevel.powerRanking;
         if (reduce < 1) reduce = 1;
         totalGain = CurrentGame.game.memoryGeneral.viraClassProgress.geomancer.xp + (rewards.unitXp / reduce);
         powerGain = totalGain + CurrentGame.game.memoryGeneral.viraClassProgress.geomancer.pxp;
         if (totalGain >= levelUP)
         {
             if (powerGain >= pLevelUp)
             {
                 CurrentGame.game.memoryGeneral.viraClassProgress.geomancer.pxp = 0;
                 CurrentGame.game.memoryGeneral.viraClassProgress.geomancer.powerLevel += 1;
                 CurrentGame.game.memoryGeneral.viraClassProgress.geomancer.xp = 0;
             }
             else
             {
                 CurrentGame.game.memoryGeneral.viraClassProgress.geomancer.xp = 0;
                 CurrentGame.game.memoryGeneral.viraClassProgress.geomancer.pxp = powerGain;
             }

             // GeomancerLoader.LevelUpClass();
         }
         else
         {
             if (powerGain >= pLevelUp)
             {
                 CurrentGame.game.memoryGeneral.viraClassProgress.geomancer.pxp = 0;
                 CurrentGame.game.memoryGeneral.viraClassProgress.geomancer.powerLevel += 1;
                 CurrentGame.game.memoryGeneral.viraClassProgress.geomancer.xp = totalGain;
             }
             else
             {
                 CurrentGame.game.memoryGeneral.viraClassProgress.geomancer.pxp = powerGain;
                 CurrentGame.game.memoryGeneral.viraClassProgress.geomancer.xp = totalGain;
             }
         }
     }
     else if (CurrentGame.game.memoryGeneral.viraClassProgress.kensai.present == true)
     {
         int levelUP = 100;
         int pLevelUp = 500;
         int totalGain = 0;
         int powerGain = 0;
         int reduce = 0;
         reduce = CurrentGame.game.memoryGeneral.viraClassProgress.kensai.powerLevel - CurrentGame.game.memoryGeneral.currentLevel.powerRanking;
         if (reduce < 1) reduce = 1;
         totalGain = CurrentGame.game.memoryGeneral.viraClassProgress.kensai.xp + (rewards.unitXp / reduce);
         powerGain = totalGain + CurrentGame.game.memoryGeneral.viraClassProgress.kensai.pxp;
         if (totalGain >= levelUP)
         {
             if (powerGain >= pLevelUp)
             {
                 CurrentGame.game.memoryGeneral.viraClassProgress.kensai.pxp = 0;
                 CurrentGame.game.memoryGeneral.viraClassProgress.kensai.powerLevel += 1;
                 CurrentGame.game.memoryGeneral.viraClassProgress.kensai.xp = 0;
             }
             else
             {
                 CurrentGame.game.memoryGeneral.viraClassProgress.kensai.xp = 0;
                 CurrentGame.game.memoryGeneral.viraClassProgress.kensai.pxp = powerGain;
             }

             // KensairLoader.LevelUpClass();
         }
         else
         {
             if (powerGain >= pLevelUp)
             {
                 CurrentGame.game.memoryGeneral.viraClassProgress.kensai.pxp = 0;
                 CurrentGame.game.memoryGeneral.viraClassProgress.kensai.powerLevel += 1;
                 CurrentGame.game.memoryGeneral.viraClassProgress.kensai.xp = totalGain;
             }
             else
             {
                 CurrentGame.game.memoryGeneral.viraClassProgress.kensai.pxp = powerGain;
                 CurrentGame.game.memoryGeneral.viraClassProgress.kensai.xp = totalGain;
             }
         }
     }
     else if (CurrentGame.game.memoryGeneral.viraClassProgress.onmiyoji.present == true)
     {
         int levelUP = 100;
         int pLevelUp = 500;
         int totalGain = 0;
         int powerGain = 0;
         int reduce = 0;
         reduce = CurrentGame.game.memoryGeneral.viraClassProgress.onmiyoji.powerLevel - CurrentGame.game.memoryGeneral.currentLevel.powerRanking;
         if (reduce < 1) reduce = 1;
         totalGain = CurrentGame.game.memoryGeneral.viraClassProgress.onmiyoji.xp + (rewards.unitXp / reduce);
         powerGain = totalGain + CurrentGame.game.memoryGeneral.viraClassProgress.onmiyoji.pxp;
         if (totalGain >= levelUP)
         {
             if (powerGain >= pLevelUp)
             {
                 CurrentGame.game.memoryGeneral.viraClassProgress.onmiyoji.pxp = 0;
                 CurrentGame.game.memoryGeneral.viraClassProgress.onmiyoji.powerLevel += 1;
                 CurrentGame.game.memoryGeneral.viraClassProgress.onmiyoji.xp = 0;
             }
             else
             {
                 CurrentGame.game.memoryGeneral.viraClassProgress.onmiyoji.xp = 0;
                 CurrentGame.game.memoryGeneral.viraClassProgress.onmiyoji.pxp = powerGain;
             }

             // OnmiyojiLoader.LevelUpClass();
         }
         else
         {
             if (powerGain >= pLevelUp)
             {
                 CurrentGame.game.memoryGeneral.viraClassProgress.onmiyoji.pxp = 0;
                 CurrentGame.game.memoryGeneral.viraClassProgress.onmiyoji.powerLevel += 1;
                 CurrentGame.game.memoryGeneral.viraClassProgress.onmiyoji.xp = totalGain;
             }
             else
             {
                 CurrentGame.game.memoryGeneral.viraClassProgress.onmiyoji.pxp = powerGain;
                 CurrentGame.game.memoryGeneral.viraClassProgress.onmiyoji.xp = totalGain;
             }
         }
     }
     else if (CurrentGame.game.memoryGeneral.viraClassProgress.wardancer.present == true)
     {
         int levelUP = 100;
         int pLevelUp = 500;
         int totalGain = 0;
         int powerGain = 0;
         int reduce = 0;
         reduce = CurrentGame.game.memoryGeneral.viraClassProgress.wardancer.powerLevel - CurrentGame.game.memoryGeneral.currentLevel.powerRanking;
         if (reduce < 1) reduce = 1;
         totalGain = CurrentGame.game.memoryGeneral.viraClassProgress.wardancer.xp + (rewards.unitXp / reduce);
         powerGain = totalGain + CurrentGame.game.memoryGeneral.viraClassProgress.wardancer.pxp;
         if (totalGain >= levelUP)
         {
             if (powerGain >= pLevelUp)
             {
                 CurrentGame.game.memoryGeneral.viraClassProgress.wardancer.pxp = 0;
                 CurrentGame.game.memoryGeneral.viraClassProgress.wardancer.powerLevel += 1;
                 CurrentGame.game.memoryGeneral.viraClassProgress.wardancer.xp = 0;
             }
             else
             {
                 CurrentGame.game.memoryGeneral.viraClassProgress.wardancer.xp = 0;
                 CurrentGame.game.memoryGeneral.viraClassProgress.wardancer.pxp = powerGain;
             }

             // WardancerLoader.LevelUpClass();
         }
         else
         {
             if (powerGain >= pLevelUp)
             {
                 CurrentGame.game.memoryGeneral.viraClassProgress.wardancer.pxp = 0;
                 CurrentGame.game.memoryGeneral.viraClassProgress.wardancer.powerLevel += 1;
                 CurrentGame.game.memoryGeneral.viraClassProgress.wardancer.xp = totalGain;
             }
             else
             {
                 CurrentGame.game.memoryGeneral.viraClassProgress.wardancer.pxp = powerGain;
                 CurrentGame.game.memoryGeneral.viraClassProgress.wardancer.xp = totalGain;
             }
         }
     }*/

    public static void UnitLearn(string skill, string idx)
    {
        Unit u = CurrentGame.game.storeroom.units.Find(x => x.idx == idx);
        UnitHumanClass hum = u.unitClass.main.human;
        UnitViraClass vira = u.unitClass.main.vira;
        UnitImpClass imp = u.unitClass.main.imp;
        if (hum.warrior.name == u.unitClass.main.mainClass) hum.warrior.present = true;
        else if (hum.mage.name == u.unitClass.main.mainClass) hum.mage.present = true;
        else if (hum.priest.name == u.unitClass.main.mainClass) hum.priest.present = true;
        else if (hum.rogue.name == u.unitClass.main.mainClass) hum.rogue.present = true;
        else if (hum.cavalier.name == u.unitClass.main.mainClass) hum.cavalier.present = true;
        else if (hum.bard.name == u.unitClass.main.mainClass) hum.bard.present = true;
        else if (hum.archer.name == u.unitClass.main.mainClass) hum.archer.present = true;
        else if (hum.assassin.name == u.unitClass.main.mainClass) hum.assassin.present = true;
        else if (hum.charger.name == u.unitClass.main.mainClass) hum.charger.present = true;
        else if (hum.sniper.name == u.unitClass.main.mainClass) hum.sniper.present = true;
        else if (hum.paladin.name == u.unitClass.main.mainClass) hum.paladin.present = true;
        else if (hum.knight.name == u.unitClass.main.mainClass) hum.knight.present = true;
        /*else if (vira.alchemist.name == u.unitClass.main.mainClass) vira.alchemist.present = true;
        else if (vira.chronos.name == u.unitClass.main.mainClass) vira.chronos.present = true;
        else if (vira.geomancer.name == u.unitClass.main.mainClass) vira.geomancer.present = true;
        else if (vira.kensai.name == u.unitClass.main.mainClass) vira.kensai.present = true;
        else if (vira.onmiyoji.name == u.unitClass.main.mainClass) vira.onmiyoji.present = true;
        else if (vira.wardancer.name == u.unitClass.main.mainClass) vira.wardancer.present = true;*/

        else if (imp.dread.name == u.unitClass.main.mainClass) imp.dread.present = true;
        else if (imp.fusilier.name == u.unitClass.main.mainClass) imp.fusilier.present = true;
        else if (imp.duelist.name == u.unitClass.main.mainClass) imp.duelist.present = true;
        else if (imp.shrike.name == u.unitClass.main.mainClass) imp.shrike.present = true;
        else if (imp.swashbuckler.name == u.unitClass.main.mainClass) imp.swashbuckler.present = true;
        else if (imp.shadow.name == u.unitClass.main.mainClass) imp.shadow.present = true;
        else if (imp.cannoneer.name == u.unitClass.main.mainClass) imp.cannoneer.present = true;
        else if (imp.darkknight.name == u.unitClass.main.mainClass) imp.darkknight.present = true;
        else if (imp.demonRider.name == u.unitClass.main.mainClass) imp.demonRider.present = true;
        else if (imp.nightblade.name == u.unitClass.main.mainClass) imp.nightblade.present = true;


        if (hum.warrior.present == true)
        {
            WarriorLoader.AssignSkill(skill, u.unitClass.main.human.warrior.pickSkill, u);
            ClassUnlock.CheckOnClass(u);
        }
        else if (hum.mage.present == true)
        {
            MageLoader.AssignSkill(skill, u.unitClass.main.human.mage.pickSkill);
            ClassUnlock.CheckOnClass(u);
        }
        else if (hum.priest.present == true)
        {
            PriestLoader.AssignSkill(skill, u.unitClass.main.human.priest.pickSkill);
            ClassUnlock.CheckOnClass(u);
        }
        else if (hum.rogue.present == true)
        {
            RogueLoader.AssignSkill(skill, u.unitClass.main.human.rogue.pickSkill);
            ClassUnlock.CheckOnClass(u);

        }
        else if (hum.cavalier.present == true)
        {
            CavalierLoader.AssignSkill(skill, u.unitClass.main.human.cavalier.pickSkill);
            ClassUnlock.CheckOnClass(u);
        }
        else if (hum.bard.present == true)
        {
            BardLoader.AssignSkill(skill, u.unitClass.main.human.bard.pickSkill, u);
            ClassUnlock.CheckOnClass(u);

        }
        else if (hum.archer.present == true)
        {
            ArcherLoader.AssignSkill(skill, u.unitClass.main.human.archer.pickSkill);
            ClassUnlock.CheckOnClass(u);
        }
        else if (hum.sniper.present == true)
        {
            SniperLoader.AssignSkill(skill, u.unitClass.main.human.sniper.pickSkill, u);
            ClassUnlock.CheckOnClass(u);
        }
        else if (hum.charger.present == true)
        {
            ChargerLoader.AssignSkill(skill, u.unitClass.main.human.charger.pickSkill, u);
            ClassUnlock.CheckOnClass(u);
        }
        else if (hum.knight.present == true)
        {
            KnightLoader.AssignSkill(skill, u.unitClass.main.human.knight.pickSkill, u);
            ClassUnlock.CheckOnClass(u);
        }
        else if (hum.paladin.present == true)
        {
            SniperLoader.AssignSkill(skill, u.unitClass.main.human.paladin.pickSkill, u);
            ClassUnlock.CheckOnClass(u);
        }
        else if (hum.assassin.present == true)
        {
            AssassinLoader.AssignSkill(skill, u.unitClass.main.human.assassin.pickSkill, u);
            ClassUnlock.CheckOnClass(u);
        }
       

        else if (imp.dread.present == true)
        {
            DreadLoader.AssignSkill(skill, u.unitClass.main.imp.dread.pickSkill);
            ClassUnlock.CheckOnClass(u);
        }
        else if (imp.fusilier.present == true)
        {
            FusilierLoader.AssignSkill(skill, u.unitClass.main.imp.fusilier.pickSkill);
            ClassUnlock.CheckOnClass(u);
        }
    
        else if (imp.shrike.present == true)
        {
            ShrikeLoader.AssignSkill(skill, u.unitClass.main.imp.shrike.pickSkill);
            ClassUnlock.CheckOnClass(u);
        }
        else if (imp.swashbuckler.present == true)
        {
            SwashbucklerLoader.AssignSkill(skill, u.unitClass.main.imp.swashbuckler.pickSkill);
            ClassUnlock.CheckOnClass(u);
        }
        else if (imp.shadow.present == true)
        {
            ShadowLoader.AssignSkill(skill, u.unitClass.main.imp.shadow.pickSkill);
            ClassUnlock.CheckOnClass(u);
        }
        else if (imp.duelist.present == true)
        {
            DuelistLoader.AssignSkill(skill, u.unitClass.main.imp.duelist.pickSkill, u);
            ClassUnlock.CheckOnClass(u);
        }
        else if (imp.cannoneer.present == true)
        {
            CannoneerLoader.AssignSkill(skill, u.unitClass.main.imp.cannoneer.pickSkill, u);
            ClassUnlock.CheckOnClass(u);
        }
        else if (imp.darkknight.present == true)
        {
            DarkKnightLoader.AssignSkill(skill, u.unitClass.main.imp.darkknight.pickSkill, u);
            ClassUnlock.CheckOnClass(u);
        }
        else if (imp.demonRider.present == true)
        {
            DemonRiderLoader.AssignSkill(skill, u.unitClass.main.imp.demonRider.pickSkill, u);
            ClassUnlock.CheckOnClass(u);
        }
        else if (imp.nightblade.present == true)
        {
            NightBladeLoader.AssignSkill(skill, u.unitClass.main.imp.nightblade.pickSkill, u);
            ClassUnlock.CheckOnClass(u);
        }

    }

    /*  else if (vira.chronos.present == true)
       {
           WarriorLoader.AssignSkill(skill, u.unitClass.main.vira.chronos.pickSkill);

       }
       else if (vira.alchemist.present == true)
       {
           WarriorLoader.AssignSkill(skill, u.unitClass.main.vira.alchemist.pickSkill);
       }
       else if (vira.geomancer.present == true)
       {
           WarriorLoader.AssignSkill(skill, u.unitClass.main.vira.geomancer.pickSkill);
       }
       else if (vira.kensai.present == true)
       {
           WarriorLoader.AssignSkill(skill, u.unitClass.main.vira.kensai.pickSkill);
       }
       else if (vira.onmiyoji.present == true)
       {
           WarriorLoader.AssignSkill(skill, u.unitClass.main.vira.onmiyoji.pickSkill);
       }
       else if (vira.wardancer.present == true)
       {
           WarriorLoader.AssignSkill(skill, u.unitClass.main.vira.wardancer.pickSkill);
       }*/

    public static bool HasSkill(string skill, string idx)
    {
        Unit u = CurrentGame.game.storeroom.units.Find(x => x.idx == idx);
        UnitHumanClass hum = u.unitClass.main.human;
        UnitViraClass vira = u.unitClass.main.vira;
        UnitImpClass imp = u.unitClass.main.imp;
        if (hum.warrior.name == u.unitClass.main.mainClass) hum.warrior.present = true;
        else if (hum.mage.name == u.unitClass.main.mainClass) hum.mage.present = true;
        else if (hum.priest.name == u.unitClass.main.mainClass) hum.priest.present = true;
        else if (hum.rogue.name == u.unitClass.main.mainClass) hum.rogue.present = true;
        else if (hum.cavalier.name == u.unitClass.main.mainClass) hum.cavalier.present = true;
        else if (hum.bard.name == u.unitClass.main.mainClass) hum.bard.present = true;
        else if (hum.archer.name == u.unitClass.main.mainClass) hum.archer.present = true;
        else if (hum.assassin.name == u.unitClass.main.mainClass) hum.assassin.present = true;
        else if (hum.charger.name == u.unitClass.main.mainClass) hum.charger.present = true;
        else if (hum.sniper.name == u.unitClass.main.mainClass) hum.sniper.present = true;
        else if (hum.paladin.name == u.unitClass.main.mainClass) hum.paladin.present = true;
        else if (hum.knight.name == u.unitClass.main.mainClass) hum.knight.present = true;
        /*else if (vira.alchemist.name == u.unitClass.main.mainClass) vira.alchemist.present = true;
        else if (vira.chronos.name == u.unitClass.main.mainClass) vira.chronos.present = true;
        else if (vira.geomancer.name == u.unitClass.main.mainClass) vira.geomancer.present = true;
        else if (vira.kensai.name == u.unitClass.main.mainClass) vira.kensai.present = true;
        else if (vira.onmiyoji.name == u.unitClass.main.mainClass) vira.onmiyoji.present = true;
        else if (vira.wardancer.name == u.unitClass.main.mainClass) vira.wardancer.present = true;*/

        else if (imp.dread.name == u.unitClass.main.mainClass) imp.dread.present = true;
        else if (imp.fusilier.name == u.unitClass.main.mainClass) imp.fusilier.present = true;
        else if (imp.duelist.name == u.unitClass.main.mainClass) imp.duelist.present = true;
        else if (imp.shrike.name == u.unitClass.main.mainClass) imp.shrike.present = true;
        else if (imp.swashbuckler.name == u.unitClass.main.mainClass) imp.swashbuckler.present = true;
        else if (imp.shadow.name == u.unitClass.main.mainClass) imp.shadow.present = true;
        else if (imp.cannoneer.name == u.unitClass.main.mainClass) imp.cannoneer.present = true;
        else if (imp.darkknight.name == u.unitClass.main.mainClass) imp.darkknight.present = true;
        else if (imp.demonRider.name == u.unitClass.main.mainClass) imp.demonRider.present = true;
        else if (imp.nightblade.name == u.unitClass.main.mainClass) imp.nightblade.present = true;


        if (hum.warrior.present == true)
        {
            return WarriorLoader.HasSkill(skill, u.unitClass.main.human.warrior.pickSkill);
        }
        else if (hum.mage.present == true)
        {
            return MageLoader.HasSkill(skill, u.unitClass.main.human.mage.pickSkill);
        }
        else if (hum.priest.present == true)
        {
            return PriestLoader.HasSkill(skill, u.unitClass.main.human.priest.pickSkill);
        }
        else if (hum.rogue.present == true)
        {
            return RogueLoader.HasSkill(skill, u.unitClass.main.human.rogue.pickSkill);
        }
        else if (hum.cavalier.present == true)
        {
            return CavalierLoader.HasSkill(skill, u.unitClass.main.human.cavalier.pickSkill);
        }
        else if (hum.bard.present == true)
        {
            return BardLoader.HasSkill(skill, u.unitClass.main.human.bard.pickSkill);
        }
        else if (hum.archer.present == true)
        {
            return ArcherLoader.HasSkill(skill, u.unitClass.main.human.archer.pickSkill);
        }
        else if (hum.sniper.present == true)
        {
            return SniperLoader.HasSkill(skill, u.unitClass.main.human.sniper.pickSkill);
        }
        else if (hum.charger.present == true)
        {
            return ChargerLoader.HasSkill(skill, u.unitClass.main.human.charger.pickSkill);
        }
        else if (hum.knight.present == true)
        {
            return KnightLoader.HasSkill(skill, u.unitClass.main.human.knight.pickSkill);
        }
        else if (hum.paladin.present == true)
        {
            return PaladinLoader.HasSkill(skill, u.unitClass.main.human.paladin.pickSkill);
        }
        else if (hum.assassin.present == true)
        {
            return AssassinLoader.HasSkill(skill, u.unitClass.main.human.assassin.pickSkill);
        }
        /*   else if (vira.chronos.present == true)
           {
               return WarriorLoader.HasSkill(skill, u.unitClass.main.vira.chronos.pickSkill);

           }
           else if (vira.alchemist.present == true)
           {
               return WarriorLoader.HasSkill(skill, u.unitClass.main.vira.alchemist.pickSkill);
           }
           else if (vira.geomancer.present == true)
           {
               return WarriorLoader.HasSkill(skill, u.unitClass.main.vira.geomancer.pickSkill);
           }
           else if (vira.kensai.present == true)
           {
               return WarriorLoader.HasSkill(skill, u.unitClass.main.vira.kensai.pickSkill);
           }
           else if (vira.onmiyoji.present == true)
           {
               return WarriorLoader.HasSkill(skill, u.unitClass.main.vira.onmiyoji.pickSkill);
           }
           else if (vira.wardancer.present == true)
           {
               return WarriorLoader.HasSkill(skill, u.unitClass.main.vira.wardancer.pickSkill);
           }*/

        else if (imp.dread.present == true)
        {
           return DreadLoader.HasSkill(skill, u.unitClass.main.imp.dread.pickSkill);
        }
        else if (imp.fusilier.present == true)
        {
           return FusilierLoader.HasSkill(skill, u.unitClass.main.imp.fusilier.pickSkill);
        }

        else if (imp.shrike.present == true)
        {
           return ShrikeLoader.HasSkill(skill, u.unitClass.main.imp.shrike.pickSkill);
        }
        else if (imp.swashbuckler.present == true)
        {
            return SwashbucklerLoader.HasSkill(skill, u.unitClass.main.imp.swashbuckler.pickSkill);
        }
        else if (imp.shadow.present == true)
        {
           return ShadowLoader.HasSkill(skill, u.unitClass.main.imp.shadow.pickSkill);
        }
        else if (imp.duelist.present == true)
        {
            return DuelistLoader.HasSkill(skill, u.unitClass.main.imp.duelist.pickSkill);
        }    
        else if (imp.cannoneer.present == true)
        {
            return CannoneerLoader.HasSkill(skill, u.unitClass.main.imp.cannoneer.pickSkill);
        }
        else if (imp.darkknight.present == true)
        {
            return DarkKnightLoader.HasSkill(skill, u.unitClass.main.imp.darkknight.pickSkill);
        }
        else if (imp.demonRider.present == true)
        {
            return DemonRiderLoader.HasSkill(skill, u.unitClass.main.imp.demonRider.pickSkill);
        }
        else if (imp.nightblade.present == true)
        {
            return NightBladeLoader.HasSkill(skill, u.unitClass.main.imp.nightblade.pickSkill);
        }

        return false;
    }


}
