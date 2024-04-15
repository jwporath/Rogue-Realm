using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using UnityEngine.SceneManagement;

public class Lacey_Player_Tests
{
    [UnitySetUp]
    public IEnumerator SetUpScene()
    {
        // Load the test scene
        yield return SceneManager.LoadSceneAsync("Lacey_Test_Scene");
    }

    // [Test]
    // public void checkScene()
    // {
    //     Scene scene = SceneManager.GetSceneByPath("Lacey_Test_Scene");
    //     Assert.IsTrue(scene.isLoaded);
    //     // GameObject buttonObj = GameObject.Find("Button");

    //     // Assert.IsNotNull(buttonObj);
    // }
    
    [Test]
    public void doesPlayerExist()
    {
        // Find the player object in the scene
        GameObject playerObj = GameObject.Find("Player");

        // Assert that the player object exists
        Assert.IsNotNull(playerObj);
    }

    [Test]
    public void isPlayerFacingRight()
    {
        GameObject playerObj = GameObject.Find("Player");

        // Get the Player component attached to the player object
        Player player = playerObj.GetComponent<Player>();

        // Assert that the player is facing right
        Assert.IsTrue(player.isPlayerFacingRight());
    }

    [Test]
    public void isBCModeOff()
    {
        GameObject playerObj = GameObject.Find("Player");

        // Get the Player component attached to the player object
        Player player = playerObj.GetComponent<Player>();
        Debug.Log(player.getBC());

        // Assert that BC mode is off
        Assert.IsFalse(player.getBC());
    }

    [Test]
    public void isMaxHealthSet()
    {
        GameObject playerObj = GameObject.Find("Player");

        // Get the Player component attached to the player object
        Player player = playerObj.GetComponent<Player>();

        Assert.IsTrue(player.getMaxHealth()==100);
    }

    [Test]
    public void doesPlayerHaveHealth()
    {
        GameObject playerObj = GameObject.Find("Player");

        // Get the Player component attached to the player object
        Player player = playerObj.GetComponent<Player>();

        Assert.IsTrue(player.getCurrentHealth()>0);
    }
}
