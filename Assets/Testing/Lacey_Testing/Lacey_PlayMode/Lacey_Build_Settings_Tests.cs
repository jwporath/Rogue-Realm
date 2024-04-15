using UnityEngine;
using UnityEngine.SceneManagement;
using NUnit.Framework;
using UnityEngine.TestTools;
using System.Collections;
using UnityEngine.UI;

public class Lacey_Build_Settings_Tests
{
    [UnityTest]
    public IEnumerator MenuSceneLoads()
    {
        string sceneToLoad = "Lacey_Menu";

        // Load the next scene
        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync(sceneToLoad, LoadSceneMode.Single);

        // Wait until the scene is loaded
        while (!asyncLoad.isDone)
        {
            yield return null;
        }

        // Check if the next scene is loaded
        Assert.IsTrue(SceneManager.GetSceneByName(sceneToLoad).isLoaded, "Menu scene is not loaded");
    }

    [UnityTest]
    public IEnumerator GameSceneLoads()
    {
        string sceneToLoad = "Jacob_Gen_Level";

        // Load the next scene
        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync(sceneToLoad, LoadSceneMode.Single);

        // Wait until the scene is loaded
        while (!asyncLoad.isDone)
        {
            yield return null;
        }

        // Check if the next scene is loaded
        Assert.IsTrue(SceneManager.GetSceneByName(sceneToLoad).isLoaded, "Game scene is not loaded");
    }

    [UnityTest]
    public IEnumerator MVPSceneLoads()
    {
        string sceneToLoad = "MVP";

        // Load the next scene
        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync(sceneToLoad, LoadSceneMode.Single);

        // Wait until the scene is loaded
        while (!asyncLoad.isDone)
        {
            yield return null;
        }

        // Check if the next scene is loaded
        Assert.IsTrue(SceneManager.GetSceneByName(sceneToLoad).isLoaded, "MVP scene is not loaded");
    }

    [UnityTest]
    public IEnumerator TestSceneLoads()
    {
        string sceneToLoad = "Lacey_Test_Scene";

        // Load the next scene
        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync(sceneToLoad, LoadSceneMode.Single);

        // Wait until the scene is loaded
        while (!asyncLoad.isDone)
        {
            yield return null;
        }

        // Check if the next scene is loaded
        Assert.IsTrue(SceneManager.GetSceneByName(sceneToLoad).isLoaded, "Lacey Test Scene is not loaded");
    }

    [UnityTest]
    public IEnumerator PlayButtonInMainMenu()
    {
        // Load the main menu scene
        yield return SceneManager.LoadSceneAsync("Lacey_Menu", LoadSceneMode.Single);

        // Find the parent canvas GameObject in the scene
        GameObject parentCanvas = GameObject.Find("Canvas");

        // Check if the parent canvas is found
        Assert.IsNotNull(parentCanvas, "Parent canvas not found in the main menu scene");

        // Find the play button canvas as a child of the parent canvas
        Transform playButtonCanvasTransform = parentCanvas.transform.Find("Buttons");

        // Check if the button canvas is found
        Assert.IsNotNull(playButtonCanvasTransform, "Button Canvas not found as a child of the parent canvas");

        // Find the play button GameObject as a child of the parent canvas
        Transform playButtonTransform = playButtonCanvasTransform.transform.Find("playButton");

        // Check if the play button is found
        Assert.IsNotNull(playButtonTransform, "Play button not found as a child of the parent canvas");

        // Get the play button component
        Button playButton = playButtonTransform.GetComponent<Button>();

        // Check if the play button component is found
        Assert.IsNotNull(playButton, "Play button component not found");

        // Get the onClick event from the play button
        var onClick = playButton.onClick;

        // Ensure that there's at least one listener for the onClick event
        Assert.Greater(onClick.GetPersistentEventCount(), 0, "Play button does not have any onClick listeners");

        // Get the name of the scene to load from the onClick event
        // string sceneToLoad = onClick.GetPersistentMethodName(0);
        string sceneToLoad = "Jacob_Gen_Level";

        // Load the next scene
        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync(sceneToLoad, LoadSceneMode.Single);

        // Wait until the scene is loaded
        while (!asyncLoad.isDone)
        {
            yield return null;
        }

        // Check if the next scene is loaded
        Assert.IsTrue(SceneManager.GetSceneByName(sceneToLoad).isLoaded, "Game scene is not loaded");
    }

    [UnityTest]
    public IEnumerator MainMenuButtonInEndCanvas()
    {
        // Load the main menu scene
        yield return SceneManager.LoadSceneAsync("Jacob_Gen_Level", LoadSceneMode.Single);

        // Find the parent canvas GameObject in the scene
        GameObject parentCanvas = GameObject.Find("PauseGameStuff");

        // Check if the parent canvas is found
        Assert.IsNotNull(parentCanvas, "PauseGameStuff canvas not found in the main menu scene");

        // Find the play button canvas as a child of the parent canvas
        Transform playButtonCanvasTransform = parentCanvas.transform.Find("EndCanvas");

        // Check if the button canvas is found
        Assert.IsNotNull(playButtonCanvasTransform, "End Canvas not found as a child of the parent canvas");

        // Find the play button GameObject as a child of the parent canvas
        Transform playButtonTransform = playButtonCanvasTransform.transform.Find("playButton");

        // Check if the play button is found
        Assert.IsNotNull(playButtonTransform, "Play button not found as a child of the parent canvas");

        // Get the play button component
        Button playButton = playButtonTransform.GetComponent<Button>();

        // Check if the play button component is found
        Assert.IsNotNull(playButton, "Play button component not found");

        // Get the onClick event from the play button
        var onClick = playButton.onClick;

        // Ensure that there's at least one listener for the onClick event
        Assert.Greater(onClick.GetPersistentEventCount(), 0, "Play button does not have any onClick listeners");

        // Get the name of the scene to load from the onClick event
        // string sceneToLoad = onClick.GetPersistentMethodName(0);
        string sceneToLoad = "Lacey_Menu";

        // Load the next scene
        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync(sceneToLoad, LoadSceneMode.Single);

        // Wait until the scene is loaded
        while (!asyncLoad.isDone)
        {
            yield return null;
        }

        // Check if the next scene is loaded
        Assert.IsTrue(SceneManager.GetSceneByName(sceneToLoad).isLoaded, "Main Menu scene is not loaded");
    }

}