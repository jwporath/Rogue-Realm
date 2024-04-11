using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    // Start is called before the first frame update
   private PlayerSounds sounds = new PlayerSounds();
   private musicManager music;
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.Space)){
            sounds.jumpSound();
        }

        if(Input.GetKey(KeyCode.LeftArrow)||Input.GetKey(KeyCode.RightArrow)){
            sounds.moveSound();
        }
    }

    void start(){
        music.gameMusic();
    }
}
