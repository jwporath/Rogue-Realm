using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RDoor : MonoBehaviour
{
    private GameObject player;
    private GameObject gameCam;
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        gameCam = GameObject.FindGameObjectWithTag("MainCamera");
    }
    
    void Update()
    {
        double XDif = Mathf.Abs(this.transform.position.x - player.transform.position.x);
        double YDif = Mathf.Abs(this.transform.position.y - player.transform.position.y);

        if (Input.GetKeyDown("e") && XDif < 1.5 && YDif < 2)
        {
            Vector3 pos = new Vector3(player.transform.position.x + 5f, player.transform.position.y, player.transform.position.z);
            player.transform.position = pos;

            pos = new Vector3(gameCam.transform.position.x + 20f, gameCam.transform.position.y, gameCam.transform.position.z);
            gameCam.transform.position = pos;
        }
    }

    // void OnCollisionEnter2D(Collision2D collision)
    // {
    //     if(collision.gameObject.tag == "Player")
    //     {
    //         Vector3 pos = new Vector3(player.transform.position.x + 5f, player.transform.position.y, player.transform.position.z);
    //         player.transform.position = pos;

    //         pos = new Vector3(gameCam.transform.position.x + 20f, gameCam.transform.position.y, gameCam.transform.position.z);
    //         gameCam.transform.position = pos;
    //     }
    // }
}
