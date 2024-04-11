using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossDoor : MonoBehaviour
{
    private GameObject player;
    private GameObject gameCam;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        gameCam = GameObject.FindGameObjectWithTag("MainCamera");
    }

    // Update is called once per frame
    void Update()
    {
        double XDif = Mathf.Abs(this.transform.position.x - player.transform.position.x);
        double YDif = Mathf.Abs(this.transform.position.y - player.transform.position.y);

        if (Input.GetKeyDown("e") && XDif < 1.5 && YDif < 1) // player enters door
        {
            Vector3 pos = new Vector3(player.transform.position.x, player.transform.position.y + 5f, player.transform.position.z);
            player.transform.position = pos;

            pos = new Vector3(gameCam.transform.position.x, gameCam.transform.position.y + 12f, gameCam.transform.position.z);
            gameCam.transform.position = pos;
        }
    }
}
