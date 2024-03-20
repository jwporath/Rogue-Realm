using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class musicManager
{
    //play different songs at points in the game.
    int NoMusic = -1;
    int MenuMusic = 0;
    int GameMusic = 1;
    int BossMusic = 2;
    int DeathMusic = 3;
    private bool isPaused = false;
    
    private int currSong = -1;
    void pause()
    {
        isPaused = true;
    }

    void PlaySong(string songName)
    {
        //Check if the sound is not already playing
        if (!isPaused)
        {
            GameObject gameObject = new GameObject(songName);
            AudioClip soundClip = Resources.Load<AudioClip>("Joe_Resources/" + songName);

            //Check if the audio clip is not null before using it
            if (soundClip != null)
            {
                //Create an AudioSource component on the same GameObject
                AudioSource audioSource = gameObject.AddComponent<AudioSource>();

                //Set the AudioClip for the AudioSource
                audioSource.clip = soundClip;

                //Play the audio
                audioSource.Play();

                //Destroy the GameObject after the audio clip finishes playing
                GameObject.Destroy(gameObject, soundClip.length);

            }
            else
            {
                Debug.LogError("No audio clip assigned to this song.\n");
                GameObject.Destroy(gameObject);
            }
        }
        else
        {
            Debug.LogError("There is a pause in effect. \n");
        }
    }

    void menuMusic()
    {
        PlaySong("Menu");
    }

    void gameMusic()
    {
        PlaySong("Game");
    }

    void bossMusic()
    {
        PlaySong("Boss");
    }

    void deathMusic()
    {
        PlaySong("Death");
    }
}
