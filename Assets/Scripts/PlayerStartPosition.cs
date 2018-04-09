﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerStartPosition : MonoBehaviour {

    public GameObject playerPrefab;

    private GameObject playerPrefabClone;

    private GameObject EntryFromCanyon;

    private Transform playerPosition;

    private Transform startPosition;

    private SceneCheck playerscene;



    // Use this for initialization
    void Awake()
    {
        playerPrefabClone = Instantiate(playerPrefab, transform.position, Quaternion.identity) as GameObject;
        playerscene = playerPrefabClone.GetComponent<SceneCheck>();

        if (playerPrefabClone.gameObject == null)
        {
            playerPrefabClone = Instantiate(playerPrefab, transform.position, Quaternion.identity) as GameObject;
            playerscene = playerPrefabClone.GetComponent<SceneCheck>();
            
        }
        playerscene.IsInCrashsite = true;

        /*
    
        else
        {
            
            playerPrefabClone = GameObject.FindGameObjectWithTag("Player");

            startPosition = transform;

            playerPosition = playerPrefabClone.transform;

            playerPosition.position = startPosition.position;

        }
       */
    }


    // Update is called once per frame
    void Update()
    {
       
    }

    /* public void MovePlayer()
     {
         playerPosition = playerPrefabClone.GetComponent<Transform>().transform;

         playerPosition.position = startPosition.position;
     }*/

}
