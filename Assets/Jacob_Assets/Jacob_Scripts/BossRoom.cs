using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Scripting;

public class BossRoom : Room
{
    private GameObject EndLevelObj;

    void Start()
    {
        Component[] obj = this.gameObject.GetComponentsInChildren<Component>(true);
        foreach (Component i in obj)
        {
            if (i.tag == "EndLevel")
                EndLevelObj = i.gameObject;
        }
    }

    void Update()
    {
        if (!EndLevelObj.activeInHierarchy) // Change this to check if boss is alive
            EnableExit();
    }

    private void EnableExit()
    {
        EndLevelObj.SetActive(true);
    }

    override public void DebugMessage()
    {
        Debug.Log("Called Boss Room Debug Message");
    }
}
