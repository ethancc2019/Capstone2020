﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpSpawnner : MonoBehaviour
{


    public GameObject[] spawnPoints;
    public GameObject powerUpPrefab;

	private GameObject tempPowerup;
    public int ActivePowerups = 1;
	// Use this for initialization
	void Start ()
	{
	    //ActivePowerups = 0;
        spawnPowerUp();
	}
	
	// Update is called once per frame
	void Update () {
	    
	}

    //Debug power up spawn bug
    public void spawnPowerUp()
    {
        int randomPos = Random.Range(0, spawnPoints.Length - 1);
		tempPowerup = Instantiate(powerUpPrefab, spawnPoints[randomPos].transform.position,Quaternion.identity,gameObject.transform);
        ActivePowerups++;
    }

	public void DestoryPowerUp()
    {
		Destroy(tempPowerup);
		this.ActivePowerups--;
        if (ActivePowerups <= 0)
        {
            // activePowerups--;

            spawnPowerUp();
        }
    }


}
