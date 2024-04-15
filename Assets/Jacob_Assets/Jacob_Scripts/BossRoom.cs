// BossRoom.cs - Defines the BossRoom Object
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Scripting;

public class BossRoom : Room // Child of Room
{
    private GameObject EndLevelObj;
    private enemyBehavior Boss;

    // Find BossDoor and Boss objects
    void Start()
    {
        Component[] obj = this.gameObject.GetComponentsInChildren<Component>(true);
        foreach (Component i in obj)
        {
            if (i.tag == "EndLevel")
                EndLevelObj = i.gameObject;
        }
        Boss = GetComponentInChildren<enemyBehavior>();
    }

    // Checks if the boss is dead and updates the lock status appropriately.
    override public bool isLocked()
    {
        Locked = !Boss.isDead();
        return Locked;
    }

    // If boss is dead, enable BossDoor
    void Update()
    {
        if (Boss.isDead())
            EnableExit();
    }

    // Enables the BossDoor Object in scene
    private void EnableExit()
    {
        EndLevelObj.SetActive(true);
    }

    // override public void DebugMessage()
    // {
    //     Debug.Log("Called Boss Room Debug Message");
    // }
}
