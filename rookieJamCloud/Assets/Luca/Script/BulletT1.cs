using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletT1 : MonoBehaviour
{
    public float speed;
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = transform.right * speed;
        Destroy(gameObject, 5);
    }

    void OnTriggerEnter2D(Collider2D trucQuiMeToucheDeOuf){
        if (trucQuiMeToucheDeOuf.gameObject.tag == "Ground"){  
            Destroy(gameObject);    
        }
    }
}
