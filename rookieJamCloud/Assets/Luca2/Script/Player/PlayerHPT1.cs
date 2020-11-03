using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHPT1 : MonoBehaviour
{
    public int maxHp;
    public int currentHP;
    void Start()
    {
        currentHP = maxHp;
    }

    void Update()
    {
        
    }

    public void takeDamage(int damage){
        currentHP -= damage;
    }
}
