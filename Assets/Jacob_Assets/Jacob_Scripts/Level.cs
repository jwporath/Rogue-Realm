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

    private int NumRooms;
     
    void Start()
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
        RoomMap[4, 4].SetX(4);
        RoomMap[4, 4].SetY(4);

        NumRooms = 1;

        StartGeneration();

        Debug.Log(NumRooms);
    }

    void StartGeneration()
    {
        RoomMap[4, 4].EnableRightDoor();
        Debug.Log("Called right function");
        GenerateRoom(5, 4, RoomMap[4, 4]); // generate right path
        if(RoomMap[3, 4] == null) // generate left path
        {
            RoomMap[4, 4].EnableLeftDoor();
            Debug.Log("Called left function");
            GenerateRoom(3, 4, RoomMap[4, 4]);
        }        
        if(RoomMap[4, 3] == null) // generate top path
        {
            RoomMap[4, 4].EnableTopDoor();
            Debug.Log("Called top function");
            GenerateRoom(4, 3, RoomMap[4, 4]);
        }    
        if(RoomMap[4, 5] == null) // generate bottom path
        {
            RoomMap[4, 4].EnableBottomDoor();
            Debug.Log("Called bottom function");
            GenerateRoom(4, 5, RoomMap[4, 4]);
        }    
    }

    void GenerateRoom(int x, int y, Room Caller)
    {
        // Create room
        GameObject room = Instantiate(RoomPrefab, Caller.transform.position, Quaternion.identity, this.gameObject.transform);
        room.transform.gameObject.tag = "New";

        // Add Room to RoomMap
        Room[] arr = this.GetComponentsInChildren<Room>();
        foreach (Room i in arr)
        {
            if (i.tag == "New")
            {
                RoomMap[x, y] = i;
                RoomMap[x, y].gameObject.transform.tag = "Untagged";
                RoomMap[x, y].SetX(x);
                RoomMap[x, y].SetY(y);
                NumRooms++;
            }
        }

        // Move to correct position
        Vector3 vector;
        if (x > Caller.GetX()) // Move new room to Right
        {
            vector = Caller.transform.position;
            vector.x += 20;
            RoomMap[x, y].transform.position = vector;
            RoomMap[x, y].EnableLeftDoor();
        }
        else if (y > Caller.GetY()) // Move new room to Bottom
        {
            vector = Caller.transform.position;
            vector.y -= 12;
            RoomMap[x, y].transform.position = vector;
            RoomMap[x, y].EnableTopDoor();
        }
        else if (x < Caller.GetX()) // Move new room to Left
        {
            vector = Caller.transform.position;
            vector.x -= 20;
            RoomMap[x, y].transform.position = vector;
            RoomMap[x, y].EnableRightDoor();
        }
        else // Move new room to Top
        {
            vector = Caller.transform.position;
            vector.y += 12;
            RoomMap[x, y].transform.position = vector;
            RoomMap[x, y].EnableBottomDoor();
        }

        // Create platforms
        int random = UnityEngine.Random.Range(1, 7);
        switch(random)
        {
            case 1:
                Instantiate(Platform1, RoomMap[x, y].transform);
                break;
            case 2:
                Instantiate(Platform2, RoomMap[x, y].transform);
                break;
            case 3:
                Instantiate(Platform3, RoomMap[x, y].transform);
                break;
            case 4:
                Instantiate(Platform4, RoomMap[x, y].transform);
                break;
            case 5:
                Instantiate(Platform5, RoomMap[x, y].transform);
                break;
            case 6:
                Instantiate(Platform6, RoomMap[x, y].transform);
                break;
            
        }

        // Recursive generation calls
        int Left = UnityEngine.Random.Range(1, 4);
        int Right = UnityEngine.Random.Range(1, 4);
        int Top = UnityEngine.Random.Range(1, 4);
        int Bottom = UnityEngine.Random.Range(1, 4);

        if (Left == 1 && x > 0) // Left
        {
            if (RoomMap[x - 1, y] == null)
            {
                RoomMap[x, y].EnableLeftDoor();
                GenerateRoom(RoomMap[x, y].GetX() - 1, RoomMap[x, y].GetY(), RoomMap[x, y]);
            }
            else
            {
                int connect = UnityEngine.Random.Range(1, 3);
                if (connect == 1)
                {
                    RoomMap[x, y].EnableLeftDoor();
                    RoomMap[x - 1, y].EnableRightDoor();
                }
            }
        }
        if (Right == 1 && x < 8) // Right
        {
            if (RoomMap[x + 1, y] == null)
            {
                RoomMap[x, y].EnableRightDoor();
                GenerateRoom(RoomMap[x, y].GetX() + 1, RoomMap[x, y].GetY(), RoomMap[x, y]);
            }
            else
            {
                int connect = UnityEngine.Random.Range(1, 3);
                if (connect == 1)
                {
                    RoomMap[x, y].EnableRightDoor();
                    RoomMap[x + 1, y].EnableLeftDoor();
                }
            }
        }
        if (Top == 1 && y > 0) // Top
        {
            if (RoomMap[x, y - 1] == null)
            {
                RoomMap[x, y].EnableTopDoor();
                GenerateRoom(RoomMap[x, y].GetX(), RoomMap[x, y].GetY() - 1, RoomMap[x, y]);
            }
            else
            {
                int connect = UnityEngine.Random.Range(1, 3);
                if (connect == 1)
                {
                    RoomMap[x, y].EnableTopDoor();
                    RoomMap[x, y - 1].EnableBottomDoor();
                }
            }
        }
        if (Bottom == 1 && y < 8) // Bottom
        {
            if (RoomMap[x, y + 1] == null)
            {
                RoomMap[x, y].EnableBottomDoor();
                GenerateRoom(RoomMap[x, y].GetX(), RoomMap[x, y].GetY() + 1, RoomMap[x, y]);
            }
            else
            {
                int connect = UnityEngine.Random.Range(1, 3);
                if (connect == 1)
                {
                    RoomMap[x, y].EnableBottomDoor();
                    RoomMap[x, y + 1].EnableTopDoor();
                }
            }
        }
    }

    private void GenerateBossRoom()
    {
        
    }

    public Room GetRoom(int x, int y)
    {
        if(x < 9 && x >= 0 && y < 9 && y >= 0)
            return RoomMap[x, y];
        else
            return null;
    }
}
