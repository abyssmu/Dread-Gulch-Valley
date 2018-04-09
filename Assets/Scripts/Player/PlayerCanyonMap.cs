using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerCanyonMap : MonoBehaviour {

    public GameObject MapPanel;

    public bool hasMap = false;

    public bool mapActive = true;

	private GameObject mapOpenCloseSound;

	// Use this for initialization
	void Start ()
	{
		mapOpenCloseSound = GameObject.FindGameObjectWithTag("mapOpenCloseSound");
	}
	
	// Update is called once per frame
	void Update () {
        DisplayMap();

    }

  void  DisplayMap()
    {
        
        if (Input.GetKeyDown(KeyCode.M) && hasMap == true && mapActive == true)
        {
            //tests if the m key has been pressed this frame to determine if the map should be displayed
            MapPanel.SetActive(true);

            //sets the passage of time to zero (effectively pausing the game)
            Time.timeScale = 0;

            mapActive = false;

			mapOpenCloseSound.GetComponent<AudioSource>().Play();
        }
        else if (Input.GetKeyDown(KeyCode.M) && mapActive == false)
        {
            //tests if the m key has been pressed this frame to determine if the map should be hidden
            MapPanel.SetActive(false);

            //resets time to the normal passage of time (effectively unpausing the game)
            Time.timeScale = 1;

            mapActive = true;

			mapOpenCloseSound.GetComponent<AudioSource>().Play();
        }
    }
}
