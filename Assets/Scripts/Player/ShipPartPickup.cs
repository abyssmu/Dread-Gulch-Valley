using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipPartPickup : MonoBehaviour {

    public GameObject inventoryBar;

    public GameObject icons;


    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "ShipPart")
        {
            GameObject icon = Instantiate(icons);

            icon.transform.SetParent(inventoryBar.transform);

        }
    }
}
