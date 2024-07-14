using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
     // Start is called before the first frame update
     public float speed;
     private Rigidbody2D rb;
    

    // Update is called once per frame
    private void Update()
    {     
          
          transform.position += transform.right * Time.deltaTime * speed;
    }

     private void OnCollisionEnter2D(Collision2D collision)
     {
          if (collision.gameObject.tag == "Enemy")
          {
               Destroy(gameObject);
          }
          
     }

    
}
