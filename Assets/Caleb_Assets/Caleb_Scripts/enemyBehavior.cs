using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyBehavior : MonoBehaviour
{
    GameObject Player;
    [SerializeField] float enemySpeed = 2f;
    [SerializeField] float enemyAggression = 5.5f;
    Rigidbody2D rb;
    Transform playerTarget;
    Vector2 moveDirection;
    float distance;
    private bool dead;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        dead = false;
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
            moveDirection = direction;
        }
        distance = Vector3.Distance (playerTarget.transform.position, rb.transform.position);
        
        if(playerTarget.transform.position.x < this.gameObject.transform.position.x && this.gameObject.transform.localScale.x > 0)
        {
            Vector3 localScale=transform.localScale;
            localScale.x*=-1f;
            transform.localScale=localScale;
        }
        else if(playerTarget.transform.position.x > this.gameObject.transform.position.x && this.gameObject.transform.localScale.x < 0)
        {
            Vector3 localScale=transform.localScale;
            localScale.x*=-1f;
            transform.localScale=localScale;
        }
        if(dead)
        {
            this.gameObject.SetActive(false);
        }

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

    public bool isDead()
    {
        return dead;
    }

    void onCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject.tag == "Player")
        {
            dead = true;
        }
    }

}
