﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapEnemyMove : GridMovement {

    GameObject target;
    bool attackState;
    Rigidbody rb;
    // Use this for initialization
    void Start () {
        rb = gameObject.GetComponent<Rigidbody>();
        if (rb.IsSleeping()) rb.WakeUp();
        rb.drag = 0;
        rb.constraints = RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezeRotationZ | RigidbodyConstraints.FreezePositionY | RigidbodyConstraints.FreezePositionZ;
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public IEnumerator GoTime()
    {
        GameObject tile = null;
        FindNearestTarget();
        CalculatePath();
        FindSelectableTiles();
        if (actualTargetTile != null)
        {
            actualTargetTile.target = true;
            tile = actualTargetTile.gameObject;
        }
        Move();

        do
        {
            Move();
            yield return new WaitForSeconds(0.01f);
        } while (isMoving);
        if (tile != null)
        {
            if (gameObject.transform.localRotation != tile.transform.localRotation) gameObject.transform.localRotation = tile.transform.localRotation;
        }

        float nextTo = 1;
        float thePlayer = Vector3.Distance(transform.position, target.transform.position);
        if (nextTo >= thePlayer)
            attackState = true;

        if (attackState)
        {
            List<GameObject> newTargets = new List<GameObject>();
            AssignArray(newTargets);

            GameObject nearest = null;
            float distance = Mathf.Infinity;

            foreach (GameObject obj in newTargets)
            {
                float d = Vector3.Distance(transform.position, obj.transform.position);

                if (d < distance)
                {
                    distance = d;
                    nearest = obj;
                }
            }
            GameObject Enemy = nearest;
            Stats newEnemy = Enemy.GetComponent<Stats>();
            newEnemy.attacked(gameObject.GetComponent<Stats>());
            attackState = false;
        }

        GameObject.FindObjectOfType<SpeedCenterTurns>().AdvanceTurn();
    }

    void FindNearestTarget()
    {
        List<GameObject> targets = new List<GameObject>();
        AssignArray(targets);

        GameObject nearest = null;
        float distance = Mathf.Infinity;

        foreach (GameObject obj in targets)
        {
            float d = Vector3.Distance(transform.position, obj.transform.position);

            if (d < distance)
            {
                distance = d;
                nearest = obj;
            }
        }

        target = nearest;
    }

    void CalculatePath()
    {
        GridTiles targetTile = GetTargetTile(target);
        if (targetTile == null) Debug.Log("How");
        FindPath(targetTile);

    }

    void AssignArray(List<GameObject> list)
    {
        list.AddRange(GameObject.FindGameObjectsWithTag("Player"));
    }

}
