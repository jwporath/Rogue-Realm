using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class enemyAttributes : MonoBehaviour
{
    //public class enemy {
        [SerializeField] int health;
        [SerializeField] int damage;
        [SerializeField] int armor;
        [SerializeField] int speed;
    // }
        void Start(){
            GameObject spawner = GameObject.Find("enemySpawner");
        }
        public void enemyInit(int hp, int dmg, int arm, int spd, int diff)
        {
            health = hp * diff;
            damage = dmg * diff;
            armor = arm * diff;
            speed = spd;
        }


        
    }


