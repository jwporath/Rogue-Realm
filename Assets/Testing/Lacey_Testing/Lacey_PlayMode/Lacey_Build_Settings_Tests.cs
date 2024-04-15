using UnityEngine;
using UnityEngine.SceneManagement;
using NUnit.Framework;
using UnityEngine.TestTools;
using System.Collections;

public class Lacey_Build_Settings_Tests
{
    [UnityTest]
    public IEnumerator TestAllScenesInBuild()
    {
        // Iterate through all scenes in the build settings
        for (int i = 0; i < SceneManager.sceneCountInBuildSettings; i++)
        {
            string scenePath = SceneUtility.GetScenePathByBuildIndex(i);
            string sceneName = System.IO.Path.GetFileNameWithoutExtension(scenePath);

            // Load the scene asynchronously
            AsyncOperation asyncLoad = SceneManager.LoadSceneAsync(i, LoadSceneMode.Additive);
            yield return asyncLoad;

            // Check if the scene loaded successfully
            Assert.IsTrue(asyncLoad.isDone && asyncLoad.progress >= 0.9f);

            // Get the loaded scene
            Scene loadedScene = SceneManager.GetSceneByBuildIndex(i);

            // Unload the scene
            SceneManager.UnloadSceneAsync(loadedScene);
        }
    }
}
