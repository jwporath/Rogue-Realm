using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageIncrease : MonoBehaviour
{
    //public AudioClip pickupSound; // Sound to play when the powerup is picked up

    private bool hasBeenPickedUp = false; // Flag to prevent multiple pickups

    void OnTriggerEnter2D(Collider2D other)
    {
        // Check if the collider is the player and if the powerup has not already been picked up
        if (other.CompareTag("Player") && !hasBeenPickedUp)
        {
            // Generate a random number between 1 and 4
            float randomDamageAmount = Random.Range(1, 5);

            Sword1 sword = other.GetComponent<Sword1>();
            sword.weaponDamage += randomDamageAmount;

            // Add the random damage amount to the player
            Debug.Log("Player increased damage by "+randomDamageAmount+"!!");

            // Play pickup sound
            /*if (pickupSound != null)
            {
                AudioSource.PlayClipAtPoint(pickupSound, transform.position);
            }*/

            // Set flag to prevent multiple pickups
            hasBeenPickedUp = true;

            // Disable the coin object
            gameObject.SetActive(false);
        }

    }
}
