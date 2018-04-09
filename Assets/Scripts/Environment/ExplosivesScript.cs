using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosivesScript : MonoBehaviour
{
    private AudioSource sfxAudioSource;

    public float explosionDuration = 0.5f;

    private float timer = 0.0f;
    private bool isExploding = false;

    private EnableBankEntrance enabler;

    public void Start()
    {
        sfxAudioSource = GetComponent<AudioSource>();
        enabler = GetComponent<EnableBankEntrance>();
    }

    public void Update()
    {
        if (isExploding && timer < explosionDuration)
        {
            timer += Time.deltaTime;
        }

        if (timer >= explosionDuration)
        {
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

    public void Explode()
    {
        GameObject explosion = GameObject.Find("Explosion");
        explosion.SetActive(true);
        isExploding = true;
        ParticleSystem[] particles = explosion.GetComponentsInChildren<ParticleSystem>();
        for (int i = 0; i < particles.Length; i++)
            particles[i].Play();
        sfxAudioSource.Play();
        if (enabler != null)
            enabler.EnableTrigger();
    }
}