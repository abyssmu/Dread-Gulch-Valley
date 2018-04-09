using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TownFromMinigame : MonoBehaviour {
    private GameObject player;
    private SceneCheck playerscene;


    // Use this for initialization
    void Start()
    {

        player = GameObject.FindGameObjectWithTag("Player");
        playerscene = player.GetComponent<SceneCheck>();
        if (playerscene.IsInMinigame == true)
        {
            player.transform.position = gameObject.transform.position;
            playerscene.IsInMinigame = false;
            playerscene.IsInTown = true;
        }



    }
    // Update is called once per frame
    void Update () {
		
	}
}
