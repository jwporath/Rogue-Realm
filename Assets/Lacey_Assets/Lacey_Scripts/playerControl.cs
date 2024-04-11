using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

//PAUSED VIDEO AT 1:18:00

public class Player : Entity
{
    private bool isFacingRight=true;

    [SerializeField] private Transform groundCheck, headCheck;
    [SerializeField] private LayerMask groundLayer, brickLayer;
    [SerializeField] private string endScene;
    PlayerSounds playerSounds = new PlayerSounds();
    private float maxHealth, curHealth;
    private int coins;

    // private HealthBar healthBar;
    // private GameObject healthBar;
    [SerializeField] private HealthBar healthBar;

    protected override void Start(){
        base.Start();
        maxHealth=100;
        curHealth=maxHealth;
        coins=0;
        // healthBar=GetComponentInChildren<HealthBar>();
        // healthBar=GameObject.FindGameObjectWithTag("HealthBarCanvas");
        Debug.Log(healthBar);
    }

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

        //TESTING HEALTH BAR
        if(Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("Taking damage");
            decreaseHealth(20);
        }
        if(Input.GetKeyDown(KeyCode.Tab))
        {
            Debug.Log("Healing");
            increaseHealth(10);
        }

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

            // healthBar.GetComponentInParent<Canvas>();
            // GameObject gameOb;
            // GameObject hbCanvas=GameObject.FindGameObjectWithTag("HealthBarCanvas");
            // Canvas hbCanvas=this.GetComponentInChildren<Canvas>();
            // // Canvas hbCanvas2=hbCanvas.GetComponentInChildren<Canvas>();

            // // Vector3 hbScale=hbCanvas2.transform.localScale;
            // // hbScale.x*=-1f;
            // Vector3 hbScale=localScale;
            // hbCanvas.transform.localScale=hbScale;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision){
        // Use this for picking up stuff:
        // if(collision.gameObject.tag=="Coin"&&isCollidingWithPowerUp()){
        //     PickUp(collision.gameObject);
        // }
        currentState.OnCollisionEnter(this);
    }
    public bool isPlayerFacingRight(){
        return isFacingRight;
    }
    public void decreaseHealth(float damage){
        curHealth-=damage;
        healthBar.UpdateHealthBar(maxHealth,curHealth);
        if(curHealth<=0) Die();
    }
    public void increaseHealth(float modifier){
        // make sure we don't go over max
        if((curHealth+modifier)<=maxHealth) curHealth+=modifier;
        else if ( (curHealth<maxHealth) && (curHealth+modifier>maxHealth) ) curHealth=maxHealth;

        healthBar.UpdateHealthBar(maxHealth,curHealth);  
    }
    public float getCurrentHealth(){
        return curHealth;
    }
    public float getMaxHealth(){
        return maxHealth;
    }

    public void pickupCoins(int modifier){
        coins+=modifier;
    }
    public int getNumCoins(){
        return coins;
    }

    private void Die()
    {
        // Destroy(gameObject);
        Debug.Log("You died.");
        SceneManager.LoadScene(endScene);
    }
}
