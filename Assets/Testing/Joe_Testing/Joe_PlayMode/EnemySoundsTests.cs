using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class EnemySoundsTests
{
    // A Test behaves as an ordinary method
   [UnityTest]
    public IEnumerator DeathSoundTest()
    {
        var EnemySounds = new EnemySounds();
        EnemySounds.deathSound();
        yield return null;
        Assert.IsTrue(EnemySounds.soundPlaying, "Death sound should be playing.");
        Assert.IsTrue(EnemySounds.activeSound == "Scream", "Death sound validated.");
    }

    [UnityTest]
    public IEnumerator AttackSoundTest()
    {
        var EnemySounds = new EnemySounds();
        EnemySounds.attackSound();
        yield return null;
        Assert.IsTrue(EnemySounds.soundPlaying, "Attack sound should be playing.");
        Assert.IsTrue(EnemySounds.activeSound == "Scream", "Attack sound validated.");
        
    }

    [UnityTest]
    public IEnumerator MoveSoundTest()
    {
        var EnemySounds = new EnemySounds();
        EnemySounds.moveSound();
        yield return null;
        Assert.IsTrue(EnemySounds.soundPlaying, "Move sound should be playing.");
        Assert.IsTrue(EnemySounds.activeSound == "Scream", "Move sound validated.");
    }

    [UnityTest]
    public IEnumerator JumpSoundTest()
    {
        var EnemySounds = new EnemySounds();
        EnemySounds.jumpSound();
        yield return null;
        Assert.IsTrue(EnemySounds.soundPlaying, "Jump sound should be playing.");
        Assert.IsTrue(EnemySounds.activeSound == "Scream", "Jump sound validated.");
    }

    [UnityTest]
    public IEnumerator HurtSoundTest()
    {
        var EnemySounds = new EnemySounds();
        EnemySounds.hurtSound();
        yield return null;
        Assert.IsTrue(EnemySounds.soundPlaying, "Hurt sound should be playing.");
        Assert.IsTrue(EnemySounds.activeSound == "Scream", "Hit sound validated.");
    }
}
