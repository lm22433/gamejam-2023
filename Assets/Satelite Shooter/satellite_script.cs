using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class satellite_script : MonoBehaviour
{

    public int health = 2;
    public float speed =10f;
    public Rigidbody2D rb_satellite;



    // Start is called before the first frame update

    public void TakeDamage (int damage)
    {
        health-=damage;

        if (health <=0)
        {
            Die();
        }
    }
    void Die(){
        //death sequence
        Destroy(gameObject);
    }


    void OnTriggerEnter2D(Collider2D other){
        if(other.gameObject.CompareTag("bullet")){
            Debug.Log(other.name);

            TakeDamage(1);
    
        }
        if (other.gameObject.tag == "LeftWalls"){
            rb_satellite.velocity=transform.right*speed;
        }
        if (other.gameObject.tag == "RightWalls"){
            rb_satellite.velocity=transform.right*-speed;
            
        }
    }

    void Start(){
        rb_satellite.velocity=transform.right*speed;
        
    }








    // Update is called once per frame

}

