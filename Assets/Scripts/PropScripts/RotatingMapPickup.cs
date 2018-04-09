using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class RotatingMapPickup : MonoBehaviour {

    private PlayerHealth playerHealth;

    // Use this for initialization
    void Start () {

        playerHealth = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerHealth>();

        if (playerHealth.hasMap == true)
        {
            gameObject.SetActive(false);
        }

    }

    // Update is called once per frame
    void Update () {

        transform.Rotate(new Vector3(15.0f, 0.0f, 45.0f) * Time.deltaTime);

    }
}
