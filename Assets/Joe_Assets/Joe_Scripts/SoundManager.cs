using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using System;
using UnityEngine;

public class SoundManager
{
    public  string activeSound = "";
    public bool soundPlaying = false;

    public async Task Reset(TimeSpan delay)
    {
        await Task.Delay(delay);
        soundPlaying = false;
    }

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
        playSound("Scream");
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

    public void playSound(string soundName){
        //Check if the sound is not already playing
        if (!soundPlaying)
        {
            GameObject gameObject = new GameObject(soundName);
            AudioClip soundClip = Resources.Load<AudioClip>("Joe_Resources/" + soundName);

            //Check if the audio clip is not null before using it
            if (soundClip != null)
            {
                //Create an AudioSource component on the same GameObject
                AudioSource audioSource = gameObject.AddComponent<AudioSource>();

                //Set the AudioClip for the AudioSource
                audioSource.clip = soundClip;

                //Set the flag to true to indicate that the sound is now playing
                soundPlaying = true;

                //set active sound
                activeSound = soundName;
                //Reset after a delay
                Reset(TimeSpan.FromSeconds(soundClip.length));
                //Play the audio
                audioSource.Play();

                //Destroy the GameObject after the audio clip finishes playing
                GameObject.Destroy(gameObject, soundClip.length);

            }
            else
            {
                Debug.LogError("No audio clip assigned to the jump.\n");
                GameObject.Destroy(gameObject);
            }
        }
    }

}