using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Lacey_Player_Tests
{
    [UnitySetUp]
    public IEnumerator SetUpScene()
    {
        // Load the test scene
        yield return SceneManager.LoadSceneAsync("Jacob_Gen_Level");
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
    }

    [Test]
    public void isBCModeOff()
    {
        GameObject playerObj = GameObject.Find("Player");

        // Get the Player component attached to the player object
        Player player = playerObj.GetComponent<Player>();
        Debug.Log(player.getBC());

        // Assert that BC mode is off
        Assert.IsFalse(player.getBC(), "BC Mode is on, so you won't see damage to Player.");
    }

    [Test]
    public void isBCSpriteDisabled()
    {
        GameObject playerObj = GameObject.Find("Player");

        Assert.IsNotNull(playerObj, "Player not found in the scene");
        Transform playerTransform = playerObj.transform.Find("BCFace");

        Assert.IsNotNull(playerTransform, "BCFace not found as a child of the player");

        // Get the GameObject reference from the transform
        GameObject faceImage = playerTransform.gameObject;

        // Check if the pause menu canvas is inactive (disabled) on start
        Assert.IsFalse(faceImage.activeSelf, "BC Face is active (enabled) on start");
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

    [Test]
    public void PlayerCoinCounterEnabled()
    {
        // Find the parent canvas GameObject
        GameObject parentCanvas = GameObject.Find("PauseGameStuff");

        // Check if the parent canvas is found
        Assert.IsNotNull(parentCanvas, "Parent canvas not found in the scene");

        // Find the pause menu canvas GameObject as a child of the parent canvas
        Transform pauseMenuTransform = parentCanvas.transform.Find("CoinCounter");

        // Check if the child canvas is found
        Assert.IsNotNull(pauseMenuTransform, "CoinCounter not found as a child of the parent canvas");

        // Get the GameObject reference from the transform
        GameObject pauseMenuCanvas = pauseMenuTransform.gameObject;

        // Check if the pause menu canvas is inactive (disabled) on start
        Assert.IsTrue(pauseMenuCanvas.activeSelf, "CoinCounter is inactive (disabled) on start");
    }

    [Test]
    public void PlayerSpeedCounterEnabled()
    {
        // Find the parent canvas GameObject
        GameObject parentCanvas = GameObject.Find("PauseGameStuff");

        // Check if the parent canvas is found
        Assert.IsNotNull(parentCanvas, "Parent canvas not found in the scene");

        // Find the pause menu canvas GameObject as a child of the parent canvas
        Transform pauseMenuTransform = parentCanvas.transform.Find("SpeedCounter");

        // Check if the child canvas is found
        Assert.IsNotNull(pauseMenuTransform, "SpeedCounter not found as a child of the parent canvas");

        // Get the GameObject reference from the transform
        GameObject pauseMenuCanvas = pauseMenuTransform.gameObject;

        // Check if the pause menu canvas is inactive (disabled) on start
        Assert.IsTrue(pauseMenuCanvas.activeSelf, "SpeedCounter is inactive (disabled) on start");
    }

    [Test]
    public void PlayerJumpPowerCounterEnabled()
    {
        // Find the parent canvas GameObject
        GameObject parentCanvas = GameObject.Find("PauseGameStuff");

        // Check if the parent canvas is found
        Assert.IsNotNull(parentCanvas, "Parent canvas not found in the scene");

        // Find the pause menu canvas GameObject as a child of the parent canvas
        Transform pauseMenuTransform = parentCanvas.transform.Find("JumpPowerCounter");

        // Check if the child canvas is found
        Assert.IsNotNull(pauseMenuTransform, "JumpPowerCounter not found as a child of the parent canvas");

        // Get the GameObject reference from the transform
        GameObject pauseMenuCanvas = pauseMenuTransform.gameObject;

        // Check if the pause menu canvas is inactive (disabled) on start
        Assert.IsTrue(pauseMenuCanvas.activeSelf, "JumpPowerCounter is inactive (disabled) on start");
    }

    [Test]
    public void coinTextNotDefault()
    {
        // Find the parent canvas GameObject in the scene
        GameObject parentCanvas = GameObject.Find("PauseGameStuff");

        // Check if the parent canvas is found
        Assert.IsNotNull(parentCanvas, "PauseGameStuff canvas not found in the main menu scene");
        // Find the play button canvas as a child of the parent canvas
        Transform playButtonCanvasTransform = parentCanvas.transform.Find("CoinCounter");

        // Check if the button canvas is found
        Assert.IsNotNull(playButtonCanvasTransform, "CoinCounter not found as a child of the parent canvas");
        // Find the play button GameObject as a child of the parent canvas
        Transform playButtonTransform = playButtonCanvasTransform.transform.Find("CoinText");

        // Check if the text is found
        Assert.IsNotNull(playButtonTransform, "CoinText not found as a child of the parent canvas");
        Text myText = playButtonTransform.GetComponent<Text>();
        Assert.IsNotNull(myText, "Text component not found");

        // Get the current text of the Text object
        string currentText = myText.text;
        // Check if the text of the Text object is not "Speed"
        Assert.AreNotEqual("NumCoins", currentText, "Text object text is default");
    }

    [Test]
    public void speedTextNotDefault()
    {
        // Find the parent canvas GameObject in the scene
        GameObject parentCanvas = GameObject.Find("PauseGameStuff");

        // Check if the parent canvas is found
        Assert.IsNotNull(parentCanvas, "PauseGameStuff canvas not found in the main menu scene");
        // Find the play button canvas as a child of the parent canvas
        Transform playButtonCanvasTransform = parentCanvas.transform.Find("SpeedCounter");

        // Check if the button canvas is found
        Assert.IsNotNull(playButtonCanvasTransform, "SpeedCounter not found as a child of the parent canvas");
        // Find the play button GameObject as a child of the parent canvas
        Transform playButtonTransform = playButtonCanvasTransform.transform.Find("SpeedText");

        // Check if the text is found
        Assert.IsNotNull(playButtonTransform, "SpeedText not found as a child of the parent canvas");
        Text myText = playButtonTransform.GetComponent<Text>();
        Assert.IsNotNull(myText, "Text component not found");

        // Get the current text of the Text object
        string currentText = myText.text;
        // Check if the text of the Text object is not "Speed"
        Assert.AreNotEqual("Speed", currentText, "Text object text is default");
    }

    [Test]
    public void jumpTextNotDefault()
    {
        // Find the parent canvas GameObject in the scene
        GameObject parentCanvas = GameObject.Find("PauseGameStuff");

        // Check if the parent canvas is found
        Assert.IsNotNull(parentCanvas, "PauseGameStuff canvas not found in the main menu scene");
        // Find the play button canvas as a child of the parent canvas
        Transform playButtonCanvasTransform = parentCanvas.transform.Find("JumpPowerCounter");

        // Check if the button canvas is found
        Assert.IsNotNull(playButtonCanvasTransform, "JumpPowerCounter not found as a child of the parent canvas");
        // Find the play button GameObject as a child of the parent canvas
        Transform playButtonTransform = playButtonCanvasTransform.transform.Find("JumpText");

        // Check if the text is found
        Assert.IsNotNull(playButtonTransform, "JumpText not found as a child of the parent canvas");
        Text myText = playButtonTransform.GetComponent<Text>();
        Assert.IsNotNull(myText, "Text component not found");

        // Get the current text of the Text object
        string currentText = myText.text;
        // Check if the text of the Text object is not "Speed"
        Assert.AreNotEqual("JumpingPower", currentText, "Text object text is default");
    }

    [UnityTest]
    public IEnumerator PauseMenuCanvasIsDisabledOnStart()
    {
        // Load the scene containing the pause menu
        yield return SceneManager.LoadSceneAsync("Jacob_Gen_Level", LoadSceneMode.Single);

        // Find the parent canvas GameObject
        GameObject parentCanvas = GameObject.Find("PauseGameStuff");

        // Check if the parent canvas is found
        Assert.IsNotNull(parentCanvas, "Parent canvas not found in the scene");

        // Find the pause menu canvas GameObject as a child of the parent canvas
        Transform pauseMenuTransform = parentCanvas.transform.Find("PauseMenu");

        // Check if the pause menu canvas is found
        Assert.IsNotNull(pauseMenuTransform, "Pause menu canvas not found as a child of the parent canvas");

        // Get the GameObject reference from the transform
        GameObject pauseMenuCanvas = pauseMenuTransform.gameObject;

        // Check if the pause menu canvas is inactive (disabled) on start
        Assert.IsFalse(pauseMenuCanvas.activeSelf, "Pause menu canvas is active (enabled) on start");
    }

    [UnityTest]
    public IEnumerator EndCanvasIsDisabledOnStart()
    {
        // Load the scene containing the pause menu
        yield return SceneManager.LoadSceneAsync("Jacob_Gen_Level", LoadSceneMode.Single);

        // Find the parent canvas GameObject
        GameObject parentCanvas = GameObject.Find("PauseGameStuff");

        // Check if the parent canvas is found
        Assert.IsNotNull(parentCanvas, "Parent canvas not found in the scene");

        // Find the pause menu canvas GameObject as a child of the parent canvas
        Transform pauseMenuTransform = parentCanvas.transform.Find("EndCanvas");

        // Check if the child canvas is found
        Assert.IsNotNull(pauseMenuTransform, "End canvas not found as a child of the parent canvas");

        // Get the GameObject reference from the transform
        GameObject pauseMenuCanvas = pauseMenuTransform.gameObject;

        // Check if the pause menu canvas is inactive (disabled) on start
        Assert.IsFalse(pauseMenuCanvas.activeSelf, "End canvas is active (enabled) on start");
    }

    [UnityTest]
    public IEnumerator HealthBarIsEnabledOnStart()
    {
        // Load the scene containing the pause menu
        yield return SceneManager.LoadSceneAsync("Jacob_Gen_Level", LoadSceneMode.Single);

        // Find the parent canvas GameObject
        GameObject parentCanvas = GameObject.Find("PauseGameStuff");

        // Check if the parent canvas is found
        Assert.IsNotNull(parentCanvas, "Parent canvas not found in the scene");

        // Find the pause menu canvas GameObject as a child of the parent canvas
        Transform pauseMenuTransform = parentCanvas.transform.Find("PlayerHealthBarCanvas");

        // Check if the child canvas is found
        Assert.IsNotNull(pauseMenuTransform, "HealthBar canvas not found as a child of the parent canvas");

        // Get the GameObject reference from the transform
        GameObject pauseMenuCanvas = pauseMenuTransform.gameObject;

        // Check if the pause menu canvas is inactive (disabled) on start
        Assert.IsTrue(pauseMenuCanvas.activeSelf, "HealthBar canvas is inactive (disabled) on start");
    }

}