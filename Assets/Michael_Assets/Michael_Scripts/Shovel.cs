using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shovel : MonoBehaviour
{
    public float attackRate = 1f;   // Attack rate in attacks per second
    public float damage = 5;         // Damage inflicted by the broom

    private float nextAttackTime = 0f;  // Time when the broom can next attack

    // Update is called once per frame
    void Update()
    {
        // If the player clicks the mouse button and enough time has passed since the last attack
        if (Input.GetButtonDown("Fire1") && Time.time >= nextAttackTime)
        {
            // Perform the attack
            Attack();
            // Set the next attack time based on the attack rate
            nextAttackTime = Time.time + 1f / attackRate;
        }
    }

    void Attack()
    {
        // Perform the attack logic here, for example, damaging enemies
        Debug.Log("Broom attacks for " + damage + " damage!");
    }
}

