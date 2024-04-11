using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Coin : MonoBehaviour
{
    //public AudioClip pickupSound; // Sound to play when the coin is picked up
    //GameObject player = GameObject.FindGameObjectWithTag("Player");
    [SerializeField] private Player Player;

    private bool hasBeenPickedUp = false; // Flag to prevent multiple pickups

    void OnTriggerEnter2D(Collider2D other)
    {
        // Check if the collider is the player and if the coin has not already been picked up
        if (other.CompareTag("Player") && !hasBeenPickedUp)
        {
            // Generate a random number between 1 and 10
            int randomCoinAmount = Random.Range(1, 11);

            // Add the random coin amount to the coin count
            //GameManager.instance.AddCoins(randomCoinAmount);
            Debug.Log("Player has picked up "+randomCoinAmount+" coins!!");  
            //GameObject player = GameObject.FindGameObjectWithTag("Player");
            Player.pickupCoins(randomCoinAmount);   

            // Set flag to prevent multiple pickups
            hasBeenPickedUp = true;

            // Disable the coin object
            gameObject.SetActive(false);
        }
    }
}

