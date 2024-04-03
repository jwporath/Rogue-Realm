using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHitsEnemy : MonoBehaviour
{
    private Health playerHealth;

    void Start()
    {
        // GameObject playerObj = GameObject.Find("HealthBarCanvas");
        // Get the Player component attached to the player object
        // playerHealth = playerObj.GetComponent<Health>();
        playerHealth = GetComponent<Health>(); // Assuming the Health script is on the same GameObject as this script
    }

    public void OnCollisionEnter2D(Collision2D other)
    {
        // Caleb for you to handle enemy being hit
        playerHealth.HandleCollisions(other);
        // Debug.Log("Hit enemy!");
    }
}

