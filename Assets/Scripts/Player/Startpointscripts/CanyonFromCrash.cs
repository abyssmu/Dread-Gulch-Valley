using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanyonFromCrash : MonoBehaviour {


    private GameObject player;
    private SceneCheck playerscene;


    // Use this for initialization
    void Start()
    {

        player = GameObject.FindGameObjectWithTag("Player");
        playerscene = player.GetComponent<SceneCheck>();
        if (playerscene.IsInCrashsite == true)
        {
            player.transform.position = gameObject.transform.position;
            playerscene.IsInCrashsite = false;
            playerscene.IsInCanyon = true;
        }



    }

    // Update is called once per frame
    void Update () {
		
	}
}
