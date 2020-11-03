using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHPT1 : MonoBehaviour
{
    public int maxHp;
    public int currentHP;

    public bool isInvulneary;
    void Start()
    {
        currentHP = maxHp;
    }

    void Update()
    {
        if(isInvulneary){
            var player = GameObject.Find("Player").GetComponent<SpriteRenderer>();
            player.color = Color.Lerp(Color.white, Color.red, Mathf.PingPong(Time.time * 8, 0.5f));
        }else{
            var player = GameObject.Find("Player").GetComponent<SpriteRenderer>();
            player.color = Color.white;
        }
    }

    public void takeDamage(int damage){
        var enmyList = GameObject.Find("EnemyList").GetComponent<EnemyListT1>();
        if(isInvulneary || currentHP <= 0 || enmyList.numberOfEnnemies == 0){
            
        }else{
            currentHP -= damage;
            StartCoroutine("InvulFrame");
        }
    }

    IEnumerator InvulFrame(){
        isInvulneary = true;
        yield return new WaitForSeconds(1f);
        isInvulneary = false;
    }
}
