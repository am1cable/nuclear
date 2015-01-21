﻿using UnityEngine;
using System.Collections;

public class startGame : MonoBehaviour {
    //Runs each time a new game begins. Specifies the spawn point that is used for respawn & resets the players lives. Can be used for other quick cleanup.
    public GameObject spawnPoint;
    public static startGame startG;

	void Start () {

        startG = this;
        playerStats.Player.resetLife(3);
        spawnPoint.GetComponent<playerMove>().isActive = true;
    	}
	
}