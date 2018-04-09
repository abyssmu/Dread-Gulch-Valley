using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyBoulder : MonoBehaviour {

    public GameObject player;

    public GameObject explosion;

    private GameObject explosionInstance;

    public GameObject boulderText;

    private PlayerHealth playerHasDynamite;


	// Use this for initialization
	void Start () {

        player = GameObject.FindGameObjectWithTag("Player");

        playerHasDynamite = player.GetComponent<PlayerHealth>();

	}
	
	// Update is called once per frame
	void Update ()
    {
	
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            if (playerHasDynamite.hasDynamite == false)
            {
                boulderText.SetActive(true);
            }

            else if (playerHasDynamite.hasDynamite == true)
            {
                explosionInstance = Instantiate(explosion, gameObject.transform.position, Quaternion.identity) as GameObject;

                ParticleSystem[] particles = explosionInstance.GetComponentsInChildren<ParticleSystem>();
                foreach (ParticleSystem particle in particles)
                {
                    particle.Play();
                }
                playerHasDynamite.hasDynamite = false;
                GameObject explosionPlaceholder = GameObject.FindGameObjectWithTag("ExplosionAudio");
                explosionPlaceholder.GetComponent<AudioSource>().Play();

                Destroy(gameObject);
            }
        }
        
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            boulderText.SetActive(false);
        }
    }
  
}
