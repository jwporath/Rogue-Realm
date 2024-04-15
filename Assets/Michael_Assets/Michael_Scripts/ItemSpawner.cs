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
    // Start is called before the first frame update
    void Start()
    {
        createItem(this.gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void createItem(GameObject parent)
    {
        int random = UnityEngine.Random.Range(1,6);
        switch(random)
        {
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
        }
            

    }
}
