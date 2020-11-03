using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyListT1 : MonoBehaviour
{
    public int numberOfEnnemies;
    public bool OneTime;
    public int number;
    void Start()
    {
        checkEnemy();
    }

    void Update()
    {
        if(numberOfEnnemies == 0 && OneTime == false){
            StartCoroutine("EndOfBattle");
        }
    }

    IEnumerator EndOfBattle(){
        OneTime = true;
        yield return new WaitForSeconds(0.2f);
        Debug.Log("GG t un bg");
        if(number == 1){
            GameObject.Find("WinTP").GetComponent<WinBetweenSceneT1>().winner();
            number+=1;
        }
     }

     void checkEnemy(){
         foreach (var enemy in GameObject.FindGameObjectsWithTag("Enemy"))
         {
             numberOfEnnemies += 1;
         }
     }
}
