using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupDynamite : MonoBehaviour {

    private GameObject player;

    private PlayerHealth getDynamite;

	private AudioSource dynamiteSound;

    private void Start()
	{
        player = GameObject.FindGameObjectWithTag("Player");

        getDynamite = player.GetComponent<PlayerHealth>();

		dynamiteSound = GameObject.FindGameObjectWithTag("dynamiteSound").GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
			dynamiteSound.Play();
            getDynamite.hasDynamite = true;
            Destroy(gameObject);
        }
    }
}
