using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleAxe : MonoBehaviour
{
    [SerializeField] public Animator anim;
    [SerializeField] public float meleeSpeed;
    [SerializeField] public float weaponDamage;
    public float timeUntilMelee;
    // public float attackRate = 1.5f;   // Attack rate in attacks per second
    // public float damage = 9;         // Damage inflicted by the broom

    // private float nextAttackTime = 0f;  // Time when the broom can next attack

    // Update is called once per frame
    void Update()
    {
        if(timeUntilMelee <= 0f)
        {
            // If the player presses the 'a' key and enough time has passed since the last attack
            if(Input.GetKeyDown(KeyCode.P))
            {
                anim.SetTrigger("battleAxeAttack");
                // Perform the attack
                //Attack();
                // Set the next attack time based on the attack rate
                //timeUntilMelee = meleeSpeed;
            }
            else
            {
                timeUntilMelee -= Time.deltaTime;
            }
        }
        timeUntilMelee = 0;
    }

    void Attack()
    {
        // Perform the attack logic here, for example, damaging enemies
        Debug.Log("Broom attacks for " + weaponDamage + " damage!");
    }
}

