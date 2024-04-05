using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyClass : MonoBehaviour
{
    public class enemy {
        public int health;
        public int damage;
        public int armor;
        public int speed;
        public bool isBoss;
    }
        public void enemyInit(enemy badGuy, int hp, int dmg, int arm, int spd, bool boss, int diff)
        {
            badGuy.health = hp * diff;
            badGuy.damage = dmg * diff;
            badGuy.armor = arm * diff;
            badGuy.speed = spd;
            badGuy.isBoss = boss;
        }

        public void createEnemy(int difficulty, bool boss, GameObject parent)
        {
            int rand = UnityEngine.Random.Range(1,13);
            if(rand == 1 && boss == false){

            }
            if(rand == 2 && boss == false){

            }
            if(rand == 3 && boss == false){

            }
            if(rand == 4 && boss == false){

            }
            if(rand == 5 && boss == false){

            }
            if(rand == 6 && boss == false){

            }
            if(rand == 7 && boss == false){

            }
            if(rand == 8 && boss == false){

            }
            if(rand == 9 && boss == false){

            }
            if(rand == 10 && boss == false){

            }
            if(rand == 11 && boss == false){

            }
            if(rand == 12 && boss == false){
                
            }
            

        }
    }


