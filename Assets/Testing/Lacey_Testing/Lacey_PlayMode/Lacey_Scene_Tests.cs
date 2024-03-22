using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using NUnit.Framework;

public class Lacey_Scene_Tests
{
    [Test]
    public void LoadAllScenes()
    {
        // string scenePath = "Lacey_Test_Scene";
        // // Start loading the scene asynchronously
        // AsyncOperation asyncLoad = SceneManager.LoadSceneAsync(scenePath);

        // // Wait until the asynchronous operation is done loading the scene
        // while (!asyncLoad.isDone)
        // {
        //     yield return null;
        // }

        // // Check if the scene is loaded
        // Scene scene = SceneManager.GetSceneByPath(scenePath);
        // Assert.IsTrue(scene.isLoaded, $"Scene '{scenePath}' failed to load.");

        // Get all scene paths in the project
        // string[] scenePaths = GetAllScenePaths();
        

        // foreach (string scenePath in scenePaths)
        // {
        //     Scene scene = SceneManager.GetSceneByPath(scenePath);

        //     // Load the scene
        //     SceneManager.LoadScene(scenePath, LoadSceneMode.Single);

        //     // Check if the scene loaded without any errors
        //     // Assert.IsTrue(SceneManager.GetSceneByPath(scenePath).isLoaded);
        //     Assert.IsTrue(scene.isLoaded);
        //     Debug.Log($"Scene {scenePath} failed to load.");
        // }
    }

    // private string[] GetAllScenePaths()
    // {
    //     // Get all scene paths in the project
    //     int sceneCount = SceneManager.sceneCountInBuildSettings;
    //     string[] scenePaths = new string[sceneCount];

    //     for (int i = 0; i < sceneCount; i++)
    //     {
    //         scenePaths[i] = SceneUtility.GetScenePathByBuildIndex(i);
    //     }

    //     return scenePaths;
    // }
}

