using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

public class Sword1 : MonoBehaviour
{
    [SerializeField] public Animator anim;
    [SerializeField] public float meleeSpeed;
    [SerializeField] public float weaponDamage;

    
    public float timeUntilMelee;
    //public float attackRate = 1f;   // Attack rate in attacks per second
    //public float damage = 7;         // Damage inflicted by the broom

    //private float nextAttackTime = 0f;  // Time when the broom can next attack

    // Update is called once per frame
    private void Update()
    {
        if(timeUntilMelee <= 0f)
        {
            // If the player presses the 'a' key and enough time has passed since the last attack
            if(Input.GetKeyDown(KeyCode.P))
            {
                anim.SetTrigger("swordAttack");
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
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Enemy")
        {
            //Need to talk to Caleb about this "TakeDamage" function in Enemy script
            //other.GetComponent<Enenmy>().TakeDamage(weaponDamage);
            Debug.Log("Enemy hit!!");
        }
    }

    // void Attack()
    // {
    //     // Perform the attack logic here, for example, damaging enemies
    //     Debug.Log("Sword attacks for " + weaponDamage + " damage!");
    // }
}

