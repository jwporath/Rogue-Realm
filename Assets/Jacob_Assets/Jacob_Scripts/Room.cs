using System.Collections;
using System.Collections.Generic;
using Codice.Client.Common.GameUI;
using UnityEngine;

public class Room : MonoBehaviour
{
    private LDoor LeftDoor;
    private RDoor RightDoor;
    private TDoor TopDoor;
    private Bdoor BottomDoor;
    private int x;
    private int y;

    void Awake()
    {
        LeftDoor = this.GetComponentInChildren<LDoor>(true);
        RightDoor = this.GetComponentInChildren<RDoor>(true);
        TopDoor = this.GetComponentInChildren<TDoor>(true);
        BottomDoor = this.GetComponentInChildren<Bdoor>(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    virtual public void DebugMessage()
    {
        Debug.Log("Called Room Debug Message");
    }

    public void EnableTopDoor()
    {
        // Enable Door Object
        TopDoor.gameObject.SetActive(true);

        // Disable NoDoor Object
        Component[] NoDoor = this.GetComponentsInChildren<Component>();
        foreach(Component i in NoDoor)
        {
            if(i.name == "TopNoDoor")
            {
                i.gameObject.SetActive(false);
            }
        }
    }

    public void EnableBottomDoor()
    {
        // Enable Door Object
        BottomDoor.gameObject.SetActive(true);

        // Disable NoDoor Object
        Component[] NoDoor = this.GetComponentsInChildren<Component>();
        foreach(Component i in NoDoor)
        {
            if(i.name == "BottomNoDoor")
            {
                i.gameObject.SetActive(false);
            }
        }
    }

    public void EnableRightDoor()
    {
        // Enable Door Object
        RightDoor.gameObject.SetActive(true);

        // Disable NoDoor Object
        Component[] NoDoor = this.GetComponentsInChildren<Component>();
        foreach(Component i in NoDoor)
        {
            if(i.name == "RightNoDoor")
            {
                i.gameObject.SetActive(false);
            }
        }
    }

    public void EnableLeftDoor()
    {
        // Enable Door Object
        LeftDoor.gameObject.SetActive(true);

        // Disable NoDoor Object
        Component[] NoDoor = this.GetComponentsInChildren<Component>();
        foreach(Component i in NoDoor)
        {
            if(i.name == "LeftNoDoor")
            {
                i.gameObject.SetActive(false);
            }
        }
    }

    public void SetX(int value)
    {
        x = value;
    }

    public int GetX()
    {
        return x;
    }

    public void SetY(int value)
    {
        y = value;
    }

    public int GetY()
    {
        return y;
    }
}
