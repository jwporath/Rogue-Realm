using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.ExceptionServices;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class FireBall : MonoBehaviour
{
    private GameObject fireballObject;
    public float speed = 1f;
    Vector3 velocity;

    public bool right;
    public bool left;
    public bool up;
    public bool down;

    private GameObject[] getCount;

    private void Start()
    {
        // GameObject fireballObjectCopy =  new GameObject();
        // FireBall f = fireballObjectCopy.AddComponent<FireBall>();
        // fireballObjectCopy.transform.position = new Vector3(1, 1, 0);
        Instantiate(gameObject);

        getCount = GameObject.FindGameObjectsWithTag("FireBall");
        int count = getCount.Length;

        Debug.Log(count);
        
    }

    private void Update()
    {
        //GameObject fireballObjectCopy = Instantiate<GameObject>(fireballObject);
        UpdateVelocity();
        transform.position += velocity * Time.deltaTime;
        // if(GameObject.FindGameObjectsWithTag("FireBall");
        // {

        // }
    }

    // private void CountBalls()
    // {
    //     getCount = new Array();
    //     getCount = GameObject.FindGameObjectsWithTag ("FireBall");
	// 	count = getCount.length;
    // }
    
    void UpdateVelocity()
    {
        if(right && up)
        {
            velocity = new Vector3(1f, 1f, 0) * speed;
        }
        else if(right && down)
        {
            velocity = new Vector3(1f, -1f, 0) * speed;
        }
        else if(left && up)
        {
            velocity = new Vector3(-1f, 1f, 0) * speed;
        }
        else if(left && down)
        {
            velocity = new Vector3(-1f, -1f, 0) * speed;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        string side = collision.transform.name;

        if(side == "Ceiling" && up)
        {
            up = false;
            down = true;
        }
        else if(side == "Floor" && down)
        {
            down = false;
            up = true;
        }
        else if(side == "RightWall" && right)
        {
            right = false;
            left = true;
        }
        else if(side == "LeftWall" && left)
        {
            left = false;
            right = true;
        }
        else if(side == "Platform1" && up)
        {
            up = false;
            down = true;
        }
        else if(side == "Platform1" && down)
        {
            down = false;
            up = true;
        }
        else if(side == "Platform1" && right)
        {
            right = false;
            left = true;
        }
        else if(side == "Platform1" && left)
        {
            left = false;
            right = true;
        }
        else if(side == "Platform2" && up)
        {
            up = false;
            down = true;
        }
        else if(side == "Platform2" && down)
        {
            down = false;
            up = true;
        }
        else if(side == "Platform2" && right)
        {
            right = false;
            left = true;
        }
        else if(side == "Platform2" && left)
        {
            left = false;
            right = true;
        }
        else if(side == "Platform3" && up)
        {
            up = false;
            down = true;
        }
        else if(side == "Platform3" && down)
        {
            down = false;
            up = true;
        }
        else if(side == "Platform3" && right)
        {
            right = false;
            left = true;
        }
        else if(side == "Platform3" && left)
        {
            left = false;
            right = true;
        }
        
    }
}
