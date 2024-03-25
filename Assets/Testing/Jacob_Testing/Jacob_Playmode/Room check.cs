using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEditor.VersionControl;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.TestTools;

public class Roomcheck
{
    // A Test behaves as an ordinary method
    [Test]
    public void RoomExists()
    {
        SceneManager.LoadScene("Jacob_Gen_Level");
        GameObject l1 = GameObject.Find("Level");
        Level l2 = l1.GetComponent<Level>();

        Room r = l2.GetRoom(4, 4);

        // Assert room exists
        Assert.IsTrue(r);
    }
}
