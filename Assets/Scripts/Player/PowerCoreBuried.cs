using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerCoreBuried : MonoBehaviour
{

    private GameObject player;
    private PlayerHealth powerCore;
    private EnemySpawner spawner;
    private NotificationsManager notify;

    public GameObject icons;
    public GameObject playerPowerCorePanel;

    // Use this for initialization
    void Start()
    {

        player = GameObject.FindGameObjectWithTag("Player");

        powerCore = player.GetComponent<PlayerHealth>();

        playerPowerCorePanel = GameObject.FindGameObjectWithTag("PowerCorePanel");

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            if (powerCore.hasShovel == true)
            {
                gameObject.SetActive(false);
                powerCore.hasPowerCore += 1;
                powerCore.currentShield += 50;
                powerCore.playerShieldSlider.value = powerCore.CalculateRemainingShield();

                GameObject icon = Instantiate(icons);

                icon.transform.SetParent(playerPowerCorePanel.transform);
            }
           
}
    }
}