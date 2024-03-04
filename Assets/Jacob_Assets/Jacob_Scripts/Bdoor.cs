using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bdoor : MonoBehaviour
{
    [SerializeField] private GameObject player;
    [SerializeField] private GameObject gameCam;

    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            Vector3 pos = new Vector3(player.transform.position.x, player.transform.position.y - 3.5f, player.transform.position.z);
            player.transform.position = pos;

            pos = new Vector3(gameCam.transform.position.x, gameCam.transform.position.y - 10f, gameCam.transform.position.z);
            gameCam.transform.position = pos;
        }
    }
}
