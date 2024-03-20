using System.Collections;
using System.Collections.Generic;
using UnityEngine;

int const NoMusic = -1;
int const MenuMusic = 0;
int const GameMusic = 1;
int const BossMusic = 2;
int const DeathMusic = 3;

public class musicManager
{
    //play different songs at points in the game.

    private bool isPaused = false;
    private int currSong = NoMusic;
    public class pause()
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

                //Set the flag to true to indicate that the sound is now playing
                soundPlaying = true;

                //Reset after a delay
                Reset(TimeSpan.FromSeconds(soundClip.length));
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
