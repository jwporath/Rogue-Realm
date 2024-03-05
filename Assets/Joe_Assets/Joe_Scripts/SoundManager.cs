using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager
{
    int Volume = 100;

    public void testSound()
    {
        GameObject testObject = new GameObject("testSounds");
        AudioClip testClip = Resources.Load<AudioClip>("Joe_Resources/BoingEffect");

        // Check if the audio clip is not null before using it
        if (testClip != null)
        {
            // Create an AudioSource component on the same GameObject
            AudioSource audioSource = testObject.AddComponent<AudioSource>();
            // Set the AudioClip for the AudioSource
            audioSource.clip = testClip;
            audioSource.Play();
            GameObject.Destroy(testObject, testClip.length);
        }
        else
        {
            Debug.LogError("No audio clip assigned.\n");
            GameObject.Destroy(testObject);
        }

        
    }

    public virtual void deathSound()
    {
        //play wilhelm scream
    }

    public virtual void hurtSound()
    {
        //play hurt sound
    }

    public virtual void attackSound()
    {
        //play attack sound
    }

    public virtual void moveSound()
    {
        //play movement sound
    }

    void musicManager(string MusicType)
    {
        //play different songs at points in the game.
    }

}