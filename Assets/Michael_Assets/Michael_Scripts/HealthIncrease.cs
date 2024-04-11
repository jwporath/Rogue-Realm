using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthIncrease : MonoBehaviour
{
    //public AudioClip pickupSound; // Sound to play when the coin is picked up

    private bool hasBeenPickedUp = false; // Flag to prevent multiple pickups

    void OnTriggerEnter2D(Collider2D other)
    {
        // Check if the collider is the player and if the coin has not already been picked up
        if (other.CompareTag("Player") && !hasBeenPickedUp)
        {
            // Generate a random number between 1 and 10
            float randomHealthAmount = Random.Range(1, 11);

            // Add the random coin amount to the coin count
            //GameManager.instance.AddCoins(randomCoinAmount);
            Debug.Log("Player has picked up "+randomHealthAmount+" health stats!!");

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