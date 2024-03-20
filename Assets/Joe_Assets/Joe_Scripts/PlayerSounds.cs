using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSounds : SoundManager
{

    public override void deathSound()
    {
        playSound("PlayerDeath");
    }

    public override void hurtSound()
    {
        playSound("PlayerHit");
    }

    public override void attackSound()
    {
        playSound("Slash");
    }

    public override void moveSound()
    {
       playSound("MoveSound");
    }

    public void jumpSound()
    {
        playSound("JumpSound");
    }

}
