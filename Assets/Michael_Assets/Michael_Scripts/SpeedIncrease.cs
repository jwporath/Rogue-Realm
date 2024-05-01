using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedIncrease : MonoBehaviour
{
    //public AudioClip pickupSound; // Sound to play when the powerup is picked up
    private Player player;

    private bool hasBeenPickedUp = false; // Flag to prevent multiple pickups

    public virtual void Start()
    {
        player = FindObjectOfType<Player>();
        Debug.Log("Found the Player from the parent class!");
        
    }

    public virtual void OnTriggerEnter2D(Collider2D other)
    {
        // Check if the collider is the player and if the powerup has not already been picked up
        if (other.CompareTag("Player") && !hasBeenPickedUp)
        {
            // Increase player speed by 1
            float speedAmount = 1;

            // Add the random speed powerup amount to the player
            
            Debug.Log("Player has increase speed by "+ speedAmount +"!!");

            player.increaseSpeed(speedAmount);
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
