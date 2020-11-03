using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HpEnemyT1 : MonoBehaviour
{
    public int maxHp;
    public int currentHP;

    public bool mother;
    public GameObject son;

    void Start()
    {
        currentHP = maxHp;
    }

    void Update()
    {
        if(currentHP <= 0){
            GameObject.Find("EnemyList").GetComponent<EnemyListT1>().numberOfEnnemies -= 1;

            if(mother){
                son.GetComponent<FollowT1>().enabled = false;
                son.GetComponent<EnemyMoveT1>().enabled = true;
            }
            
            Destroy(gameObject);
        }
    }

    public void takeDamage(int damage){
        currentHP -= damage;
        StartCoroutine("InvulFrame");
    }


    IEnumerator InvulFrame(){
        GetComponent<SpriteRenderer>().color = Color.red;
        yield return new WaitForSeconds(0.2f);
        GetComponent<SpriteRenderer>().color = Color.white;
    }
}
