using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cactus : MonoBehaviour
{


    private GameObject player;
    private PlayerHealth cactus;


    public int DamagePerHit = 10;

	// Use this for initialization
	void Start ()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        cactus = player.GetComponent<PlayerHealth>();
    }
	
	
    private void OnTriggerEnter (Collider other)
    {
        if (other.gameObject == player)
        {
            cactus.currentHealth -= 10;
            cactus = player.GetComponent<PlayerHealth>();
            cactus.playerHealthSlider.value = cactus.CalculateRemainingHealth();
            //gameObject.SetActive(false);
        }
    }

}
