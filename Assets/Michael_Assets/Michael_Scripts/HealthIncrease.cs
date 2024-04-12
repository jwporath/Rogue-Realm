using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthIncrease : MonoBehaviour
{
    //public AudioClip pickupSound; // Sound to play when the coin is picked up
    private Player player;

    private bool hasBeenPickedUp = false; // Flag to prevent multiple pickups

    void Start()
    {
        player = FindObjectOfType<Player>();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        // Check if the collider is the player and if the coin has not already been picked up
        if (other.CompareTag("Player") && !hasBeenPickedUp)
        {
            // Generate a random number between 10 and 30
            float randomHealthAmount = Random.Range(10, 31);

            // Add the random coin amount to the coin count
            //GameManager.instance.AddCoins(randomCoinAmount);
            Debug.Log("Player has picked up "+randomHealthAmount+" health stats!!");


            player.increaseHealth(randomHealthAmount);
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