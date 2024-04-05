using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class MusicManagerTests
{
    // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
    // `yield return null;` to skip a frame.
    [UnityTest]
    public IEnumerator GameMusicTest()
    {
        var music = new musicManager();
        music.gameMusic();
        Assert.IsTrue(music.songPlaying == "Game", "Game sound validated.");
        yield return null;
    }

    [UnityTest]
    public IEnumerator BossMusicTest()
    {
        var music = new musicManager();
        music.bossMusic();

        Assert.IsTrue(music.songPlaying == "Boss", "Boss sound validated.");
        yield return null;
    }
}
