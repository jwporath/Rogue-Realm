using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyBehavior : enemyAttributes
{
    GameObject Player;
    //new EnemySounds enemySounds = new EnemySounds();
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
        if(this.health <= 0)
        {
            dead = true;
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
        //enemySounds.deathSound();
        return dead;
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.tag == "Weapon")
        {
            Sword1 sword = col.gameObject.GetComponent<Sword1>();
            float damageTaken = sword.weaponDamage;
             this.health -= (int)damageTaken;
             Debug.Log("Enemy health reduced by "+damageTaken);
         }
        // if(col.gameObject.tag == "Player")
        // {
        //     Debug.Log("Player Collision");
        //     this.health -= 100;
        // }
    }

    public virtual void forSakeOfBinding()
    {
        Debug.Log("Enemy Spawned");
    }

}
