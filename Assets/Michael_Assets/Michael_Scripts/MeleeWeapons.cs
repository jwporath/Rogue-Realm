using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeleeWeapons : MonoBehaviour
{
    public GameObject Sword1; // Reference to the first weapon game object
    public GameObject BaseballBat; // Reference to the second weapon game object

    private GameObject currentWeapon; // The currently equipped weapon

    private void Start()
    {
        // Initialize the player with the first weapon
        EquipWeapon(Sword1);
    }

    private void Update()
    {
        // Example: Switch weapons when the player presses a key (e.g., Tab)
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            // Toggle between weapons
            if (currentWeapon == Sword1)
            {
                EquipWeapon(BaseballBat);
            }
            else
            {
                EquipWeapon(Sword1);
            }
        }
    }

    private void EquipWeapon(GameObject newWeapon)
    {
        // Disable the current weapon
        if (currentWeapon != null)
            currentWeapon.SetActive(false);

        // Enable the new weapon
        newWeapon.SetActive(true);
        currentWeapon = newWeapon;
    }
}


