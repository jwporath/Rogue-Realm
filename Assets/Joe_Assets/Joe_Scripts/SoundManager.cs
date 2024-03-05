using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager
{
    int Volume = 100;
    public AudioClip testClip;
    private AudioSource testSource;
    public void testSound(){
        
        //testSource = GetComponent<AudioSource>();
        
        if(testClip != null){
            testSource.clip = testClip;
            testSource.Play();
        }else{
            Debug.LogError("No audio clip assigned.\n");
        }
    }

    public virtual void deathSound(){
        //play wilhelm scream
    }
    
    public virtual void hurtSound(){
        //play hurt sound
    }
    
    public virtual void attackSound(){
        //play attack sound
    }

    public virtual void moveSound(){
        //play movement sound
    }

    void musicManager(string MusicType){
        //play different songs at points in the game.
    }

}