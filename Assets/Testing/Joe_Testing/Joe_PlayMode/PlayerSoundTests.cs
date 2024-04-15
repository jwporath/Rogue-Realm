using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class PlayerSoundTests
{
    // A Test behaves as an ordinary method

    // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
    // `yield return null;` to skip a frame.
    [UnityTest]
    public IEnumerator DeathSoundTest()
    {
        var playerSounds = new PlayerSounds();
        playerSounds.deathSound();
        yield return null;
        Assert.IsTrue(playerSounds.soundPlaying, "Death sound should be playing.");
        Assert.IsTrue(playerSounds.activeSound == "PlayerDeath", "Death sound validated.");
    }

    [UnityTest]
    public IEnumerator AttackSoundTest()
    {
        var playerSounds = new PlayerSounds();
        playerSounds.attackSound();
        yield return null;
        Assert.IsTrue(playerSounds.soundPlaying, "Attack sound should be playing.");
        Assert.IsTrue(playerSounds.activeSound == "Slash", "Attack sound validated.");
        
    }

    [UnityTest]
    public IEnumerator MoveSoundTest()
    {
        var playerSounds = new PlayerSounds();
        playerSounds.moveSound();
        yield return null;
        Assert.IsTrue(playerSounds.soundPlaying, "Move sound should be playing.");
        Assert.IsTrue(playerSounds.activeSound == "MoveSound", "Move sound validated.");
    }

    [UnityTest]
    public IEnumerator JumpSoundTest()
    {
        var playerSounds = new PlayerSounds();
        playerSounds.jumpSound();
        yield return null;
        Assert.IsTrue(playerSounds.soundPlaying, "Jump sound should be playing.");
        Assert.IsTrue(playerSounds.activeSound == "JumpSound", "Jump sound validated.");
    }

    [UnityTest]
    public IEnumerator HurtSoundTest()
    {
        var playerSounds = new PlayerSounds();
        playerSounds.hurtSound();
        yield return null;
        Assert.IsTrue(playerSounds.soundPlaying, "Hurt sound should be playing.");
        Assert.IsTrue(playerSounds.activeSound == "PlayerHit", "Hit sound validated.");
    }

}
