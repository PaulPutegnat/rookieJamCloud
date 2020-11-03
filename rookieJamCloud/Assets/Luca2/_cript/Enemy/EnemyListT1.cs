using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyListT1 : MonoBehaviour
{
    public int numberOfEnnemies;
    public bool OneTime;
    void Start()
    {
        foreach (var enemy in GameObject.FindGameObjectsWithTag("Enemy"))
         {
             numberOfEnnemies += 1;
         }
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
     }
}
