using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlScript : MonoBehaviour
{
    public SoundManager soundManager;
    // Start is called before the first frame update
    void Start()
    {
       GameObject soundManagerObject = GameObject.Find("SndManager");

        // Check if the object is found and get the SoundManager component
        if (soundManagerObject != null)
        {
            soundManager = soundManagerObject.GetComponent<SoundManager>();
        }
        else
        {
            Debug.LogError("SoundManager GameObject not found.");
        } 
    }

    // Update is called once per frame
void FixedUpdate()
    {
        if(Input.GetKey(KeyCode.Space)){
            soundManager.testSound();
        }
    }
}
