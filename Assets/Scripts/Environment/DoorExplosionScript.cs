using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorExplosionScript : MonoBehaviour
{
    public float explosionDuration = 2.0f;

    private float timer = 0.0f;
    private bool isExploding = false;
    
    public void Update()
    {
        if (isExploding && timer < explosionDuration)
        {
            timer += Time.deltaTime;
        }

        if (timer >= explosionDuration)
        {
            Destroy(gameObject);

            //GameObject explosion = GameObject.Find("Explosion");
            //explosion.SetActive(false);
            MeshRenderer mr = gameObject.GetComponent<MeshRenderer>();
            if (mr != null)
                mr.enabled = false;

            MeshRenderer[] mrs = gameObject.GetComponentsInChildren<MeshRenderer>();
            for (int i = 0; i < mrs.Length; i++)
                mrs[i].enabled = false;

            GameObject explosion = GameObject.Find("Explosion");
            if (explosion != null)
                explosion.SetActive(false);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            PlayerHealth player = other.gameObject.GetComponent<PlayerHealth>();
            if (player.hasDynamite)
            {
                //GameObject explosion = GameObject.Find("Explosion");
                //explosion.SetActive(true);
                //isExploding = true;
                GameObject explosion = GameObject.Find("Explosion");
                if (explosion == null)
                    return;

                explosion.SetActive(true);
                isExploding = true;
                (GetComponent<AudioSource>()).Play();
                ParticleSystem[] particles = explosion.GetComponentsInChildren<ParticleSystem>();
                for (int i = 0; i < particles.Length; i++)
                    particles[i].Play();
            }
            else
            {
                GameObject nm = GameObject.Find("NotificationText");
                if (nm == null)
                    return;

                NotificationsManager noteManager = nm.GetComponent<NotificationsManager>();

                if (noteManager == null)
                    return;

                noteManager.SetNotification("You need the dynamite from the town to open the vault!");
            }
        }
    }
}