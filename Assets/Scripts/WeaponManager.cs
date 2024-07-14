using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class WeaponManager : MonoBehaviour
{
     public GameObject[] weapons; // Array to hold weapons

     void Start()
     {
          SwitchWeapon(0); // Ensure the first weapon is active at the start
     }

     void Update()
     {
          // Optional: Handle keyboard input to switch weapons
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
                    weapons[i].SetActive(i == index); // Activate the current weapon, deactivate others
               }
          }
     }
}
