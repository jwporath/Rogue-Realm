using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class Michael_PlayMode
{
    // [UnityTest]
    // public IEnumerator SelectRandomWeapon_ReturnsValidWeapon()
    // {
    //     // Create an instance of the WeaponSelector script
    //     var weaponSelector = new WeaponSelector();

    //     // Call the SelectRandomWeapon function
    //     string selectedWeapon = weaponSelector.SelectRandomWeapon();

    //     // Wait for one frame to ensure that Random.Range has time to execute
    //     yield return null;

    //     // Check if the selected weapon is in the list of valid weapons
    //     bool isValidWeapon = IsValidWeapon(selectedWeapon);

    //     // Assert that the selected weapon is valid
    //     Assert.IsTrue(isValidWeapon, "Selected weapon is not valid: " + selectedWeapon);

    //     Debug.Log(selectedWeapon);
    // }

    // // Helper function to check if the selected weapon is valid
    // private bool IsValidWeapon(string weapon)
    // {
    //     string[] validWeapons = { "Sword1", "BaseballBat", "BattleAxe", "Clubber", "Umbrella", "Shovel", "PipeWrench", "Hammer", "Broom", "Machete" };
    //     return System.Array.IndexOf(validWeapons, weapon) != -1;
    // }

    // [UnityTest]
    // public IEnumerator SelectRandomPowerup_ReturnsValidPowerup()
    // {
    //     // Create an instance of the WeaponSelector script
    //     var powerupSelector = new PowerupSelecter();

    //     // Call the SelectRandomWeapon function
    //     string selectedPowerup = powerupSelector.SelectRandomPowerup();

    //     // Wait for one frame to ensure that Random.Range has time to execute
    //     yield return null;

    //     // Check if the selected weapon is in the list of valid weapons
    //     bool isValidWeapon = IsValidPowerup(selectedPowerup);

    //     // Assert that the selected weapon is valid
    //     Assert.IsTrue(isValidWeapon, "Selected weapon is not valid: " + selectedPowerup);

    //     Debug.Log(selectedPowerup);
    // }

    // // Helper function to check if the selected powerup is valid
    // private bool IsValidPowerup(string powerup)
    // {
    //     string[] validPowerup = {"DamageIncrease", "JumpIncrease", "SpeedIncrease", "AttackRateIncrease"};
    //     return System.Array.IndexOf(validPowerup, powerup) != -1;
    // }

    // [UnityTest]
    // public IEnumerator SpeedIncrease_FunctionIncreasesSpeed()
    // {
    //     // Create a GameObject to represent the player
    //     GameObject playerObject = new GameObject("Player");
    //     // Add a Rigidbody component to the player GameObject (assuming the player has a Rigidbody)
    //     Rigidbody playerRigidbody = playerObject.AddComponent<Rigidbody>();
    //     // Add a PlayerController component to the player GameObject
    //     Entity playerController = playerObject.AddComponent<Entity>();

    //     // Set the initial speed of the player
    //     float initialSpeed = playerController.speed;

    //     // Create a GameObject to represent the SpeedIncrease object
    //     GameObject speedIncreaseObject = new GameObject("SpeedBoost");
    //     // Add a Collider component to the SpeedIncrease GameObject (assuming it has a collider)
    //     BoxCollider speedIncreaseCollider = speedIncreaseObject.AddComponent<BoxCollider>();
    //     // Set the position of the SpeedIncrease object to be under the player
    //     speedIncreaseObject.transform.position = playerObject.transform.position;

    //     // Trigger the SpeedIncrease function by simulating a collision with the SpeedIncrease object
    //     speedIncreaseObject.OnTriggerEnter2D(speedIncreaseCollider);

    //     // Wait for one frame to allow the SpeedIncrease function to execute
    //     yield return null;

    //     // Check if the player's speed has increased
    //     Assert.AreEqual(initialSpeed + 1f, playerController.speed, "Player speed did not increase after walking over SpeedIncrease object");

    //     // Clean up: Destroy the player and SpeedIncrease GameObjects
    //     GameObject.Destroy(playerObject);
    //     GameObject.Destroy(speedIncreaseObject);
    // }
}

