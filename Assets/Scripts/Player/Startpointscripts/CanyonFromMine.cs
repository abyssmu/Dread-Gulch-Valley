using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanyonFromMine : MonoBehaviour {

    private GameObject player;
    private SceneCheck playerscene;


    // Use this for initialization
    void Start()
    {

        player = GameObject.FindGameObjectWithTag("Player");
        playerscene = player.GetComponent<SceneCheck>();
        if (playerscene.IsInMines == true)
        {
            player.transform.position = gameObject.transform.position;
            playerscene.IsInMines = false;
            playerscene.IsInCanyon = true;
        }



    }

    // Update is called once per frame
    void Update () {
		
	}
}
