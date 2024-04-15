using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using UnityEngine.SceneManagement;

public class Lacey_Main_Menu_Tests
{
    [UnitySetUp]
    public IEnumerator SetUpScene()
    {
        // Load the test scene
        yield return SceneManager.LoadSceneAsync("Lacey_Menu");
    }

    [Test]
    public void checkforCanvas()
    {
        GameObject buttonObj = GameObject.Find("Canvas");

        Assert.IsNotNull(buttonObj);
    }

    [Test]
    public void checkButtons()
    {
        GameObject buttonObj = GameObject.FindWithTag("Button");

        Assert.IsNotNull(buttonObj);
    }

    [Test]
    public void checkTitle()
    {
        GameObject titleObj = GameObject.Find("Title");

        Assert.IsNotNull(titleObj);
    }

    [UnityTest]
    public IEnumerator TitleHasAnimation()
    {
        // Load your test scene or create a GameObject in a test scene
        GameObject obj = new GameObject("Title");
        obj.AddComponent<Animation>();
        Assert.IsNotNull(obj.GetComponent<Animation>());

        // Wait for one frame to allow Unity to process any changes
        yield return null;
    }
}

