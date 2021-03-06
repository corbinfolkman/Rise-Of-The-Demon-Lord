﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class CutScene1 : CutSceneController {

	// Use this for initialization
	void Start () {
        StartUp();

        List<CurrentSceneActorInfo> sceneActors = new List<CurrentSceneActorInfo>();
        List<string> order = new List<string>();
        string book = "";
        string file = "scene1Melvin";
        string folder = "cutscene1";
        string temp = "";
        book = File.ReadAllText("Assets/TextFiles/" + folder + "/" + file + ".txt");
        temp = book;
        CurrentSceneActorInfo scene1a1 = new CurrentSceneActorInfo("place1", "ActMelvin", temp, "ActMelvin");
        sceneActors.Add(scene1a1);

        string[] actingOrder = { "ActMelvin"};
        order.AddRange(actingOrder);
        CurrentSceneInfo scene1 = new CurrentSceneInfo(sceneActors, order);
        sceneInfos.Add(scene1);
        Scene2();
      
	}

    public Unit FindMyself(string unitID)
    {
        Unit me = new Unit();
        foreach (Unit u in CurrentGame.game.storeroom.units)
        {
            if (unitID == u.unitID) return u;
        }
        return me;
    }

    void Scene2()
    {
        List<CurrentSceneActorInfo> scene1Actors = new List<CurrentSceneActorInfo>();
        List<string> order = new List<string>();
        string book = "";
        string file = "scene2Melvin";
        string folder = "cutscene1";
        string temp = "";
        book = File.ReadAllText("Assets/TextFiles/" + folder + "/" + file + ".txt");
        temp = book;
        CurrentSceneActorInfo scene1a1 = new CurrentSceneActorInfo("place10", "ActMelvin", temp, "ActMelvin");
        scene1Actors.Add(scene1a1);

        file = "scene2Jane";
        book = File.ReadAllText("Assets/TextFiles/" + folder + "/" + file + ".txt");
        temp = book;
        CurrentSceneActorInfo scene1a2 = new CurrentSceneActorInfo("place5", "ActAlice", temp, "ActAlice");
        scene1Actors.Add(scene1a2);
        string[] actingOrder = { "ActAlice", "ActMelvin" };
        order.AddRange(actingOrder);
        CurrentSceneInfo scene1 = new CurrentSceneInfo(scene1Actors, order);
        sceneInfos.Add(scene1);

        StartCoroutine(StartScene());
    }

 
}
