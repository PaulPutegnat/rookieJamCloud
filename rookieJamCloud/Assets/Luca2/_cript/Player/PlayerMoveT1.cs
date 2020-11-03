using System.Collections;//Equipe Nuage
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoveT1 : MonoBehaviour
{
    private Rigidbody2D rb;
    public Animator anim;
    public float speedH;
    public float speedV;
    private float speedHBase;
    private float speedVBase;

    public Transform firePoint;
    public GameObject knife;
    public GameObject bullet;

    private float timeBtwAttack;
    public float startTimeBtwAttack;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        rb.velocity = new Vector2(speedHBase, speedVBase); //Movement *****************************************************************************************

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
           if(speedHBase == 0 && speedVBase == 0){
               anim.SetBool("Move", false);
           }else{
               anim.SetBool("Move", true);
           }


           if(Input.GetKeyDown(KeyCode.Space)){ // Shoot ****************************************************************************************************************
                if (timeBtwAttack <=0){
                        Shooting();
                        timeBtwAttack = startTimeBtwAttack;
                }
                } else {
                    timeBtwAttack -= Time.deltaTime;
                }
           

    }


    void Shooting(){
        var inv = GameObject.Find("GestionInventaire").GetComponent<InventaireT1>();
        if(inv.Deck[0].name == "Knife"){
            Instantiate(knife, firePoint.position, firePoint.rotation);
        }else{
            Instantiate(bullet, firePoint.position, firePoint.rotation);
        }
        inv.Deleteitem();
        
    }
}
