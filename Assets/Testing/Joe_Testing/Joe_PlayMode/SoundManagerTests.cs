using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class SoundManagerTests
{
    // A Test behaves as an ordinary method
    [UnityTest]
    public IEnumerator DeathSoundTest()
    {
        var soundManager = new SoundManager();
        soundManager.deathSound();
        yield return null;
        Assert.IsTrue(soundManager.soundPlaying, "Death sound should be playing.");
        Assert.IsTrue(soundManager.activeSound == "Scream", "Death sound validated.");
    }
}
