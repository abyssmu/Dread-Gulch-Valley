using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetActiveMapNotification : MonoBehaviour
{
    private PlayerHealth playerHealth;

    // Use this for initialization
    void Start ()
    {
        playerHealth = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerHealth>();
        if (playerHealth.hasMap)
            gameObject.SetActive(false);
    }
	
	// Update is called once per frame
	void Update ()
    {
		
	}
}