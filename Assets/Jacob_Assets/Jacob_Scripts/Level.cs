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

    private Room[,] RoomMap = new Room[9, 9];
     
    void Awake()
    {
        // Set all elements in RoomMap to null
        for (int y = 0; y < 9; y++)
        {
            for (int x = 0; x < 9; x++)
            {
                RoomMap[x, y] = null;
            }
        }

        // Place starting room in array
        RoomMap[4, 4] = this.GetComponentInChildren<Room>();

        GenerateRooms();
    }

    void GenerateRooms()
    {
        // Create Right default room
        GameObject room = Instantiate(RoomPrefab, new Vector3(18, 0, 0), Quaternion.identity, this.gameObject.transform);
        room.transform.gameObject.tag = "New";

        // Add Room to RoomMap
        Room[] arr = this.GetComponentsInChildren<Room>();
        foreach (Room i in arr)
        {
            if (i.tag == "New")
            {
                RoomMap[5, 4] = i;
                RoomMap[5, 4].gameObject.transform.tag = "Untagged";
                RoomMap[5, 4].SetX(5);
                RoomMap[5, 4].SetY(4);
                RoomMap[5, 4].EnableLeftDoor();
            }
        }

        // Create Left default room
        room = Instantiate(RoomPrefab, new Vector3(-18, 0, 0), Quaternion.identity, this.gameObject.transform);
        room.transform.gameObject.tag = "New";

        // Add Room to RoomMap
        arr = this.GetComponentsInChildren<Room>();
        foreach (Room i in arr)
        {
            if (i.tag == "New")
            {
                RoomMap[3, 4] = i;
                RoomMap[3, 4].gameObject.transform.tag = "Untagged";
                RoomMap[3, 4].SetX(5);
                RoomMap[3, 4].SetY(4);
                RoomMap[3, 4].EnableRightDoor();
            }
        }

        // Add Platforms to Left
        int random = UnityEngine.Random.Range(1, 7);
        switch(random)
        {
            case 1:
                Instantiate(Platform1, RoomMap[3, 4].transform);
                break;
            case 2:
                Instantiate(Platform2, RoomMap[3, 4].transform);
                break;
            case 3:
                Instantiate(Platform3, RoomMap[3, 4].transform);
                break;
            case 4:
                Instantiate(Platform4, RoomMap[3, 4].transform);
                break;
            case 5:
                Instantiate(Platform5, RoomMap[3, 4].transform);
                break;
            case 6:
                Instantiate(Platform6, RoomMap[3, 4].transform);
                break;
            
        }

        // Add Platforms to Right
        random = UnityEngine.Random.Range(1, 7);
        switch(random)
        {
            case 1:
                Instantiate(Platform1, RoomMap[5, 4].transform);
                break;
            case 2:
                Instantiate(Platform2, RoomMap[5, 4].transform);
                break;
            case 3:
                Instantiate(Platform3, RoomMap[5, 4].transform);
                break;
            case 4:
                Instantiate(Platform4, RoomMap[5, 4].transform);
                break;
            case 5:
                Instantiate(Platform5, RoomMap[5, 4].transform);
                break;
            case 6:
                Instantiate(Platform6, RoomMap[5, 4].transform);
                break;
            
        }
    }

    void GenerateRoom(int x, int y, Room Caller)
    {

    }
}
