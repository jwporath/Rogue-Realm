using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySounds : SoundManager
{
    //decoration of decorator pattern
    public override void deathSound()
    {
        playSound("enemyDeath");
    }

    public override void hurtSound()
    {
        playSound("enemyHurt");
    }

    public override void attackSound()
    {
        playSound("enemyAttack");
    }

    public override void moveSound()
    {
        playSound("enemyMove");
    }

    public void jumpSound()
    {
        playSound("enemyJump");
    }
}
