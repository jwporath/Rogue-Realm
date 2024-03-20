using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TDoor : MonoBehaviour
{
    
    private GameObject player;
    private GameObject gameCam;
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        gameCam = GameObject.FindGameObjectWithTag("MainCamera");
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            Vector3 pos = new Vector3(player.transform.position.x, player.transform.position.y + 4f, player.transform.position.z);
            player.transform.position = pos;

            pos = new Vector3(gameCam.transform.position.x, gameCam.transform.position.y + 10f, gameCam.transform.position.z);
            gameCam.transform.position = pos;
        }
    }
}
