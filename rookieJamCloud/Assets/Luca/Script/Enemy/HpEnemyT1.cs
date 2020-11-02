using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HpEnemyT1 : MonoBehaviour
{
    public int maxHp;
    public int currentHP;

    public bool mother;

    void Start()
    {
        currentHP = maxHp;
    }

    void Update()
    {
        if(currentHP <= 0){
            GameObject.Find("EnemyList").GetComponent<EnemyListT1>().numberOfEnnemies -= 1;

            if(mother){
                /// creer litem en haut chercher litem fils et desoactive ca valeur 
            }
            
            Destroy(gameObject);
        }
    }

    public void takeDamage(int damage){
        currentHP -= damage;
    }
}
