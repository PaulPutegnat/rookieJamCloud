using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnclumeT1 : MonoBehaviour
{
    private Rigidbody2D rb;

    public Vector3 limit;

    public float speedH;
    public float speedV;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        limit.y = GameObject.Find("EnclumeTrans").GetComponent<Transform>().transform.position.y;
        StartCoroutine("Patern");
    }

    void Update()
    {
        rb.velocity = new Vector2(speedH, speedV);

        if(transform.position.y < limit.y + 1){
            speedH = 0;
            speedV = 0;
        }
    }

    IEnumerator Patern(){
        speedH = 5;
        speedV = 5;
        yield return new WaitForSeconds(0.3f);
        speedH = 0;
        speedV = 0;
        yield return new WaitForSeconds(0.3f);
        speedV = -15;
    }
}
