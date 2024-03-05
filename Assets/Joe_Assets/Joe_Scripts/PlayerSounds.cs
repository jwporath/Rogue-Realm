using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSounds : SoundManager
{
    private bool soundPlaying = false;

    void Reset(){
        soundPlaying = false;
    }
    public override void deathSound(){
        //player death
    }

    public override void hurtSound(){
        //player hurt sound
    }
    
    public override void attackSound(){
        //player attack sound
    }

    public override void moveSound(){
        //player movement sound
    }

    public void jumpSound(){
        
      if (Input.GetKeyDown(KeyCode.Space))
        {
            // Check if the sound is not already playing
            if (!soundPlaying)
            {
                GameObject gameObject = new GameObject("JumpSound");
                AudioClip jumpClip = Resources.Load<AudioClip>("Joe_Resources/BoingEffect");

                // Check if the audio clip is not null before using it
                if (jumpClip != null)
                {
                    // Create an AudioSource component on the same GameObject
                    AudioSource audioSource = gameObject.AddComponent<AudioSource>();

                    // Set the AudioClip for the AudioSource
                    audioSource.clip = jumpClip;

                    // Play the audio
                    audioSource.Play();

                    // Set the flag to true to indicate that the sound is now playing
                    soundPlaying = true;

                    // Destroy the GameObject after the audio clip finishes playing
                    GameObject.Destroy(gameObject, jumpClip.length);

                    // Reset the flag after the sound has finished playing
                    Reset();
                }
                else
                {
                    Debug.LogError("No audio clip assigned to the jump.\n");
                    GameObject.Destroy(gameObject);
                }
            }
        }
    }
    
}
