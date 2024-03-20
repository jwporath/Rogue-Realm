using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level : MonoBehaviour
{
    [SerializeField] private GameObject RoomPrefab;
    [SerializeField] private GameObject Platform1;
    [SerializeField] private GameObject Platform2;
    [SerializeField] private GameObject Platform3;
    [SerializeField] private GameObject Platform4;
    [SerializeField] private GameObject Platform5;
    [SerializeField] private GameObject Platform6;

    private GameObject[,] RoomMap = new GameObject[9, 9];
     
    // Start is called before the first frame update
    void Start()
    {
        // Place starting room in array
        Component[] startRoom = this.GetComponentsInChildren<Component>();
        foreach(Component i in startRoom)
        {
            if(i.name == "Room")
            {
                RoomMap[4, 4] = i.gameObject;
            }
        }
        GenerateLevel();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void GenerateLevel()
    {
        GenerateRoom();
    }

    GameObject GenerateRoom()
    {
        // create room
        GameObject Room = Instantiate(RoomPrefab, new Vector3(18, 0, 0), Quaternion.identity, this.gameObject.transform);

        // Enable door
        LDoor LeftDoor1 = Room.GetComponentInChildren<LDoor>(true);
        LeftDoor1.gameObject.SetActive(true);

        // Disable NoDoor object
        Component[] LeftNoDoor1 = Room.GetComponentsInChildren<Component>();
        foreach(Component i in LeftNoDoor1)
        {
            if(i.name == "LeftNoDoor")
            {
                i.gameObject.SetActive(false);
            }
        }

        int random = UnityEngine.Random.Range(1, 7);
        GameObject platform;
        switch(random)
        {
            case 1:
                platform = Instantiate(Platform1, Room.transform);
                break;
            case 2:
                platform = Instantiate(Platform2, Room.transform);
                break;
            case 3:
                platform = Instantiate(Platform3, Room.transform);
                break;
            case 4:
                platform = Instantiate(Platform4, Room.transform);
                break;
            case 5:
                platform = Instantiate(Platform5, Room.transform);
                break;
            case 6:
                platform = Instantiate(Platform6, Room.transform);
                break;
            
        }

        return Room;
    }
}
