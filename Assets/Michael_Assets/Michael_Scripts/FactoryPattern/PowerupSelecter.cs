using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerupSelecter
{
    // Array of weapon names
    private string[] powerupNames = {"DamageIncrease", "JumpIncrease", "SpeedIncrease", "AttackRateIncrease"};

    // Function to randomly select a weapon
    public string SelectRandomPowerup()
    {
        // Get a random index within the range of weaponNames array
        int randomIndex = Random.Range(0, powerupNames.Length);

        // Return the weapon name at the randomly selected index
        return powerupNames[randomIndex];
    }
}
