﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEngine.UI;

public class MenuScript
{

    //my tools

    [MenuItem("Tools/Assign Custom Material")]
    public static void AssignCustomMaterial()
    {
        GameObject something = GameObject.Find("StartMenuInField");

        Material material = Resources.Load<Material>("InFieldSkin");
        something.GetComponent<Renderer>().material = material;

        something = GameObject.Find("StartMenuInBattle");

        material = Resources.Load<Material>("InBattleSkin");
        something.GetComponent<Renderer>().material = material;


        something = GameObject.Find("Battle UI");

        material = Resources.Load<Material>("SeeThough");
        something.GetComponent<Renderer>().material = material;
    }

    [MenuItem("Tools/Color Tiles")]
    public static void ColorIT()
    {

        GameObject[] tiles = GameObject.FindGameObjectsWithTag("HouseTiles");
        Material material = Resources.Load<Material>("HouseTile");
        if (tiles != null)
        {
            foreach (GameObject t in tiles)
            {
                t.GetComponent<Renderer>().material = material;

            }
        }
        tiles = GameObject.FindGameObjectsWithTag("Rivers");
        material = Resources.Load<Material>("Rivers");
        if (tiles != null)
        {
            foreach (GameObject t in tiles)
            {
                t.GetComponent<Renderer>().material = material;

            }
        }
        tiles = GameObject.FindGameObjectsWithTag("RiverC");
        material = Resources.Load<Material>("Rivers");
        if (tiles != null)
        {
            foreach (GameObject t in tiles)
            {
                t.GetComponent<Renderer>().material = material;

            }
        }
    
        tiles = GameObject.FindGameObjectsWithTag("LakeC");
        material = Resources.Load<Material>("Rivers");
        if (tiles != null)
        {
            foreach (GameObject t in tiles)
            {
                t.GetComponent<Renderer>().material = material;

            }
        }
        tiles = GameObject.FindGameObjectsWithTag("LakeM");
        material = Resources.Load<Material>("Rivers");
        if (tiles != null)
        {
            foreach (GameObject t in tiles)
            {
                t.GetComponent<Renderer>().material = material;

            }
        }
        tiles = GameObject.FindGameObjectsWithTag("ChestC");
        material = Resources.Load<Material>("Treasure");
        if (tiles != null)
        {
            foreach (GameObject t in tiles)
            {
                t.GetComponent<Renderer>().material = material;

            }
        }

        tiles = GameObject.FindGameObjectsWithTag("DoorC");
        material = Resources.Load<Material>("Door");
        if (tiles != null)
        {
            foreach (GameObject t in tiles)
            {
                t.GetComponent<Renderer>().material = material;

            }
        }

        tiles = GameObject.FindGameObjectsWithTag("LakeS");
        material = Resources.Load<Material>("Rivers");
        if (tiles != null)
        {
            foreach (GameObject t in tiles)
            {
                t.GetComponent<Renderer>().material = material;

            }
        }

        tiles = GameObject.FindGameObjectsWithTag("Walls");
        material = Resources.Load<Material>("Wall");
        if (tiles != null)
        {
            foreach (GameObject t in tiles)
            {
                t.GetComponent<Renderer>().material = material;
            }
        }

        tiles = GameObject.FindGameObjectsWithTag("LongWall");
        material = Resources.Load<Material>("LongWall");
        if (tiles != null)
        {
            foreach (GameObject t in tiles)
            {
                t.GetComponent<Renderer>().material = material;
            }
        }

        tiles = GameObject.FindGameObjectsWithTag("Dirt");
        material = Resources.Load<Material>("Dirt");
        if (tiles != null)
        {
            foreach (GameObject t in tiles)
            {
                t.GetComponent<Renderer>().material = material;

            }
        }

        tiles = GameObject.FindGameObjectsWithTag("Grass");
        material = Resources.Load<Material>("Grass");
        if (tiles != null)
        {
            foreach (GameObject t in tiles)
            {
                t.GetComponent<Renderer>().material = material;
            }
        }

        tiles = GameObject.FindGameObjectsWithTag("Bridge");
        material = Resources.Load<Material>("Bridge");
        if (tiles != null)
        {
            foreach (GameObject t in tiles)
            {
                t.GetComponent<Renderer>().material = material;
            }
        }

        tiles = GameObject.FindGameObjectsWithTag("Street");
        material = Resources.Load<Material>("Street");
        if (tiles != null)
        {
            foreach (GameObject t in tiles)
            {
                t.GetComponent<Renderer>().material = material;
            }
        }
        tiles = GameObject.FindGameObjectsWithTag("Gap");
        material = Resources.Load<Material>("Gap");
        if (tiles != null)
        {
            foreach (GameObject t in tiles)
            {
                t.GetComponent<Renderer>().material = material;
            }
        }

        tiles = GameObject.FindGameObjectsWithTag("Forest");
        material = Resources.Load<Material>("Forest");
        if (tiles != null)
        {
            foreach (GameObject t in tiles)
            {
                t.GetComponent<Renderer>().material = material;
            }
        }

        tiles = GameObject.FindGameObjectsWithTag("Mountain");
        material = Resources.Load<Material>("Mountain");
        if (tiles != null)
        {
            foreach (GameObject t in tiles)
            {
                t.GetComponent<Renderer>().material = material;
            }
        }

    }


    [MenuItem("Tools/CreateTileNames")]
    public static void CreateTileNames()
    {

        GameObject map = GameObject.Find("NewMap");
        Rows[] allRows = map.GetComponentsInChildren<Rows>();
        int r = 0;
        foreach (Rows row in allRows)
        {
            int f = 0;
            GridTiles[] allTiles = row.GetComponentsInChildren<GridTiles>();

            //
            row.name = "og" + r;
            foreach (GridTiles tile in allTiles)
            {
                tile.name = "og" + f + "r" + r;
                f++;
            }
            r++;
        }


    }

