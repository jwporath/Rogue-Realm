using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class TestScript
{
    // A Test behaves as an ordinary method

    [Test]
    public void SwordTest1()
    {
        GameObject sword = new GameObject("Sword1");
        Assert.IsTrue(sword);
        Debug.Log("sword creation test...Successful!");
    }

    [Test]
    public void FireballTest()
    {
        GameObject fireball = new GameObject("FireBall");
        Assert.IsTrue(fireball);
        Debug.Log("fireball creation test...Successful!");
    }

    // [Test]
    // public void RandomWeaponSelecting()
    // {
    //     GameObject weapon = new GameObject(WeaponSelector.SelectRandomWeapon())
    // }

    // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
    // `yield return null;` to skip a frame.
    // [UnityTest]
    // public void SwordTest2()
    // {
        
    // }
   
}
