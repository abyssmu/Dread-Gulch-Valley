using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateOreSwitch : MonoBehaviour {

    GameObject player;
    public GameObject oreCart;

    Animation oreCartAnim;
    Animation leverAnim;

    int used = 0;

	// Use this for initialization
	void Start () {

        player = GameObject.FindGameObjectWithTag("Player");

        oreCartAnim = oreCart.GetComponent<Animation>();

        leverAnim = gameObject.GetComponent<Animation>();

	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player" && used != 1)
        {
            leverAnim.Play();
            oreCartAnim.Play();
            used = 1;
        }
    }
}
