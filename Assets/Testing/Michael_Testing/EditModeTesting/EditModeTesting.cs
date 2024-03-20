using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class TestScript
{
    // A Test behaves as an ordinary method

    [Test]
    public void SwordTest()
    {
        GameObject sword = new GameObject("Sword1");
        Assert.IsTrue(sword);
        Debug.Log("sword creation test");
    }

    // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
    // `yield return null;` to skip a frame.
   
}
