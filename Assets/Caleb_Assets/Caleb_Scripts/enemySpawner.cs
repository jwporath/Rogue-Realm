using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemySpawner : MonoBehaviour
{
    [SerializeField] private GameObject enemyPrefab;
    // Start is called before the first frame update
    void Start()
    {
        createEnemy(1,false, this.gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void createEnemy(int difficulty, bool boss, GameObject parent)
        {
            int rand = 1; //UnityEngine.Random.Range(1,13);
            if(boss == false){
                switch(rand){
                    case 1:
                        Instantiate(enemyPrefab, new UnityEngine.Vector3(0, 0, 0), UnityEngine.Quaternion.identity, parent.transform);
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                    case 5:
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
