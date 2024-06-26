// BDoor.cs - defines Bottom door object
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bdoor : MonoBehaviour
{
    
    private GameObject player;
    private GameObject gameCam;
    private Room parentRoom;
    // On first frame, find player, find camera, find parent room object.
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        gameCam = GameObject.FindGameObjectWithTag("MainCamera");
        parentRoom = this.GetComponentInParent<Room>();
    }

    // Check if player is in range, doors are unlocked, and player tries to use a door.
    void Update()
    {
        double XDif = Mathf.Abs(this.transform.position.x - player.transform.position.x);
        double YDif = Mathf.Abs(this.transform.position.y - player.transform.position.y);

        if (Input.GetKeyDown("e") && XDif < 1.5 && YDif < 1 && !parentRoom.isLocked())
        {
            // move player and camera to appropriate x, y position
            Vector3 pos = new Vector3(player.transform.position.x, player.transform.position.y - 5.5f, player.transform.position.z);
            player.transform.position = pos;

            pos = new Vector3(gameCam.transform.position.x, gameCam.transform.position.y - 12f, gameCam.transform.position.z);
            gameCam.transform.position = pos;
        }
    }

    // void OnCollisionEnter2D(Collision2D collision)
    // {
    //     if(collision.gameObject.tag == "Player")
    //     {
    //         Vector3 pos = new Vector3(player.transform.position.x, player.transform.position.y - 5.5f, player.transform.position.z);
    //         player.transform.position = pos;

    //         pos = new Vector3(gameCam.transform.position.x, gameCam.transform.position.y - 12f, gameCam.transform.position.z);
    //         gameCam.transform.position = pos;
    //     }
    // }
}
