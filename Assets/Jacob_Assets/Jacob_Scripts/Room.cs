// Room.cs - defines Room object
using System.Collections;
using System.Collections.Generic;
using Codice.Client.BaseCommands;
using Codice.Client.Common.GameUI;
using Unity.VisualScripting.Antlr3.Runtime;
using UnityEngine;

public class Room : MonoBehaviour
{
    protected bool Locked;
    private LDoor LeftDoor;
    private RDoor RightDoor;
    private TDoor TopDoor;
    private Bdoor BottomDoor;
    private int x;
    private int y;
    private enemyBehavior[] enemies;

    // Find child door objects, default doors to unlocked.
    void Awake()
    {
        LeftDoor = this.GetComponentInChildren<LDoor>(true);
        RightDoor = this.GetComponentInChildren<RDoor>(true);
        TopDoor = this.GetComponentInChildren<TDoor>(true);
        BottomDoor = this.GetComponentInChildren<Bdoor>(true);
        Locked = false;
    }

    // Find enemies in this instance of room. If enemies exist, lock doors.
    void Start()
    {
        enemies = this.GetComponentsInChildren<enemyBehavior>();
        if (enemies.Length > 0)
            Locked = true;
    }

    // Check lock status
    void Update()
    {
        if(Locked == true)
            isLocked();
    }

    // virtual public void DebugMessage()
    // {
    //     Debug.Log("Called Room Debug Message");
    // }

    // Checks if enemies are still alive and updates locked status appropriately.
    virtual public bool isLocked()
    {
        bool AllDead = true;
        foreach (enemyBehavior i in enemies)
        {
            if (!i.isDead())
                AllDead = false;
        }

        if (AllDead)
            Locked = false;
        return Locked;
    }

    // Enables the top door object of the room
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

    // Enables the bottom door object of the room
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

    // Enables the Right door object of the room
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

    // Enables the left door object of the room
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

    // sets the x value of the room
    public void SetX(int value)
    {
        x = value;
    }

    // returns x value
    public int GetX()
    {
        return x;
    }

    // sets the y value of the room
    public void SetY(int value)
    {
        y = value;
    }

    // returns y value
    public int GetY()
    {
        return y;
    }
}
