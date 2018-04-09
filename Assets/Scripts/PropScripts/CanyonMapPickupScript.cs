using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanyonMapPickupScript : MonoBehaviour
{
    private PlayerHealth playerHealth;
	private AudioSource mapSound;

    // Use this for initialization
    void Start ()
    {
        playerHealth = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerHealth>();
		mapSound = GameObject.FindGameObjectWithTag("mapSound").GetComponent<AudioSource>();
    }
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            playerHealth.hasMap = true;
			mapSound.Play();
            gameObject.SetActive(false);
        }
    }
}
