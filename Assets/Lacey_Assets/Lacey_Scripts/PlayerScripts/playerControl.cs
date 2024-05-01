using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 
using UnityEngine.UI; 
using System;

//PAUSED VIDEO AT 1:18:00

public class Player : Entity
{
    //die flag for sound control
    private musicManager music = new musicManager();
    private bool dead = false;
    //------ FOR OBSERVER PATTERN ------
    // Define a custom event delegate that includes event information
    public event Action<string,float> ThingHappened;
    // Method to trigger the event with specific information
    public void DoThing(string eventType, float num)
    {
        ThingHappened?.Invoke(eventType,num);
    }
    //----------------------------------


    //------ VARIABLES ------
    [SerializeField] private Transform groundCheck, headCheck;
    [SerializeField] private LayerMask groundLayer, brickLayer;
    // [SerializeField] private string endScene;
    [SerializeField] private Text coinText, speedText, jumpText;
    [SerializeField] private GameObject BCFace;
    [SerializeField] private HealthBar healthBar;
    [SerializeField] private GameObject endCanvas; 
    [SerializeField] private Text scoreText;
    private string finalScoreStr="Final Score:\n";

    private float maxHealth, curHealth;
    private int coins = 0;
    private bool BCMode=false;
    private bool isFacingRight=true;
       

    //------ START ------
    // protected override void Start(){
    void Awake(){
        base.Start();
        maxHealth=100;
        curHealth=maxHealth;
        coins=0;
        coinText.text = coins.ToString();
        speedText.text = this.speed.ToString();
        jumpText.text = this.jumpingPower.ToString();
        // DoThing("Coin",(float)coins);
        // DoThing("Speed",this.speed);
        // DoThing("Jump",this.jumpingPower);
        music.gameMusic();
        
    }
    //------ UPDATES ------
    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        
        if(Input.GetButtonDown("Jump") && isGround() && currentState!=jumpingState){
            currentState=jumpingState;
            currentState.EnterState(this);
            this.playerSounds.jumpSound();
        }
        flip();
        currentState.UpdateState(this);

        // for testing health bar
        if(Input.GetKeyDown(KeyCode.Return) && !dead)
        {
            
            Debug.Log("Taking damage");
            decreaseHealth(20);
        }
        if(Input.GetKeyDown(KeyCode.P)){
            this.playerSounds.attackSound();
        }
        if(Input.GetKeyDown(KeyCode.Tab))
        {
            Debug.Log("Healing");
            increaseHealth(10);
        }

    }
    private void FixedUpdate(){
        currentState.FixedUpdateState(this);
        if(horizontal != 0f){
            if(GameObject.FindWithTag("MoveSound") == null){
                this.playerSounds.moveSound();
            }
        }else{
            if(GameObject.FindWithTag("MoveSound") != null){
            GameObject.FindWithTag("MoveSound").GetComponent<AudioSource>().Stop();
            }
        }
    }

    //------ ANIMATIONS ------
    private void Die()
    {
        dead = true;
        // Destroy(gameObject);
        string displayTxt = finalScoreStr+coins.ToString()+this.jumpingPower.ToString()+this.speed.ToString();
        scoreText.text=displayTxt;

        endCanvas.SetActive(true);

        Debug.Log("You died.");
        
        // SceneManager.LoadScene(endScene);
    }
    private void flip(){
        if(isFacingRight&&horizontal<0f || !isFacingRight&&horizontal>0f){
            isFacingRight=!isFacingRight;
            Vector3 localScale=transform.localScale;
            localScale.x*=-1f;
            transform.localScale=localScale;
        }
    }

    //------ MOVING ------
    private void OnCollisionEnter2D(Collision2D collision){
        currentState.OnCollisionEnter(this);
    }
    private bool isGround(){
        return Physics2D.OverlapCircle(groundCheck.position,0.2f,groundLayer);
    }


    //------ PICKUPS/POWERUPS ------
    public void decreaseHealth(float damage){
        // make sure BC mode is off
        this.playerSounds.hurtSound();
        if(BCMode==false){
            curHealth-=damage;
            healthBar.UpdateHealthBar(maxHealth,curHealth);
            if(curHealth<=0){
                this.playerSounds.deathSound();
                Die();
            } 
        }
    }
    public void increaseHealth(float modifier){
        // make sure BC mode is off
        if(BCMode==false){
            // make sure we don't go over max
            if((curHealth+modifier)<=maxHealth) curHealth+=modifier;
            else if ( (curHealth<maxHealth) && (curHealth+modifier>maxHealth) ) curHealth=maxHealth;

            healthBar.UpdateHealthBar(maxHealth,curHealth); 
        }         
    }
    public void pickupCoins(int modifier){
        coins+=modifier;
        // Debug.Log(coins);
        // coinText.text = coins.ToString();
        DoThing("Coin",(float)coins);
    }
    public void increaseSpeed(float modifier){
        this.speed+=modifier;
        // speedText.text = this.speed.ToString();
        DoThing("Speed",this.speed);
    }
    public void increaseJumpingPower(float modifier){
        this.jumpingPower+=modifier;
        // jumpText.text = this.jumpingPower.ToString();
        DoThing("Jump",this.jumpingPower);
    }

    //------ MISC SETTERS ------
    public void BCModeON(){
        BCMode=true;
        BCFace.SetActive(true);
    }
    public void BCModeOFF(){
        BCMode=false;
        BCFace.SetActive(false);
    }

    //------ GETTERS ------
     public bool getBC(){
        return BCMode;
    }
    public float getCurrentHealth(){
        return curHealth;
    }
    public float getMaxHealth(){
        return maxHealth;
    }
    public bool isPlayerFacingRight(){
        return isFacingRight;
    }

}


// + ThingHappened: Action<string,float> 
// - groundCheck: Transform
// - headCheck: Transform
// - groundLayer: LayerMask
// - brickLayer: LayerMask
// - coinText: Text
// - speedText: Text
// - jumpText: Text 
// - BCFace: GameObject
// - healthBar: HealthBar 
// - endCanvas: GameObject
// - scoreText: Text
// - finalScoreStr: string
// - maxHealth: float
// - curHealth: float
// - coins: int
// - BCMode: bool
// - isFacingRight: bool
// - this.playerSounds: this.playerSounds
// - jumpingPower: int
// - speed: int


// + DoThing(): void 
// - Awake(): void
// - Update(): void
// - FixedUpdate(): void
// - Die(): void
// - flip(): void
// - OnCollisionEnter2D(): void
// - isGround(): bool
// - decreaseHealth(): void
// - increaseHealth(): void
// - pickupCoins(): void
// - increaseSpeed(): void
// - increaseJumpingPower(): void
// - BCModeON(): void
// - BCModeOFF(): void
// - getBC(): bool
// - getCurrentHealth(): float
// - getMaxHealth(): float
// - isPlayerFacingRight(): bool