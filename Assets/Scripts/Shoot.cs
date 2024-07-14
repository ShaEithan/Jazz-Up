using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.InputSystem;
public class Shoot : MonoBehaviour
{
     public Transform shootingPoint;
     public GameObject bulletPrefab;
     // Start is called before the first frame update

     //public Transform shootingPoint;
     //public GameObject bulletPrefab;

     // Update is called once per frame

     /*
    private void Update()
    {
          if (Keyboard.current.enterKey.wasPressedThisFrame)
          {
               Instantiate(bulletPrefab, shootingPoint.position, transform.rotation);
          }
    }
    */

     void Update()
     {
          if (Input.GetButtonDown("Fire1"))
          {
               Shooter();
          }

     }

     void Shooter()
     {
          Instantiate(bulletPrefab, shootingPoint.position, transform.rotation);
     }

}
