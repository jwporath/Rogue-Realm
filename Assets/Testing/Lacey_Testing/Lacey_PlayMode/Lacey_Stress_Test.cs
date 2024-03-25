using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using UnityEngine.SceneManagement;

public class Lacey_Stress_Test
{
    [UnitySetUp]
    public IEnumerator SetUpScene()
    {
        // Load the test scene
        yield return SceneManager.LoadSceneAsync("Lacey_Test_Scene");
    }
    
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
        // Assert.IsTrue(player.getSpeed()>0);

    }
}
