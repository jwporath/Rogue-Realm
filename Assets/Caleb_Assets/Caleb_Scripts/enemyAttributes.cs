using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class enemyAttributes : MonoBehaviour
{
    //public class enemy {
        public int health;
        public int damage;
        public int armor;
        public int speed;
        public bool isBoss;
    // }
        void Start(){
            GameObject spawner = GameObject.Find("enemySpawner");
        }
        public void enemyInit(int hp, int dmg, int arm, int spd, bool boss, int diff)
        {
            health = hp * diff;
            damage = dmg * diff;
            armor = arm * diff;
            speed = spd;
            isBoss = boss;
        }


        
    }


