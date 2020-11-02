using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed;
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = transform.right * speed;
    }

    void OnTriggerEnter2D(Collider2D trucQuiMeToucheDeOuf){
        if (trucQuiMeToucheDeOuf.gameObject.tag == "Ground"){  
            Destroy(gameObject);    
        }
    }
}
