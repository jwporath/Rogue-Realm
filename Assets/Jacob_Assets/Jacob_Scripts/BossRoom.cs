using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Scripting;

public class BossRoom : Room
{
    private GameObject EndLevelObj;
    private enemyBehavior Boss;

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

    override public bool isLocked()
    {
        Locked = !Boss.isDead();
        return Locked;
    }

    void Update()
    {
        if (Boss.isDead()) // Change this to check if boss is alive
            EnableExit();
    }

    private void EnableExit()
    {
        EndLevelObj.SetActive(true);
    }

    // override public void DebugMessage()
    // {
    //     Debug.Log("Called Boss Room Debug Message");
    // }
}
