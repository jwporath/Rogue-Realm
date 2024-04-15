// BossDoor.cs - Defines BossDoor Object
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BossDoor : MonoBehaviour
{
    private GameObject player;
    private GameObject gameCam;

    // find player and camera Objects
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
            // // temporarily reloads scene
            // string currentSceneName = SceneManager.GetActiveScene().name;
            // SceneManager.LoadScene(currentSceneName);

            Level l = FindAnyObjectByType<Level>();
            l.ClearLevel();
            l.LoadLevel();
        }
    }
}
