using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Room : MonoBehaviour
{
    private LDoor LeftDoor;
    private RDoor RightDoor;
    private TDoor TopDoor;
    private Bdoor BottomDoor;

    private Room()
    {
        LeftDoor = this.GetComponentInChildren<LDoor>(true);
        RightDoor = this.GetComponentInChildren<RDoor>(true);
        TopDoor = this.GetComponentInChildren<TDoor>(true);
        BottomDoor = this.GetComponentInChildren<Bdoor>(true);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
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

    public void GeneratePlatforms()
    {
        // int random = UnityEngine.Random.Range(1, 7);
        // GameObject platform;
        // switch(random)
        // {
        //     case 1:
        //         platform = Instantiate(Platform1, Room.transform);
        //         break;
        //     case 2:
        //         platform = Instantiate(Platform2, Room.transform);
        //         break;
        //     case 3:
        //         platform = Instantiate(Platform3, Room.transform);
        //         break;
        //     case 4:
        //         platform = Instantiate(Platform4, Room.transform);
        //         break;
        //     case 5:
        //         platform = Instantiate(Platform5, Room.transform);
        //         break;
        //     case 6:
        //         platform = Instantiate(Platform6, Room.transform);
        //         break;
            
        // }
    }
}
