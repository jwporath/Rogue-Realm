using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponSelector 
{
    // Array of weapon names
    private string[] weaponNames = { "Sword1", "BaseballBat", "BattleAxe", "Clubber", "Umbrella", "Shovel", "PipeWrench", "Hammer", "Broom", "Machete" };

    // Function to randomly select a weapon
    public string SelectRandomWeapon()
    {
        // Get a random index within the range of weaponNames array
        int randomIndex = Random.Range(0, weaponNames.Length);

        // Return the weapon name at the randomly selected index
        return weaponNames[randomIndex];
    }
}

