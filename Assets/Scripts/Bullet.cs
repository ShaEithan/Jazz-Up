using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
     // Start is called before the first frame update
     public float speed = 20f;
     private Rigidbody2D rb;


     // Update is called once per frame

     void Start()
     {
          rb.velocity = transform.right * speed;
     }
     
     private void Update()
    {
          
          transform.position += transform.right * Time.deltaTime * speed;
          
    }

     private void OnTriggerEnter2D(Collider2D collision)
     {
          if (collision.tag == "Enemy")
          {
               Destroy(gameObject);
          }
     }



}
