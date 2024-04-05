using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class musicManager
{
    //play different songs at points in the game.
    public string songPlaying = "None";
    private bool isPaused = false;
    
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
                songPlaying = songName;
                audioSource.loop = true;
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

    public void menuMusic()
    {
        PlaySong("Menu");
    }

    public void gameMusic()
    {
        PlaySong("Game");
    }

    public void bossMusic()
    {
        PlaySong("Boss");
    }

    public void deathMusic()
    {
        PlaySong("Death");
    }
}
