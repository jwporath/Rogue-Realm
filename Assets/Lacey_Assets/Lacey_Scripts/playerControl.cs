using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private float horizontal;
    private bool isFacingRight=true;
    [SerializeField] private float speed;
    [SerializeField] private float jumpingPower;
    //was public:
    [SerializeField] private Rigidbody2D rBody;
    [SerializeField] private Transform groundCheck, headCheck;
    [SerializeField] private LayerMask groundLayer, brickLayer;

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        if(Input.GetButtonDown("Jump")&&isGround()){
            rBody.velocity=new Vector2(rBody.velocity.x, jumpingPower);
        }
        flip();
    }

    private void FixedUpdate(){
        rBody.velocity=new Vector2(horizontal*speed, rBody.velocity.y);
    }

    private bool isGround(){
        return Physics2D.OverlapCircle(groundCheck.position,0.2f,groundLayer);
    }

    private void flip(){
        if(isFacingRight&&horizontal<0f || !isFacingRight&&horizontal>0f){
            isFacingRight=!isFacingRight;
            Vector3 localScale=transform.localScale;
            localScale.x*=-1f;
            transform.localScale=localScale;
        }
    }

    private bool isCollidingWithBrick(){
        return Physics2D.OverlapCircle(headCheck.position, 0.2f, brickLayer);
    }
}
