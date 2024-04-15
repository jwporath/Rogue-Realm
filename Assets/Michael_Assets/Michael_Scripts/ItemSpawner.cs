using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class ItemSpawner : MonoBehaviour
{
    [SerializeField] private GameObject speedIncrease;
    [SerializeField] private GameObject jumpIncrease;
    [SerializeField] private GameObject damageIncrease;
    [SerializeField] private GameObject healthIncrease;
    [SerializeField] private GameObject attackRateIncrease;
    [SerializeField] private GameObject sword;
    [SerializeField] private GameObject baseballBat;
    [SerializeField] private GameObject battleAxe;
    [SerializeField] private GameObject clubber;
    [SerializeField] private GameObject umbrella;
    [SerializeField] private GameObject shovel;
    [SerializeField] private GameObject pipeWrench;
    [SerializeField] private GameObject hammer;
    [SerializeField] private GameObject broom;
    [SerializeField] private GameObject machete;
    [SerializeField] private GameObject coin;
    // Start is called before the first frame update

    public void createItem(GameObject parent)
    {
        int random = UnityEngine.Random.Range(0,7);
        switch(random)
        {
            case 0:
                Instantiate(coin, parent.transform.position, Quaternion.identity, parent.transform);
                break;
            case 1:
                Instantiate(speedIncrease, parent.transform.position, Quaternion.identity, parent.transform);
                break;
            case 2:
                Instantiate(jumpIncrease, parent.transform.position, Quaternion.identity, parent.transform);
                break;
            case 3:
                Instantiate(damageIncrease, parent.transform.position, Quaternion.identity, parent.transform);
                break;
            case 4:
                Instantiate(healthIncrease, parent.transform.position, Quaternion.identity, parent.transform);
                break;
            case 5:
                Instantiate(attackRateIncrease, parent.transform.position, Quaternion.identity, parent.transform);
                break;
            case 6:
                Instantiate(sword, parent.transform.position, Quaternion.identity, parent.transform);
                break;
            case 7:
                Instantiate(baseballBat, parent.transform.position, Quaternion.identity, parent.transform);
                break;
            case 8:
                Instantiate(battleAxe, parent.transform.position, Quaternion.identity, parent.transform);
                break;
            case 9:
                Instantiate(clubber, parent.transform.position, Quaternion.identity, parent.transform);
                break;
            case 10:
                Instantiate(umbrella, parent.transform.position, Quaternion.identity, parent.transform);
                break;
            case 11:
                Instantiate(shovel, parent.transform.position, Quaternion.identity, parent.transform);
                break;
            case 12:
                Instantiate(pipeWrench, parent.transform.position, Quaternion.identity, parent.transform);
                break;
            case 13:
                Instantiate(hammer, parent.transform.position, Quaternion.identity, parent.transform);
                break;
            case 14:
                Instantiate(broom, parent.transform.position, Quaternion.identity, parent.transform);
                break;
            case 15:
                Instantiate(machete, parent.transform.position, Quaternion.identity, parent.transform);
                break;
        }
    }
}
