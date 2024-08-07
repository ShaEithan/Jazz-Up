using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;



public class PlayerMovement : MonoBehaviour
{
     private float horizontal;
     private float speed = 5f;
     private float jump = 10f;
     public bool faceright = true;

     [SerializeField] private Rigidbody2D rb;
     [SerializeField] private Transform groundcheck;
     [SerializeField] private LayerMask groundLayer;

    

    // Update is called once per frame
    void Update()
    {
          horizontal = Input.GetAxisRaw("Horizontal");
          PleaseFlip();

          if (Input.GetButton("Jump") && OnFloor())
          {
               rb.velocity = new Vector2(rb.velocity.x, jump);
          }

          if (Input.GetButtonUp("Jump") && rb.velocity.y > 0f)
          {
               rb.velocity = new Vector2(rb.velocity.x, rb.velocity.y * 0.5f);
          }
    }

     private bool OnFloor()
     {
          return Physics2D.OverlapCircle(groundcheck.position, 0.2f, groundLayer);
     }

     private void FixedUpdate()
     {
          rb.velocity = new Vector2(horizontal * speed, rb.velocity.y);
     }

     private void PleaseFlip()
     {
          if (faceright && horizontal < 0f || !faceright && horizontal > 0f)
          {
               faceright = !faceright;

               transform.Rotate(new Vector3(0, 180, 0));
          }
     }
}




