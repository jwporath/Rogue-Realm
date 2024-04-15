using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// MeleeWeaponFactory.cs
public static class MeleeWeaponFactory
{
    // Method to create melee weapons based on a given type
    public static IMeleeWeapon CreateMeleeWeapon(string weaponType)
    {
        switch (weaponType)
        {
            case "Sword1":
                return new Sword1(); // Instantiate Sword1 class
            // Add cases for other melee weapon types
            case "BaseballBat":
                return new BaseballBat();
            case "BattleAxe":
                return new BattleAxe();   
            case "Clubber":
                return new Clubber();
            case "Umbrella":
                return new Umbrella();
            case "Shovel":
                return new Shovel();
            case "PipeWrench":
                return new PipeWrench();
            case "Hammer":
                return new Hammer();
            case "Broom":
                return new Broom();
            case "Machete":
                return new Machete();           
            default:
                Debug.LogWarning("Unknown melee weapon type: " + weaponType);
                return null;
        }
    }
}

// **********************************************************************
// This needs to be attached to the playerController script (Lacey)

// PlayerController.cs
// public class PlayerController : MonoBehaviour
// {
//     private IMeleeWeapon currentWeapon;

//     void Start()
//     {
//         // Example: Creating a sword and equipping it
//         currentWeapon = MeleeWeaponFactory.CreateMeleeWeapon("Sword");
//     }

//     void Update()
//     {
//         // Example: Player input to trigger attack
//         if (Input.GetKeyDown(KeyCode.Space))
//         {
//             currentWeapon.Attack();
//         }
//     }
// }
// ***********************************************************************


