using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicPlayer : MonoBehaviour
{
    private musicManager music = new musicManager();
    // Start is called before the first frame update
    void Start()
    {
        music.menuMusic();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
