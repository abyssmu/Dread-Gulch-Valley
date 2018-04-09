﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MineFromCanyon : MonoBehaviour {

    private GameObject player;
    private SceneCheck playerscene;


    // Use this for initialization
    void Start()
    {

        player = GameObject.FindGameObjectWithTag("Player");
        playerscene = player.GetComponent<SceneCheck>();
        if (playerscene.IsInCanyon == true)
        {
            player.transform.position = gameObject.transform.position;
            playerscene.IsInCanyon = false;
            playerscene.IsInMines = true;
        }



    }

    // Update is called once per frame
    void Update () {
		
	}
}
