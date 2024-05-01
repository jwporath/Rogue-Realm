using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedIncrease2 : SpeedIncrease
{
    public Player player;
    public override void Start()
    {
        player = FindObjectOfType<Player>();
        Debug.Log("Found the Player from the child class!");
    }
   
}
