﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BardLoader : MonoBehaviour {
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public static void NewClass()
    {
        Bard.Clear();
        Bard.level = 0;
        CurrentGame.game.memoryGeneral.humanClassProgress.bard.level = 0;
        CurrentGame.game.memoryGeneral.humanClassProgress.bard.name = "Bard";
        CurrentGame.game.memoryGeneral.humanClassProgress.bard.movement = 5;
        CurrentGame.game.memoryGeneral.humanClassProgress.bard.classWeapons.classWeapon1.type = "Light Blades";
        CurrentGame.game.memoryGeneral.humanClassProgress.bard.classWeapons.classWeapon1.rank = 3;
        CurrentGame.game.memoryGeneral.humanClassProgress.bard.classWeapons.classWeapon2.type = "Athames";
        CurrentGame.game.memoryGeneral.humanClassProgress.bard.classWeapons.classWeapon2.rank = 3;

        LevelUpClass();
    }


    public static void LevelUpClass()
    {
        Bard.LevelUp();
        CurrentGame.game.memoryGeneral.humanClassProgress.bard.level = CurrentGame.game.memoryGeneral.humanClassProgress.bard.level + 1;
        CurrentGame.game.memoryGeneral.humanClassProgress.bard.modifiers = Bard.ModList();

        foreach (string id in CurrentGame.game.memoryGeneral.humanClassProgress.bard.subbed)
        {
            Unit me = new Unit();
            foreach (Unit u in CurrentGame.game.storeroom.units)
            {
                if (id == u.unitID)
                {
                    u.unitClass.main.human.bard.modifiers = CurrentGame.game.memoryGeneral.humanClassProgress.bard.modifiers;
                    u.unitClass.main.human.bard.level = CurrentGame.game.memoryGeneral.humanClassProgress.bard.level;
                }
            }
        }
    }

    public static void ClassUnlocked(Unit me)
    {
        me.unitClass.main.human.bard.unlocked = true;
    }

    public static int HowManySkills(UnitClassSkill u)
    {
        int i = 0;

        if (u.skill1.name != "")
        {
            i++;
        }
        else if (u.skill2.name != "")
        {
            i++;
        }
        else if (u.skill3.name != "")
        {
            i++;
        }
        else if (u.skill4.name != "")
        {
            i++;
        }
        else if (u.skill5.name != "")
        {
            i++;
        }
        else if (u.skill6.name != "")
        {
            i++;
        }
        else if (u.skill7.name != "")
        {
            i++;
        }
        return i;
    }

    public static bool HasSkill(string sk, UnitClassSkill u)
    {

        if (u.skill1.name == sk)
        {
            return true;
        }
        else if (u.skill2.name == sk)
        {
            return true;
        }
        else if (u.skill3.name == sk)
        {
            return true;
        }
        else if (u.skill4.name == sk)
        {
            return true;
        }
        else if (u.skill5.name == sk)
        {
            return true;
        }
        else if (u.skill6.name == sk)
        {
            return true;
        }
        else if (u.skill7.name == sk)
        {
            return true;
        }

        return false;

    }

    public static void AssignSkill(string sk, UnitClassSkill u, Unit un)
    {
        UnitSkillDetail burningMelody = new UnitSkillDetail();
        burningMelody.name = "Burning Melody";
        burningMelody.effects.fireDamage = true;
        burningMelody.effects.berserk = true;
        burningMelody.magicDamage = true;
        burningMelody.range = 4;
        burningMelody.attackPattern = "cross";

        UnitSkillDetail hymnOfFrozenLoss = new UnitSkillDetail();
        hymnOfFrozenLoss.name = "Frozen Dirge";
        hymnOfFrozenLoss.effects.waterDamage = true;
        hymnOfFrozenLoss.magicDamage = true;
        hymnOfFrozenLoss.effects.stun = true;
        hymnOfFrozenLoss.range = 4;
        hymnOfFrozenLoss.attackPattern = "4 tile line";

        UnitSkillDetail thunderAnthem = new UnitSkillDetail();
        thunderAnthem.name = "Thunder Anthem";
        thunderAnthem.effects.natureDamage = true;
        thunderAnthem.effects.confuse = true;
        thunderAnthem.magicDamage = true;
        thunderAnthem.range = 4;
        thunderAnthem.attackPattern = "4x5 cone";

        UnitSkillDetail songOfLife = new UnitSkillDetail();
        songOfLife.restore = 1;//restore half magic stat life
        songOfLife.range = 3;
        songOfLife.effects.statusHeal = true;
        songOfLife.attackPattern = "3 tile cross";
        songOfLife.name = "Song of Life";


        UnitSkillDetail riddleOfSteel = new UnitSkillDetail();
        riddleOfSteel.name = "Riddle of Steel";
        riddleOfSteel.effects.attackBoost = true;//if target is suffering a debuff, deal extra damage
        riddleOfSteel.effects.defenseBoost = true;//Use Def instead of Str for counter
        riddleOfSteel.range = 4;

        UnitSkillDetail dirgeOfSpelldeath = new UnitSkillDetail();
        dirgeOfSpelldeath.name = "Dirge of Spelldeath";
        dirgeOfSpelldeath.range = 4;
        dirgeOfSpelldeath.effects.reduceAttack = true;
        dirgeOfSpelldeath.effects.reduceDefense = true;
        dirgeOfSpelldeath.magicDamage = true;
        dirgeOfSpelldeath.effects.darkDamage = true;

        UnitSkillDetail raptureOfTheSong = new UnitSkillDetail();
        raptureOfTheSong.name = "Rapture of the Song";
        raptureOfTheSong.support = true;
        raptureOfTheSong.effects.magicDefenseBoost = true;
        raptureOfTheSong.effects.defenseBoost = true;//increase debuff duration

        if (sk == burningMelody.name)
        {
            u.skill1 = burningMelody;
        }
        else if (sk == hymnOfFrozenLoss.name)
        {
            u.skill2 = hymnOfFrozenLoss;
        }
        else if (sk == thunderAnthem.name)
        {
            u.skill3 = thunderAnthem;
        }
        else if (sk == songOfLife.name)
        {
            u.skill4 = songOfLife;
        }
        else if (sk == riddleOfSteel.name)
        {
            u.skill5 = riddleOfSteel;
        }
        else if (sk == dirgeOfSpelldeath.name)
        {
            u.skill6 = dirgeOfSpelldeath;
        }
        else if (sk == raptureOfTheSong.name)
        {
            u.skill7 = raptureOfTheSong;
        }
        else if (sk == "AthamesMaster1")
        {
            un.unitInfo.weaponRanks.Athames.canUse = true;
            un.unitInfo.weaponRanks.Athames.rank = 3;
        }
        else if (sk == "LightBladesMaster1")
        {
            un.unitInfo.weaponRanks.LightBlades.canUse = true;
            un.unitInfo.weaponRanks.LightBlades.rank = 3;
        }

    }


}