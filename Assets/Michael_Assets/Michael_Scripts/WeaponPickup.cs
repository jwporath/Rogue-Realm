using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponPickup : MonoBehaviour
{
    //public GameObject weaponPrefab; // Reference to the weapon prefab
    public GameObject Broom;
    public Transform attachPoint; // Transform where the weapon will be attached to the player
    public float pickupRadius = 2f; // Radius around the player for picking up the weapon

    private bool isInRange = false; // Flag to indicate if the player is in range of the weapon

    void Update()
    {
        // Check if the player is in range and presses the "Tab" button
        if (isInRange && Input.GetKeyDown(KeyCode.Tab))
        {
            PickUpWeapon();
        }
    }

    void OnTriggerEnter(Collider other)
    {
        // Check if the collider is the player
        if (other.CompareTag("Player"))
        {
            isInRange = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        // Check if the collider is the player
        if (other.CompareTag("Player"))
        {
            isInRange = false;
        }
    }

    void PickUpWeapon()
    {
        // Instantiate the weapon prefab
        GameObject weapon = Instantiate(Broom, attachPoint.position, attachPoint.rotation);

        // Attach the weapon to the player's attach point
        weapon.transform.parent = attachPoint;

        // Disable the weapon pickup object
        gameObject.SetActive(false);
    }
}

