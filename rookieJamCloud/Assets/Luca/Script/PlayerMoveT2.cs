using System.Collections;//Equipe Nuage
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoveT2 : MonoBehaviour
{
    private Rigidbody2D rb;
    public float speedH;
    public float speedV;
    private float speedHBase;
    private float speedVBase;

    public Transform firePoint;
    public GameObject bullet;

    private float timeBtwAttack;
    public float startTimeBtwAttack;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        rb.velocity = new Vector2(speedHBase, speedVBase); //Movement

           if(Input.GetKey("z")){
               speedVBase = speedV;
           }else if(Input.GetKey("s")){
               speedVBase = -speedV;
           }else{
               speedVBase = 0;
           }

           if(Input.GetKey("q")){
               speedHBase = -speedH;
           }else if(Input.GetKey("d")){
               speedHBase = speedH;
           }else{
               speedHBase = 0;
           }


           if(Input.GetKeyDown(KeyCode.Space)){                
              if (timeBtwAttack <=0){
               Instantiate(bullet, firePoint.position, firePoint.rotation);
               GameObject.Find("GestionInventaire").GetComponent<InventaireT2>().Deleteitem();
               timeBtwAttack = startTimeBtwAttack;
               }
           } else {
               timeBtwAttack -= Time.deltaTime;
           }

    }
}
