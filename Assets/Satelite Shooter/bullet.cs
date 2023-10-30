using System.Collections;
using System.Collections.Generic;
using System.Resources;
using UnityEngine;

public class bullet : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed =20f;
    public Rigidbody2D rb;
    void Start()
    {
        rb.velocity=transform.up*speed;
    }

    // void OnTriggerEnter2D(Collider2D hitInfo){
    //     Debug.Log(hitInfo.name);
    //     satellite_script enemy = hitInfo.GetComponent<satellite_script>();
    //     if(hitInfo.tag == "sattelite"){
            
    //         if (enemy != null)
    //         {
    //             enemy.TakeDamage(1);
    //         }
    //         Destroy(gameObject);        
    //     }
    // }
}