    [MenuItem("Tools/CreatUIOverlay")]
    public static void CreateUIOverlay()
    {

        GameObject map = GameObject.Find("NewMap");
        Rows[] allRows = map.GetComponentsInChildren<Rows>();
        int r = 0;
        foreach (Rows row in allRows)
        {
            int f = 0;
            GridTiles[] allTiles = row.GetComponentsInChildren<GridTiles>();

            //
        
            foreach (GridTiles tile in allTiles)
            {
                GameObject uiOveraly = GameObject.Instantiate(Resources.Load("UIoverlay")) as GameObject;
                uiOveraly.transform.parent = tile.transform;
                uiOveraly.transform.localPosition = new Vector3(0, 0.53f, 0);


            }
            r++;
        }


    }

    [MenuItem("Tools/RemoveUIOverlay")]
    public static void RemoveUIOverlay()
    {

        GameObject map = GameObject.Find("NewMap");
        Rows[] allRows = map.GetComponentsInChildren<Rows>();
        int r = 0;
        foreach (Rows row in allRows)
        {
            int f = 0;
            GridTiles[] allTiles = row.GetComponentsInChildren<GridTiles>();

            //

            foreach (GridTiles tile in allTiles)
            {
             

            }
            r++;
        }


    }

    [MenuItem("Tools/CraveOutTileSizes")]
    public static void CraveOutTileSizes()
    {

        GameObject map = GameObject.Find("Template50x50test");
        Rows[] allRows = map.GetComponentsInChildren<Rows>();
        int r = 0;
        foreach (Rows row in allRows)
        {
            int f = 0;
            int maxR = 11;
            int maxf = 7;
            if (r > maxR) GameObject.DestroyImmediate(GameObject.Find(row.name));
            else
            {
                GridTiles[] allTiles = row.GetComponentsInChildren<GridTiles>();
                foreach (GridTiles tile in allTiles)
                {
                    if (f > maxf) GameObject.DestroyImmediate(GameObject.Find(tile.name));
                    f++;
                }
                r++;
            }
        }


    }


