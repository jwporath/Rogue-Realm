using System.Collections;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using UnityEditor.VersionControl;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.TestTools;

public class Roomcheck
{
    [UnitySetUp]
    public IEnumerator SetUpScene()
    {
        // Load the test scene
        yield return SceneManager.LoadSceneAsync("Jacob_Gen_Level");
    }

    // A Test behaves as an ordinary method
    [UnityTest]
    public IEnumerator LevelExists()
    {
        // wait for scene to call start()
        yield return new WaitForSeconds(1f);
        GameObject l1 = GameObject.Find("Level");

        // Assert level exists
        Assert.IsTrue(l1);
    }

    [UnityTest]
    public IEnumerator RoomExists()
    {
        // wait for scene to call start()
        yield return new WaitForSeconds(1f);
        GameObject l1 = GameObject.Find("Level");
        Level l2 = l1.GetComponent<Level>();

        Room r = l2.GetRoom(4, 4);

        // Assert room exists
        Assert.IsTrue(r);
    }

    [UnityTest] // WIP, Logic errors here
    public IEnumerator NoRoomOverlap()
    {
        // wait for scene to call start()
        yield return new WaitForSeconds(1f);
        bool valid = true;
        Room[] r = GameObject.FindObjectsOfType<Room>();

        if (r.Length != r.Distinct().Count())
        {
            valid = false;
        }

        // Assert room exists
        Assert.IsTrue(valid);
    }
}
