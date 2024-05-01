using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySounds : SoundManager
{
    //decoration of decorator pattern
    public override void deathSound()
    {
        playSound("Scream");
    }

    public override void hurtSound()
    {
        playSound("Scream");
    }

    public override void attackSound()
    {
        playSound("Scream");
    }

    public override void moveSound()
    {
        playSound("Scream");
    }

    public override void jumpSound()
    {
        playSound("Scream");
    }
}