    [MenuItem("Tools/GenerateNewMap")]
    public static void SetNewTile()
    {
        GameObject maps = GameObject.Find("Area4");
        Rows[] allRows = maps.GetComponentsInChildren<Rows>();
        int i = 0;
        GameObject map = new GameObject();
        map.AddComponent<MapLocation>();
        map.AddComponent<PhaseSwitcher>();
        map.transform.position = new Vector3(34.22f, 0, -83.5f);
        foreach (Rows row in allRows)
        {
            int j = 0;
            GameObject newRow = new GameObject();
            newRow.transform.parent = map.transform;
            newRow.AddComponent<Rows>();
            newRow.transform.localPosition = new Vector3(0, 0, i);
            GridTiles[] allTiles = row.GetComponentsInChildren<GridTiles>();
            foreach (GridTiles tile in allTiles)
            {
                //Higher Ground Could Be by Checking the Y axis 1 for High Ground .5 for ramp

                if (tile.tag == "Rivers")
                {
                    if (tile.transform.position.y > 0.9f)
                    {
                        GameObject tiles = GameObject.Instantiate(Resources.Load("River piece")) as GameObject;
                        tiles.transform.parent = newRow.transform;
                        tiles.transform.localPosition = new Vector3(j - 0.25f, tile.transform.position.y, 0);
                       // tiles.transform.localRotation = tile.transform.localRotation;
                        tiles.tag = "River";
                        tiles.AddComponent<GridTiles>();
                        tiles.GetComponent<GridTiles>().walkable = false;


                        GameObject tilesn = GameObject.CreatePrimitive(PrimitiveType.Cube);
                        tilesn.transform.parent = newRow.transform;
                        Material material = Resources.Load<Material>("Dirt");
                        tilesn.GetComponent<Renderer>().material = material;
                        tilesn.transform.localPosition = new Vector3(j, 1, 0);
                        tilesn.transform.localScale = new Vector3(1, (tile.transform.position.y), 1);
                        tilesn.transform.localPosition += new Vector3(0, 0.5f * (tile.transform.position.y + 1), 0);
                        tilesn.transform.localPosition += Vector3.down + Vector3.down;
                        tilesn.transform.parent = tiles.transform;

                    }
                    else
                    {
                        GameObject tiles = GameObject.Instantiate(Resources.Load("River piece")) as GameObject;
                        tiles.transform.parent = newRow.transform;
                        tiles.transform.localRotation = tile.transform.localRotation;
                        tiles.transform.localPosition = new Vector3(j - 0.25f, 0, 0);
                        tiles.tag = "River";
                        tiles.AddComponent<GridTiles>();
                        tiles.GetComponent<GridTiles>().walkable = false;
                    }
                }
                if (tile.tag == "RiverH")
                {
                    if (tile.transform.position.y > 0.9f)
                    {

                        GameObject tiles = GameObject.Instantiate(Resources.Load("River piece")) as GameObject;
                        tiles.transform.parent = newRow.transform;
                        tiles.transform.localPosition = new Vector3(j, tile.transform.position.y, 0.25f);
                        tiles.transform.localRotation *= Quaternion.Euler(0, 90f, 0);
                        tiles.tag = "River";
                        tiles.AddComponent<GridTiles>();
                        tiles.GetComponent<GridTiles>().walkable = false;


                        GameObject tilesn = GameObject.CreatePrimitive(PrimitiveType.Cube);
                        tilesn.transform.parent = newRow.transform;
                        Material material = Resources.Load<Material>("Dirt");
                        tilesn.GetComponent<Renderer>().material = material;
                        tilesn.transform.localPosition = new Vector3(j, 1, 0);
                        tilesn.transform.localScale = new Vector3(1, (tile.transform.position.y), 1);
                        tilesn.transform.localPosition += new Vector3(0, 0.5f * (tile.transform.position.y + 1), 0);
                        tilesn.transform.localPosition += Vector3.down + Vector3.down;
                        tilesn.transform.parent = tiles.transform;
                    }
                    else
                    {
                        GameObject tiles = GameObject.Instantiate(Resources.Load("River piece")) as GameObject;
                        tiles.transform.parent = newRow.transform;
                        tiles.transform.localPosition = new Vector3(j, 0, 0.25f);
                        tiles.transform.localRotation *= Quaternion.Euler(0, 90f, 0);
                        tiles.tag = "River";
                        tiles.AddComponent<GridTiles>();
                        tiles.GetComponent<GridTiles>().walkable = false;
                    }
                }

                //
                //  __  ___
                // |90  180|
                //   WaterCorner Directions
                // |0   270|
                //  --  ---  
                else if (tile.tag == "RiverC")
                {

                    if (tile.transform.position.y > 0.9f)
                    {
                        GameObject tiles = GameObject.Instantiate(Resources.Load("WaterCorner")) as GameObject;
                        tiles.transform.parent = newRow.transform;
                        tiles.transform.localPosition = new Vector3(j, tile.transform.position.y, 0);
                        tiles.transform.localRotation = tile.transform.localRotation;
                        tiles.tag = "River";
                        tiles.AddComponent<GridTiles>();
                        tiles.GetComponent<GridTiles>().walkable = false;

                        GameObject tilesn = GameObject.CreatePrimitive(PrimitiveType.Cube);
                        tilesn.transform.parent = newRow.transform;
                        Material material = Resources.Load<Material>("Dirt");
                        tilesn.GetComponent<Renderer>().material = material;
                        tilesn.transform.localPosition = new Vector3(j, 1, 0);
                        tilesn.transform.localScale = new Vector3(1, (tile.transform.position.y), 1);
                        tilesn.transform.localPosition += new Vector3(0, 0.5f * (tile.transform.position.y + 1), 0);
                        tilesn.transform.localPosition += Vector3.down + Vector3.down;
                        tilesn.transform.parent = tiles.transform;
                    }
                    else
                    {
                        GameObject tiles = GameObject.Instantiate(Resources.Load("WaterCorner")) as GameObject;
                        tiles.transform.parent = newRow.transform;
                        tiles.transform.localPosition = new Vector3(j, 0, 0);
                        tiles.transform.localRotation = tile.transform.localRotation;
                        tiles.tag = "River";
                        tiles.AddComponent<GridTiles>();
                        tiles.GetComponent<GridTiles>().walkable = false;

                    }
                }
             
                else if (tile.tag == "LakeC")
                {
                    if (tile.transform.position.y > 0.9f)
                    {
                        GameObject tiles = GameObject.Instantiate(Resources.Load("LakeCorner")) as GameObject;
                        tiles.transform.parent = newRow.transform;
                        tiles.transform.localPosition = new Vector3(j, tile.transform.position.y, 0);
                        tiles.transform.localRotation = tile.transform.localRotation;
                        tiles.tag = "River";
                        tiles.AddComponent<GridTiles>();
                        tiles.GetComponent<GridTiles>().walkable = false;

                        GameObject tilesn = GameObject.CreatePrimitive(PrimitiveType.Cube);
                        tilesn.transform.parent = newRow.transform;
                        Material material = Resources.Load<Material>("Dirt");
                        tilesn.GetComponent<Renderer>().material = material;
                        tilesn.transform.localPosition = new Vector3(j, 1, 0);
                        tilesn.transform.localScale = new Vector3(1, (tile.transform.position.y), 1);
                        tilesn.transform.localPosition += new Vector3(0, 0.5f * (tile.transform.position.y + 1), 0);
                        tilesn.transform.localPosition += Vector3.down + Vector3.down;
                        tilesn.transform.parent = tiles.transform;
                    }
                    else
                    {
                        GameObject tiles = GameObject.Instantiate(Resources.Load("LakeCorner")) as GameObject;
                        tiles.transform.parent = newRow.transform;
                        tiles.transform.localPosition = new Vector3(j, 0, 0);
                        tiles.transform.localRotation = tile.transform.localRotation;
                        tiles.tag = "River";
                        tiles.AddComponent<GridTiles>();
                        tiles.GetComponent<GridTiles>().walkable = false;
                    }
                }
                else if (tile.tag == "LakeS")
                {
                    if (tile.transform.position.y > 0.9f)
                    {
                        GameObject tiles = GameObject.Instantiate(Resources.Load("LakeSide")) as GameObject;
                        tiles.transform.parent = newRow.transform;
                        tiles.transform.localPosition = new Vector3(j, tile.transform.position.y, 0);
                        tiles.transform.localRotation = tile.transform.localRotation;
                        tiles.tag = "River";
                        tiles.AddComponent<GridTiles>();
                        tiles.GetComponent<GridTiles>().walkable = false;

                        GameObject tilesn = GameObject.CreatePrimitive(PrimitiveType.Cube);
                        tilesn.transform.parent = newRow.transform;
                        Material material = Resources.Load<Material>("Dirt");
                        tilesn.GetComponent<Renderer>().material = material;
                        tilesn.transform.localPosition = new Vector3(j, 1, 0);
                        tilesn.transform.localScale = new Vector3(1, (tile.transform.position.y), 1);
                        tilesn.transform.localPosition += new Vector3(0, 0.5f * (tile.transform.position.y + 1), 0);
                        tilesn.transform.localPosition += Vector3.down + Vector3.down;
                        tilesn.transform.parent = tiles.transform;
                    }
                    else
                    {
                        GameObject tiles = GameObject.Instantiate(Resources.Load("LakeSide")) as GameObject;
                        tiles.transform.parent = newRow.transform;
                        tiles.transform.localPosition = new Vector3(j, 0, 0);
                        tiles.transform.localRotation = tile.transform.localRotation;
                        tiles.tag = "River";
                        tiles.AddComponent<GridTiles>();
                        tiles.GetComponent<GridTiles>().walkable = false;
                    }
                }
                else if (tile.tag == "LakeM")
                {
                    if (tile.transform.position.y > 0.9f)
                    {
                        GameObject tiles = GameObject.Instantiate(Resources.Load("MidLake")) as GameObject;
                        tiles.transform.parent = newRow.transform;
                        tiles.transform.localPosition = new Vector3(j, tile.transform.position.y, 0);
                        tiles.transform.localRotation = tile.transform.localRotation;
                        tiles.tag = "River";
                        tiles.AddComponent<GridTiles>();
                        tiles.GetComponent<GridTiles>().walkable = false;
                    }
                    else
                    {
                        GameObject tiles = GameObject.Instantiate(Resources.Load("MidLake")) as GameObject;
                        tiles.transform.parent = newRow.transform;
                        tiles.transform.localPosition = new Vector3(j, 0, 0);
                        tiles.transform.localRotation = tile.transform.localRotation;
                        tiles.tag = "River";
                        tiles.AddComponent<GridTiles>();
                        tiles.GetComponent<GridTiles>().walkable = false;
                    }
                }
                else if (tile.tag == "DoorC")
                {

                    if (tile.transform.position.y > 0.9f)
                    {
                        GameObject tiles = GameObject.Instantiate(Resources.Load("LockedDoor")) as GameObject;
                        tiles.transform.parent = newRow.transform;
                        tiles.transform.localPosition = new Vector3(j, tile.transform.position.y, 0);
                        tiles.transform.localRotation = tile.transform.localRotation;
                        tiles.tag = "Door";
                       // tiles.AddComponent<GridTiles>();
                       // tiles.GetComponent<GridTiles>().walkable = false;

                        GameObject tilesn = GameObject.CreatePrimitive(PrimitiveType.Cube);
                        tilesn.transform.parent = newRow.transform;
                        Material material = Resources.Load<Material>("HouseTile");
                        tilesn.GetComponent<Renderer>().material = material;
                        tilesn.transform.localPosition = new Vector3(j, 1, 0);
                        tilesn.transform.localScale = new Vector3(1, (tile.transform.position.y), 1);
                        tilesn.transform.localPosition += new Vector3(0, 0.5f * (tile.transform.position.y + 1), 0);
                        tilesn.transform.localPosition += Vector3.down + Vector3.down;
                        tilesn.transform.parent = tiles.transform;
                    }
                    else
                    {
                        GameObject tiles = GameObject.Instantiate(Resources.Load("LockedDoor")) as GameObject;
                        tiles.transform.parent = newRow.transform;
                        tiles.transform.localPosition = new Vector3(j, 0, 0);
                        tiles.transform.localRotation = tile.transform.localRotation;
                        tiles.tag = "Door";
                       // tiles.AddComponent<GridTiles>();
                       // tiles.GetComponent<GridTiles>().walkable = false;

                    }
                }
                else if (tile.tag == "ChestC")
                {

                    if (tile.transform.position.y > 0.9f)
                    {
                        GameObject tiles = GameObject.Instantiate(Resources.Load("Chest")) as GameObject;
                        tiles.transform.parent = newRow.transform;
                        tiles.transform.localPosition = new Vector3(j, tile.transform.position.y + 0.75f, 0);
                        tiles.transform.localRotation = tile.transform.localRotation;
                        tiles.tag = "Chest";
                        //tiles.AddComponent<GridTiles>();
                       // tiles.GetComponent<GridTiles>().walkable = false;

                        GameObject tilesn = GameObject.CreatePrimitive(PrimitiveType.Cube);
                        tilesn.transform.parent = newRow.transform;
                        Material material = Resources.Load<Material>("HouseTile");
                        tilesn.GetComponent<Renderer>().material = material;
                        tilesn.transform.localPosition = new Vector3(j, 1, 0);
                        tilesn.transform.localScale = new Vector3(1, (tile.transform.position.y), 1);
                        tilesn.transform.localPosition += new Vector3(0, 0.5f * (tile.transform.position.y + 1), 0);
                        tilesn.transform.localPosition += Vector3.down + Vector3.down;
                        tilesn.transform.parent = tiles.transform;
                    }
                    else
                    {
                        GameObject tiles = GameObject.Instantiate(Resources.Load("Chest")) as GameObject;
                        tiles.transform.parent = newRow.transform;
                        tiles.transform.localPosition = new Vector3(j, 0.75f, 0);
                        tiles.transform.localRotation = tile.transform.localRotation;
                        tiles.tag = "Chest";
                       // tiles.AddComponent<GridTiles>();
                       // tiles.GetComponent<GridTiles>().walkable = false;

                    }
                }

                // Ramp Directions Y
                //       A
                //      90
                //<- 0     180-> (Lip)
                //      270
                //       V
                else if (tile.tag == "Grass")
                {
                    if (tile.transform.localPosition.z == 0.5f)
                    {
                        GameObject tiles = GameObject.Instantiate(Resources.Load("Ramp")) as GameObject;
                        tiles.transform.parent = newRow.transform;
                        tiles.transform.localPosition = new Vector3(j, tile.transform.position.y, 0);
                        tiles.transform.localRotation = tile.transform.localRotation;
                        Material material = Resources.Load<Material>("Grass");
                        tiles.GetComponent<Renderer>().material = material;
                        tiles.tag = "Ramp";
                        tiles.AddComponent<GridTiles>();
                        tiles.GetComponent<GridTiles>().walkable = true;

                        if (tile.transform.position.y > 0.9f)
                        {
                            GameObject tilesn = GameObject.CreatePrimitive(PrimitiveType.Cube);
                            tilesn.transform.parent = newRow.transform;
                            tilesn.GetComponent<Renderer>().material = material;
                            tilesn.transform.localPosition = new Vector3(j, 1, 0);
                            tilesn.transform.localScale = new Vector3(1, (tile.transform.position.y), 1);
                            tilesn.transform.localPosition += new Vector3(0, 0.5f * (tile.transform.position.y + 1), 0);
                            tilesn.transform.localPosition += Vector3.down + Vector3.down;
                            tilesn.transform.parent = tiles.transform;
                        }
                    }
                    else if (tile.transform.position.y > 0.9f)
                    {

                        GameObject tiles = GameObject.CreatePrimitive(PrimitiveType.Cube);
                        Material material = Resources.Load<Material>("Grass");
                        tiles.GetComponent<Renderer>().material = material;
                        tiles.transform.parent = newRow.transform;
                        tiles.transform.localPosition = new Vector3(j, tile.transform.position.y, 0);
                        tiles.tag = "Tile";
                        tiles.AddComponent<GridTiles>();
                        tiles.GetComponent<GridTiles>().walkable = true;
                        tiles.GetComponent<GridTiles>().distance = 5;
                        tiles.transform.localScale = new Vector3(1, (tile.transform.position.y + 1), 1);
                        tiles.transform.localPosition = new Vector3(j, tile.transform.position.y / 2, 0);
                    }
                    else
                    {
                        GameObject tiles = GameObject.CreatePrimitive(PrimitiveType.Cube);
                        Material material = Resources.Load<Material>("Grass");
                        tiles.GetComponent<Renderer>().material = material;
                        tiles.transform.parent = newRow.transform;
                        tiles.transform.localPosition = new Vector3(j, 0, 0);
                        tiles.tag = "Tile";
                        tiles.AddComponent<GridTiles>();
                        tiles.GetComponent<GridTiles>().walkable = true;
                    }
                }
                else if (tile.tag == "Gap")
                {

                    if (tile.transform.localPosition.y > 0.9f)
                    {
                        GameObject tiles = new GameObject();
                        tiles.transform.parent = newRow.transform;
                        tiles.transform.localPosition = new Vector3(j, tile.transform.position.y, 0);
                        tiles.tag = "Tile";
                        tiles.AddComponent<GridTiles>();
                        tile.GetComponent<GridTiles>().walkable = false;
                        tiles.AddComponent<BoxCollider>();
                        tiles.GetComponent<BoxCollider>().transform.localScale += new Vector3(0, 10, 0);
                    }
                    else
                    {
                        GameObject tiles = new GameObject();
                        tiles.transform.parent = newRow.transform;
                        tiles.transform.localPosition = new Vector3(j, 0, 0);
                        tiles.tag = "Tile";
                        tiles.AddComponent<GridTiles>();
                        tile.GetComponent<GridTiles>().walkable = false;
                        tiles.AddComponent<BoxCollider>();
                        tiles.GetComponent<BoxCollider>().transform.localScale += new Vector3(0, 10, 0);
                    }
                }
                else if (tile.tag == "Dirt")
                {
                    if (tile.transform.localPosition.z == 0.5f)
                    {
                        GameObject tiles = GameObject.Instantiate(Resources.Load("Ramp")) as GameObject;
                        tiles.transform.parent = newRow.transform;
                        tiles.transform.localPosition = new Vector3(j, tile.transform.position.y, 0);
                        tiles.transform.localRotation = tile.transform.localRotation;
                        Material material = Resources.Load<Material>("Dirt");
                        tiles.GetComponent<Renderer>().material = material;
                        tiles.tag = "Ramp";
                        tiles.AddComponent<GridTiles>();
                        tiles.GetComponent<GridTiles>().walkable = true;

                        if (tile.transform.position.y > 0.9f)
                        {
                            GameObject tilesn = GameObject.CreatePrimitive(PrimitiveType.Cube);
                            tilesn.transform.parent = newRow.transform;
                            tilesn.GetComponent<Renderer>().material = material;
                            tilesn.transform.localPosition = new Vector3(j, 1, 0);
                            tilesn.transform.localScale = new Vector3(1, (tile.transform.position.y), 1);
                            tilesn.transform.localPosition += new Vector3(0, 0.5f * (tile.transform.position.y + 1), 0);
                            tilesn.transform.localPosition += Vector3.down + Vector3.down;
                            tilesn.transform.parent = tiles.transform;
                        }

                    }
                    else if (tile.transform.position.y > 0.9f)
                    {
                        GameObject tiles = GameObject.CreatePrimitive(PrimitiveType.Cube);
                        Material material = Resources.Load<Material>("Dirt");
                        tiles.GetComponent<Renderer>().material = material;
                        tiles.transform.parent = newRow.transform;
                        tiles.transform.localPosition = new Vector3(j, tile.transform.position.y, 0);
                        tiles.tag = "Tile";
                        tiles.AddComponent<GridTiles>();
                        tiles.GetComponent<GridTiles>().walkable = true;
                        tiles.GetComponent<GridTiles>().distance = 5;
                        tiles.transform.localScale = new Vector3(1, (tile.transform.position.y + 1), 1);
                        tiles.transform.localPosition = new Vector3(j, tile.transform.position.y / 2, 0);
                    }
                    else
                    {
                        GameObject tiles = GameObject.CreatePrimitive(PrimitiveType.Cube);
                        Material material = Resources.Load<Material>("Dirt");
                        tiles.GetComponent<Renderer>().material = material;
                        tiles.transform.parent = newRow.transform;
                        tiles.transform.localPosition = new Vector3(j, 0, 0);
                        tiles.tag = "Tile";
                        tiles.AddComponent<GridTiles>();
                        tiles.GetComponent<GridTiles>().walkable = true;
                        tiles.GetComponent<GridTiles>().distance = 5;
                    }
                }
                else if (tile.tag == "Street")
                {
                    if (tile.transform.localPosition.z == 0.5f)
                    {
                        GameObject tiles = GameObject.Instantiate(Resources.Load("Ramp")) as GameObject;
                        tiles.transform.parent = newRow.transform;
                        tiles.transform.localPosition = new Vector3(j, tile.transform.position.y, 0);
                        tiles.transform.localRotation = tile.transform.localRotation;
                        Material material = Resources.Load<Material>("Street");
                        tiles.GetComponent<Renderer>().material = material;
                        tiles.tag = "Ramp";
                        tiles.AddComponent<GridTiles>();
                        tiles.GetComponent<GridTiles>().walkable = true;
                        tiles.GetComponent<GridTiles>().distance = 5;

                        if (tile.transform.position.y > 0.9f)
                        {
                            GameObject tilesn = GameObject.CreatePrimitive(PrimitiveType.Cube);
                            tilesn.transform.parent = newRow.transform;
                            tilesn.GetComponent<Renderer>().material = material;
                            tilesn.transform.localPosition = new Vector3(j, 1, 0);
                            tilesn.transform.localScale = new Vector3(1, (tile.transform.position.y), 1);
                            tilesn.transform.localPosition += new Vector3(0, 0.5f * (tile.transform.position.y + 1), 0);
                            tilesn.transform.localPosition += Vector3.down + Vector3.down;
                            tilesn.transform.parent = tiles.transform;
                        }
                    }
                    else if (tile.transform.position.y > 0.9f)
                    {
                        GameObject tiles = GameObject.CreatePrimitive(PrimitiveType.Cube);
                        Material material = Resources.Load<Material>("Street");
                        tiles.GetComponent<Renderer>().material = material;
                        tiles.transform.parent = newRow.transform;
                        tiles.transform.localPosition = new Vector3(j, tile.transform.position.y, 0);
                        tiles.tag = "Tile";
                        tiles.AddComponent<GridTiles>();
                        tiles.GetComponent<GridTiles>().walkable = true;
                        tiles.GetComponent<GridTiles>().distance = 5;
                        tiles.transform.localScale = new Vector3(1, (tile.transform.position.y + 1), 1);
                        tiles.transform.localPosition = new Vector3(j, tile.transform.position.y / 2, 0);
                    }
                    else
                    {
                        GameObject tiles = GameObject.CreatePrimitive(PrimitiveType.Cube);
                        Material material = Resources.Load<Material>("Street");
                        tiles.GetComponent<Renderer>().material = material;
                        tiles.transform.parent = newRow.transform;
                        tiles.transform.localPosition = new Vector3(j, 0, 0);
                        tiles.tag = "Tile";
                        tiles.AddComponent<GridTiles>();
                        tiles.GetComponent<GridTiles>().walkable = true;
                    }
                }
                else if (tile.tag == "HouseTiles")
                {
                    if (tile.transform.localPosition.z == 0.5f)
                    {
                        GameObject tiles = GameObject.Instantiate(Resources.Load("Ramp")) as GameObject;
                        tiles.transform.parent = newRow.transform;
                        tiles.transform.localPosition = new Vector3(j, tile.transform.position.y, 0);
                        tiles.transform.localRotation = tile.transform.localRotation;
                        Material material = Resources.Load<Material>("HouseTile");
                        tiles.GetComponent<Renderer>().material = material;
                        tiles.tag = "Ramp";
                        tiles.AddComponent<GridTiles>();
                        tiles.GetComponent<GridTiles>().walkable = true;

                        if (tile.transform.position.y > 0.9f)
                        {
                            GameObject tilesn = GameObject.CreatePrimitive(PrimitiveType.Cube);
                            tilesn.transform.parent = newRow.transform;
                            tilesn.GetComponent<Renderer>().material = material;
                            tilesn.transform.localPosition = new Vector3(j, 1, 0);
                            tilesn.transform.localScale = new Vector3(1, (tile.transform.position.y), 1);
                            tilesn.transform.localPosition += new Vector3(0, 0.5f * (tile.transform.position.y + 1), 0);
                            tilesn.transform.localPosition += Vector3.down + Vector3.down;
                            tilesn.transform.parent = tiles.transform;
                        }

                    }
                    else if (tile.transform.position.y > 0.9f)
                    {

                        GameObject tiles = GameObject.CreatePrimitive(PrimitiveType.Cube);
                        Material material = Resources.Load<Material>("HouseTile");
                        tiles.GetComponent<Renderer>().material = material;
                        tiles.transform.parent = newRow.transform;
                        tiles.transform.localPosition = new Vector3(j, tile.transform.position.y, 0);
                        tiles.tag = "Tile";
                        tiles.AddComponent<GridTiles>();
                        tiles.GetComponent<GridTiles>().walkable = true;
                        tiles.GetComponent<GridTiles>().distance = 5;
                        tiles.transform.localScale = new Vector3(1, (tile.transform.position.y + 1), 1);
                        tiles.transform.localPosition = new Vector3(j, tile.transform.position.y / 2, 0);
                    }
                    else
                    {
                        GameObject tiles = GameObject.CreatePrimitive(PrimitiveType.Cube);
                        Material material = Resources.Load<Material>("HouseTile");
                        tiles.GetComponent<Renderer>().material = material;
                        tiles.transform.parent = newRow.transform;
                        tiles.transform.localPosition = new Vector3(j, 0, 0);
                        tiles.tag = "Tile";
                        tiles.AddComponent<GridTiles>();
                        tiles.GetComponent<GridTiles>().walkable = true;
                    }
                }
                else if (tile.tag == "Forest")
                {
                    if (tile.transform.localPosition.z == 0.5f)
                    {
                        GameObject tiles = GameObject.Instantiate(Resources.Load("Ramp")) as GameObject;
                        tiles.transform.parent = newRow.transform;
                        tiles.transform.localPosition = new Vector3(j, tile.transform.position.y, 0);
                        tiles.transform.localRotation = tile.transform.localRotation;
                        Material material = Resources.Load<Material>("Forest");
                        tiles.GetComponent<Renderer>().material = material;
                        tiles.tag = "Ramp";
                        tiles.AddComponent<GridTiles>();
                        tiles.GetComponent<GridTiles>().walkable = true;

                        if (tile.transform.position.y > 0.9f)
                        {
                            GameObject tilesn = GameObject.CreatePrimitive(PrimitiveType.Cube);
                            tilesn.transform.parent = newRow.transform;
                            tilesn.GetComponent<Renderer>().material = material;
                            tilesn.transform.localPosition = new Vector3(j, 1, 0);
                            tilesn.transform.localScale = new Vector3(1, (tile.transform.position.y), 1);
                            tilesn.transform.localPosition += new Vector3(0, 0.5f * (tile.transform.position.y + 1), 0);
                            tilesn.transform.localPosition += Vector3.down + Vector3.down;
                            tilesn.transform.parent = tiles.transform;
                        }
                    }
                    else if (tile.transform.position.y > 0.9f)
                    {

                        GameObject tiles = GameObject.CreatePrimitive(PrimitiveType.Cube);
                        Material material = Resources.Load<Material>("Forest");
                        tiles.GetComponent<Renderer>().material = material;
                        tiles.transform.parent = newRow.transform;
                        tiles.transform.localPosition = new Vector3(j, tile.transform.position.y, 0);
                        tiles.tag = "Tile";
                        tiles.AddComponent<GridTiles>();
                        tiles.GetComponent<GridTiles>().walkable = true;
                        tiles.GetComponent<GridTiles>().distance = 5;
                        tiles.transform.localScale = new Vector3(1, (tile.transform.position.y + 1), 1);
                        tiles.transform.localPosition = new Vector3(j, tile.transform.position.y / 2, 0);
                    }
                    else
                    {
                        GameObject tiles = GameObject.CreatePrimitive(PrimitiveType.Cube);
                        Material material = Resources.Load<Material>("Forest");
                        tiles.GetComponent<Renderer>().material = material;
                        tiles.transform.parent = newRow.transform;
                        tiles.transform.localPosition = new Vector3(j, 0, 0);
                        tiles.tag = "Tile";
                        tiles.AddComponent<GridTiles>();
                        tiles.GetComponent<GridTiles>().walkable = true;
                    }
                }
                else if (tile.tag == "Bridge")
                {
                    if (tile.transform.localPosition.z == 0.5f)
                    {
                        GameObject tiles = GameObject.Instantiate(Resources.Load("Ramp")) as GameObject;
                        tiles.transform.parent = newRow.transform;
                        tiles.transform.localPosition = new Vector3(j, tile.transform.position.y, 0);
                        tiles.transform.localRotation = tile.transform.localRotation;
                        Material material = Resources.Load<Material>("Bridge");
                        tiles.GetComponent<Renderer>().material = material;
                        tiles.tag = "Ramp";
                        tiles.AddComponent<GridTiles>();
                        tiles.GetComponent<GridTiles>().walkable = true;

                        if (tile.transform.position.y > 0.9f)
                        {
                            GameObject tilesn = GameObject.CreatePrimitive(PrimitiveType.Cube);
                            tilesn.transform.parent = newRow.transform;
                            tilesn.GetComponent<Renderer>().material = material;
                            tilesn.transform.localPosition = new Vector3(j, 1, 0);
                            tilesn.transform.localScale = new Vector3(1, (tile.transform.position.y), 1);
                            tilesn.transform.localPosition += new Vector3(0, 0.5f * (tile.transform.position.y + 1), 0);
                            tilesn.transform.localPosition += Vector3.down + Vector3.down;
                            tilesn.transform.parent = tiles.transform;

                        }
                    }
                    else if (tile.transform.position.y > 0.9f)
                    {
                        GameObject tiles = GameObject.CreatePrimitive(PrimitiveType.Cube);
                        Material material = Resources.Load<Material>("Bridge");
                        tiles.GetComponent<Renderer>().material = material;
                        tiles.transform.parent = newRow.transform;
                        tiles.transform.localPosition = new Vector3(j, tile.transform.position.y, 0);
                        tiles.tag = "Tile";
                        tiles.AddComponent<GridTiles>();
                        tiles.GetComponent<GridTiles>().walkable = true;
                        tiles.GetComponent<GridTiles>().distance = 5;
                        tiles.transform.localScale = new Vector3(1, (tile.transform.position.y + 1), 1);
                        tiles.transform.localPosition = new Vector3(j, tile.transform.position.y / 2, 0);
                    }
                    else
                    {
                        GameObject tiles = GameObject.CreatePrimitive(PrimitiveType.Cube);
                        Material material = Resources.Load<Material>("Bridge");
                        tiles.GetComponent<Renderer>().material = material;
                        tiles.transform.parent = newRow.transform;
                        tiles.transform.localPosition = new Vector3(j, 0, 0);
                        tiles.tag = "Tile";
                        tiles.AddComponent<GridTiles>();
                        tiles.GetComponent<GridTiles>().walkable = true;
                    }
                }
                else if (tile.tag == "Mountain")
                {
                    if (tile.transform.localPosition.z == 0.5f)
                    {
                        GameObject tiles = GameObject.Instantiate(Resources.Load("Ramp")) as GameObject;
                        tiles.transform.parent = newRow.transform;
                        tiles.transform.localPosition = new Vector3(j, tile.transform.position.y, 0);
                        tiles.transform.localRotation = tile.transform.localRotation;
                        Material material = Resources.Load<Material>("Mountain");
                        tiles.GetComponent<Renderer>().material = material;
                        tiles.tag = "Ramp";
                        tiles.AddComponent<GridTiles>();
                        tiles.GetComponent<GridTiles>().walkable = true;

                        if (tile.transform.position.y > 0.9f)
                        {
                            GameObject tilesn = GameObject.CreatePrimitive(PrimitiveType.Cube);
                            tilesn.transform.parent = newRow.transform;
                            tilesn.GetComponent<Renderer>().material = material;
                            tilesn.transform.localPosition = new Vector3(j, 1, 0);
                            tilesn.transform.localScale = new Vector3(1, (tile.transform.position.y), 1);
                            tilesn.transform.localPosition += new Vector3(0, 0.5f * (tile.transform.position.y + 1), 0);
                            tilesn.transform.localPosition += Vector3.down + Vector3.down;
                            tilesn.transform.parent = tiles.transform;
                        }

                    }
                    else if (tile.transform.position.y > 0.9f)
                    {

                        GameObject tiles = GameObject.CreatePrimitive(PrimitiveType.Cube);
                        Material material = Resources.Load<Material>("Mountain");
                        tiles.GetComponent<Renderer>().material = material;
                        tiles.transform.parent = newRow.transform;
                        tiles.transform.localPosition = new Vector3(j, tile.transform.position.y, 0);
                        tiles.tag = "Tile";
                        tiles.AddComponent<GridTiles>();
                        tiles.GetComponent<GridTiles>().walkable = true;
                        tiles.GetComponent<GridTiles>().distance = 5;
                        tiles.transform.localScale = new Vector3(1, (tile.transform.position.y + 1), 1);
                        tiles.transform.localPosition = new Vector3(j, tile.transform.position.y/2, 0);
                    }
                    else
                    {
                        GameObject tiles = GameObject.CreatePrimitive(PrimitiveType.Cube);
                        Material material = Resources.Load<Material>("Mountain");
                        tiles.GetComponent<Renderer>().material = material;
                        tiles.transform.parent = newRow.transform;
                        tiles.transform.localPosition = new Vector3(j, 0, 0);
                        tiles.tag = "Tile";
                        tiles.AddComponent<GridTiles>();
                        tiles.GetComponent<GridTiles>().walkable = true;
                    }
                }
                else if (tile.tag == "Walls")
                {

                    if (tile.transform.position.y > 0.9f)
                    {
                        GameObject tiles = GameObject.CreatePrimitive(PrimitiveType.Cube);
                        Material material = Resources.Load<Material>("Wall");
                        tiles.GetComponent<Renderer>().material = material;
                        tiles.transform.parent = newRow.transform;
                        tiles.transform.localPosition = new Vector3(j, tile.transform.position.y, 0);
                        tiles.tag = "Tile";
                        tiles.AddComponent<GridTiles>();
                        tiles.transform.localScale = new Vector3(1, 3 + tile.transform.position.y, 1);
                        tiles.transform.position += Vector3.up;
                        tiles.GetComponent<GridTiles>().walkable = false;
                    }
                    else
                    {
                        GameObject tiles = GameObject.CreatePrimitive(PrimitiveType.Cube);
                        Material material = Resources.Load<Material>("Wall");
                        tiles.GetComponent<Renderer>().material = material;
                        tiles.transform.parent = newRow.transform;
                        tiles.transform.localPosition = new Vector3(j, 0, 0);
                        tiles.tag = "Tile";
                        tiles.AddComponent<GridTiles>();
                        tiles.transform.localScale = new Vector3(1, 3, 1);
                        tiles.transform.position += Vector3.up;
                        tiles.GetComponent<GridTiles>().walkable = false;
                    }



                }
                else if (tile.tag == "LongWall")
                {

                    if (tile.transform.position.y > 0.9f)
                    {
                        GameObject tiles = GameObject.CreatePrimitive(PrimitiveType.Cube);
                        Material material = Resources.Load<Material>("LongWall");
                        tiles.GetComponent<Renderer>().material = material;
                        tiles.transform.parent = newRow.transform;
                        tiles.transform.localPosition = new Vector3(j, tile.transform.position.y, 0);
                        tiles.tag = "Tile";
                        tiles.AddComponent<GridTiles>();
                        tiles.transform.localScale = new Vector3(1, (tile.transform.position.y + 3), 1);
                        tiles.transform.localPosition = new Vector3(j, (tile.transform.position.y / 3) + 0.5f, 0);
                        tiles.GetComponent<GridTiles>().walkable = false;
                    }
                    else
                    {
                        GameObject tiles = GameObject.CreatePrimitive(PrimitiveType.Cube);
                        Material material = Resources.Load<Material>("LongWall");
                        tiles.GetComponent<Renderer>().material = material;
                        tiles.transform.parent = newRow.transform;
                        tiles.transform.localPosition = new Vector3(j, 0, 0);
                        tiles.tag = "Tile";
                        tiles.AddComponent<GridTiles>();
                        tiles.transform.localScale = new Vector3(1, 3, 1);
                        tiles.transform.position += Vector3.up;
                        tiles.GetComponent<GridTiles>().walkable = false;
                    }

                }
                j++;
            }
            i++;
        }

    }
}
