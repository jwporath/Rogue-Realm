using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class SoundManagerTests
{
    // A Test behaves as an ordinary method

    // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
    // `yield return null;` to skip a frame.
    [UnityTest]
    public IEnumerator DeathSoundTest()
    {
        var SoundManager = new SoundManager();
        SoundManager.deathSound();
        yield return null;
        Assert.IsTrue(SoundManager.soundPlaying, "Death sound should be playing.");
        Assert.IsTrue(SoundManager.activeSound == "Scream", "Death sound validated.");
    }

    [UnityTest]
    public IEnumerator AttackSoundTest()
    {
        var SoundManager = new SoundManager();
        SoundManager.attackSound();
        yield return null;
        Assert.IsTrue(SoundManager.soundPlaying, "Attack sound should be playing.");
        Assert.IsTrue(SoundManager.activeSound == "Scream", "Attack sound validated.");
        
    }

    [UnityTest]
    public IEnumerator MoveSoundTest()
    {
        var SoundManager = new SoundManager();
        SoundManager.moveSound();
        yield return null;
        Assert.IsTrue(SoundManager.soundPlaying, "Move sound should be playing.");
        Assert.IsTrue(SoundManager.activeSound == "Scream", "Move sound validated.");
    }

    [UnityTest]
    public IEnumerator JumpSoundTest()
    {
        var SoundManager = new SoundManager();
        SoundManager.jumpSound();
        yield return null;
        Assert.IsTrue(SoundManager.soundPlaying, "Jump sound should be playing.");
        Assert.IsTrue(SoundManager.activeSound == "Scream", "Jump sound validated.");
    }

    [UnityTest]
    public IEnumerator HurtSoundTest()
    {
        var SoundManager = new SoundManager();
        SoundManager.hurtSound();
        yield return null;
        Assert.IsTrue(SoundManager.soundPlaying, "Hurt sound should be playing.");
        Assert.IsTrue(SoundManager.activeSound == "Scream", "Hit sound validated.");
    }

}
