using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemySpawner : MonoBehaviour
{
    [SerializeField] private GameObject skeletonWarrior;
    [SerializeField] private GameObject necromancer;
    [SerializeField] private GameObject skeletonFodder;
    [SerializeField] private GameObject ghost;
    [SerializeField] private GameObject pinkSlime;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void createEnemy(int difficulty, bool boss, GameObject parent)
        {
            int rand = UnityEngine.Random.Range(1,6);
            if(boss == false){
                switch(rand){
                    case 1:
                        //Enemy Skeleton
                        Instantiate(skeletonWarrior, parent.transform.position, UnityEngine.Quaternion.identity, parent.transform);
                        break;
                    case 2:
                        Instantiate(necromancer, parent.transform.position, UnityEngine.Quaternion.identity, parent.transform);
                        break;
                    case 3:
                        Instantiate(skeletonFodder, parent.transform.position, UnityEngine.Quaternion.identity, parent.transform);
                        break;
                    case 4:
                        Instantiate(ghost, parent.transform.position, UnityEngine.Quaternion.identity, parent.transform);
                        break;
                    case 5:
                        Instantiate(pinkSlime, parent.transform.position, UnityEngine.Quaternion.identity, parent.transform);
                        break;
                    case 6:
                        break;
                    case 7:
                        break;
                    case 8:
                        break;
                    case 9:
                        break;
                    case 10:
                        break;
                    case 11:
                        break;
                    case 12:
                        break;
                }
            }
            else{
                switch(rand%3){
                    case 1:
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                }
            }
            

        }
}
