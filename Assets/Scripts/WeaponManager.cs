using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class WeaponManager : MonoBehaviour
{
     public GameObject[] weapons; 

     void Start()
     {
          SwitchWeapon(0); 
     }

     void Update()
     {
          
          if (Input.GetKeyDown(KeyCode.Alpha1))
          {
               SwitchWeapon(0);
          }
          if (Input.GetKeyDown(KeyCode.Alpha2))
          {
               SwitchWeapon(1);
          }
          if (Input.GetKeyDown(KeyCode.Alpha3))
          {
               SwitchWeapon(2);
          }
     }

     public void SwitchWeapon(int index)
     {
          if (index >= 0 && index < weapons.Length)
          {
               for (int i = 0; i < weapons.Length; i++)
               {
                    weapons[i].SetActive(i == index); 
               }
          }
     }
}
