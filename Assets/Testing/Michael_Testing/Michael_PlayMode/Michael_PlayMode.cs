using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class PlayModeTesting
{
    [UnityTest]
    public IEnumerator SelectRandomWeapon_ReturnsValidWeapon()
    {
        // Create an instance of the WeaponSelector script
        var weaponSelector = new WeaponSelector();

        // Call the SelectRandomWeapon function
        string selectedWeapon = weaponSelector.SelectRandomWeapon();

        // Wait for one frame to ensure that Random.Range has time to execute
        yield return null;

        // Check if the selected weapon is in the list of valid weapons
        bool isValidWeapon = IsValidWeapon(selectedWeapon);

        // Assert that the selected weapon is valid
        Assert.IsTrue(isValidWeapon, "Selected weapon is not valid: " + selectedWeapon);

        Debug.Log(selectedWeapon);
    }

    // Helper function to check if the selected weapon is valid
    private bool IsValidWeapon(string weapon)
    {
        string[] validWeapons = { "Sword1", "BaseballBat", "BattleAxe", "Clubber", "Umbrella", "Shovel", "PipeWrench", "Hammer", "Broom", "Machete" };
        return System.Array.IndexOf(validWeapons, weapon) != -1;
    }

    [UnityTest]
    public IEnumerator SelectRandomPowerup_ReturnsValidPowerup()
    {
        // Create an instance of the WeaponSelector script
        var powerupSelector = new PowerupSelecter();

        // Call the SelectRandomWeapon function
        string selectedPowerup = powerupSelector.SelectRandomPowerup();

        // Wait for one frame to ensure that Random.Range has time to execute
        yield return null;

        // Check if the selected weapon is in the list of valid weapons
        bool isValidWeapon = IsValidPowerup(selectedPowerup);

        // Assert that the selected weapon is valid
        Assert.IsTrue(isValidWeapon, "Selected weapon is not valid: " + selectedPowerup);

        Debug.Log(selectedPowerup);
    }

    // Helper function to check if the selected powerup is valid
    private bool IsValidPowerup(string powerup)
    {
        string[] validPowerup = {"DamageIncrease", "JumpIncrease", "SpeedIncrease", "AttackRateIncrease"};
        return System.Array.IndexOf(validPowerup, powerup) != -1;
    }
}

