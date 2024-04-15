// LDoor.cs - defines Left door object
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LDoor : MonoBehaviour
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

        if (Input.GetKeyDown("e") && XDif < 1.5 && YDif < 2 && !parentRoom.isLocked())
        {
            // move player and camera to appropriate x, y position
            Vector3 pos = new Vector3(player.transform.position.x - 5f, player.transform.position.y, player.transform.position.z);
            player.transform.position = pos;

            pos = new Vector3(gameCam.transform.position.x - 20f, gameCam.transform.position.y, gameCam.transform.position.z);
            gameCam.transform.position = pos;
        }
    }

    // void OnCollisionEnter2D(Collision2D collision)
    // {
    //     if(collision.gameObject.tag == "Player")
    //     {
    //         Vector3 pos = new Vector3(player.transform.position.x - 5f, player.transform.position.y, player.transform.position.z);
    //         player.transform.position = pos;

    //         pos = new Vector3(gameCam.transform.position.x - 20f, gameCam.transform.position.y, gameCam.transform.position.z);
    //         gameCam.transform.position = pos;
    //     }
    // }
}
