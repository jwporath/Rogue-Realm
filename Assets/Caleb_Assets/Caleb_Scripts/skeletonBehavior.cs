using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class skeletonBehavior : MonoBehaviour
{
    GameObject Player;
    [SerializeField] float enemySpeed = 2f;
    [SerializeField] float enemyAggression = 5.5f;
    Rigidbody2D rb;
    Transform playerTarget;
    Vector2 moveDirection;
    float distance;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Start()
    {
        playerTarget = GameObject.Find("Player").transform; 
    }
    private void Update()
    {
        if(playerTarget && distance < 5.5)
        {
            Vector3 direction = (playerTarget.position - transform.position).normalized;
            float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
            rb.rotation = angle;
            moveDirection = direction;
        }
        distance = Vector3.Distance (playerTarget.transform.position, rb.transform.position);
    }

    
    private void FixedUpdate()
    {
        if(playerTarget && distance < enemyAggression)
        {
            rb.velocity = new Vector2(moveDirection.x, moveDirection.y) * enemySpeed;
        }
        else
        {
            rb.velocity = new Vector2(moveDirection.x, moveDirection.y) * 0f;
        }
    }
}
