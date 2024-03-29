using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//PAUSED VIDEO AT 1:18:00

public class Player : Entity
{
    private bool isFacingRight=true;

    [SerializeField] private Transform groundCheck, headCheck;
    [SerializeField] private LayerMask groundLayer, brickLayer;
    PlayerSounds playerSounds = new PlayerSounds();

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        if(Input.GetButtonDown("Jump") && isGround() && currentState!=jumpingState){
            currentState=jumpingState;
            currentState.EnterState(this);
            playerSounds.jumpSound();
        }
        flip();
        currentState.UpdateState(this);
    }

    private void FixedUpdate(){
        currentState.FixedUpdateState(this);
    }

    private bool isGround(){
        return Physics2D.OverlapCircle(groundCheck.position,0.2f,groundLayer);
    }

    // could use for power ups
    // private bool isCollidingWithPowerUp(){
    //     return Physics2D.OverlapCircle(headCheck.position,0.2f,brickLayer);
    // }

    private void flip(){
        if(isFacingRight&&horizontal<0f || !isFacingRight&&horizontal>0f){
            isFacingRight=!isFacingRight;
            Vector3 localScale=transform.localScale;
            localScale.x*=-1f;
            transform.localScale=localScale;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision){
        // Use this for picking up stuff:
        // if(collision.gameObject.tag=="PowerUp"&&isCollidingWithPowerUp()){
        //     PickUp(collision.gameObject);
        // }
        currentState.OnCollisionEnter(this);
    }
    public bool isPlayerFacingRight(){
        return isFacingRight;
    }

    // public int getSpeed(){
    //     return 
    // }
    // public void setSpeed(){
        
    // }
}
