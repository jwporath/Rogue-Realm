using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level : MonoBehaviour
{
    [SerializeField] private GameObject RoomPrefab;
     
    // Start is called before the first frame update
    void Start()
    {
        GameObject Room = Instantiate(RoomPrefab, new Vector3(18, 0, 0), Quaternion.identity);
        LDoor LeftDoor1 = Room.GetComponentInChildren<LDoor>(true);
        LeftDoor1.gameObject.SetActive(true);
        Component[] LeftNoDoor1 = Room.GetComponentsInChildren<Component>();
        foreach(Component i in LeftNoDoor1)
        {
            if(i.name == "LeftNoDoor")
            {
                i.gameObject.SetActive(false);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
