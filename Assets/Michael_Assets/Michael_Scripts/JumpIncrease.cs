using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpIncrease : MonoBehaviour
{
    //public AudioClip pickupSound; // Sound to play when the powerup is picked up
    [SerializeField] private Player Player;

    private bool hasBeenPickedUp = false; // Flag to prevent multiple pickups

    void OnTriggerEnter2D(Collider2D other)
    {
        // Check if the collider is the player and if the jump increase powerup has not already been picked up
        if (other.CompareTag("Player") && !hasBeenPickedUp)
        {
            // Generate a random number between 1 and 2
            int randomJumpAmount = Random.Range(1, 3);

            // Add the random jump amount to the jump power stat
            
            Debug.Log("Player has increased jump power by "+randomJumpAmount+"!!");
            //GameObject("Player").Jump(EntityJumpingState += randomJumpAmount);

            Player.increaseJumpingPower(randomJumpAmount);

            // Play pickup sound
            /*if (pickupSound != null)
            {
                AudioSource.PlayClipAtPoint(pickupSound, transform.position);
            }*/

            // Set flag to prevent multiple pickups
            hasBeenPickedUp = true;

            // Disable the jump power powerup object
            gameObject.SetActive(false);
        }
    }
}
