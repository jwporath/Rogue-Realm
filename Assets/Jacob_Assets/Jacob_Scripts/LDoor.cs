using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LDoor : MonoBehaviour
{
    [SerializeField] private GameObject player;
    [SerializeField] private GameObject gameCam;

    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            Vector3 pos = new Vector3(player.transform.position.x - 3f, player.transform.position.y, player.transform.position.z);
            player.transform.position = pos;

            pos = new Vector3(gameCam.transform.position.x - 18f, gameCam.transform.position.y, gameCam.transform.position.z);
            gameCam.transform.position = pos;
        }
    }
}
