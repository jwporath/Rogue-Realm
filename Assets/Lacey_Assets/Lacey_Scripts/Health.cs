using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    private int maxHealth;
    private int currentHealth;
    public HealthBar healthBar;
    public Entity entity; // Reference to the Entity script
    [SerializeField] private string gameOverScene;

    void Start()
    {
        GameObject playerObj = GameObject.Find("Player");
        // Get the Player component attached to the player object
        Player player = playerObj.GetComponent<Player>();
        maxHealth = player.getMaxHealth();
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }

    void Update()
    {
        // You can handle other player input or events here if needed
    }

    // Call this function to apply damage and handle collisions with obstacles
    public void HandleCollisions(Collision2D collision)
    {
        // // CALEB THIS IS A SAMPLE FOR YOU, USE IT IF YOU WANT... see K's video starting at around 18:00
        if (collision.transform.tag == "EnemySkeleton")
        {   
            TakeDamage(10);
            Debug.Log("Taking damage!");
        }
        // if (collision.transform.tag == "Gremlin")
        // {   
        //     GameObject playerObj = GameObject.Find("Gremlin");
        //     Player enemy = enemyObj.GetComponent<Gremlin>();
        //     int damage=enemy.getDamage();   //getDamage should return an int which is the level of damage it does to player
        //     TakeDamage(damage);
        //     Destroy(collision.gameObject); // Destroy the enemy
        //     // Add any other logic you need, like pausing or handling the jump over the obstacle
        // }
        // // add more if's for all the enemies....
        // if (collision.transform.tag == "FinalBoss")
        // {
        //     //Destroy(collision.gameObject); 
        //     //Access the EntityBoss script to change the state to deadState
        //     // not sure how you will do this Caleb, this is assuming you animate the boss the same way K does in her video
        //     Entity boss = collision.gameObject.GetComponent<Entity>();
        //     if (boss != null)
        //     {
        //         boss.currentState = boss.deadState;
        //     }

        //     // Additional logic if needed, e.g., play death animation, disable controls, etc.
        //     Animator animator = collision.gameObject.GetComponent<Animator>();
        //     if (animator != null)
        //     {
        //         animator.runtimeAnimatorController = boss.MushrioDead as RuntimeAnimatorController;
        //     }

                
        //     // Wait for 2.5 seconds before loading the "EndMenu" scene
                // this will be different for us, since the game doesn't end when the boss dies... it will instead load the new level so Jacob and Caleb can figure out that here
        //     StartCoroutine(LoadGameOverSceneAfterDelay(2.5f));
        // }
    }

    void TakeDamage(int damage)
    {
        GameObject playerObj = GameObject.Find("Player");
        // Get the Player component attached to the player object
        Player player = playerObj.GetComponent<Player>();
        
        if (currentHealth < 20)
        {
            currentHealth = 0;
            healthBar.SetHealth(currentHealth);

            // Access the Entity script to change the state to deadState
            Entity entity = GetComponent<Entity>();
            if (entity != null)
            {
                entity.currentState = entity.deadState;
            }

            // Additional logic if needed, e.g., play death animation, disable controls, etc.
            Animator animator = GetComponent<Animator>();
            if (animator != null)
            {
                // animator.runtimeAnimatorController = entity.MushrioDead as RuntimeAnimatorController;
            }

            // Wait for 5 seconds before loading the game over scene
            StartCoroutine(LoadGameOverSceneAfterDelay(2.5f));
        }
        else
        {
            // currentHealth -= damage;
            int modifier=damage*-1;
            player.modifyHealth(modifier);
            currentHealth=player.getCurrentHealth();
            healthBar.SetHealth(currentHealth);
            Debug.Log("Health Bar Change");
        }
    }

    private IEnumerator LoadGameOverSceneAfterDelay(float delay)
        {
            yield return new WaitForSeconds(delay);

            // Load the game over scene
            SceneManager.LoadScene(gameOverScene); 
        }
}
