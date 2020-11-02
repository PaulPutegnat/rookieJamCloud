using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletT1 : MonoBehaviour
{
    public float speed;
    private Rigidbody2D rb;
    public int damage;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = transform.right * speed;
        Destroy(gameObject, 5);
    }

    void OnTriggerEnter2D(Collider2D col){
        if(gameObject.tag == "Damage"){
            if (col.gameObject.tag == "Player"){  
            col.GetComponent<PlayerHPT1>().takeDamage(damage);
            Destroy(gameObject);
        }
        }

        if(gameObject.tag == "PlayerBullet"){
            if (col.gameObject.tag == "Enemy"){  
            col.GetComponent<HpEnemyT1>().takeDamage(damage);
            Destroy(gameObject);
        }
        }
    }
}
