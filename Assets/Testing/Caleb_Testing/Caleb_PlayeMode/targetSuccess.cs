using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using UnityEngine.SceneManagement;

public class Caleb_PlayeMode
{
    [UnitySetUp]
    public IEnumerator level()
    {
        yield return SceneManager.LoadSceneAsync("Caleb_Scene");
    }
    [UnityTest]
    public IEnumerator PlayerTargeted()
    {
        yield return new WaitForSeconds(1f);
        GameObject enemyObject = GameObject.Find("EnemySkeleton");
        Rigidbody2D enemy = enemyObject.GetComponent<Rigidbody2D>();
        bool good;
        Assert.IsTrue(enemy.velocity.x != 0);
        // Use yield to skip a frame.
    }
}
