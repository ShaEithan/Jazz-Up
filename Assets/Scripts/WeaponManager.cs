using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponManager : MonoBehaviour
{
     public GameObject[] weapons; // Array to hold weapons
     public AudioClip[,] weaponSounds; // 2D array to hold audio clips (weapons x sounds)
     private AudioSource audioSource; // AudioSource component
     private int[] soundIndexes; // Array to track the current sound index for each weapon
     public AudioClip[] weapon1Sounds; // Array to hold sounds for weapon 1
     public AudioClip[] weapon2Sounds; // Array to hold sounds for weapon 2
     public AudioClip[] weapon3Sounds; // Array to hold sounds for weapon 3

     void Start()
     {
          audioSource = GetComponent<AudioSource>();
          soundIndexes = new int[weapons.Length];

          weaponSounds = new AudioClip[3, 3];
          for (int i = 0; i < 3; i++)
          {
               weaponSounds[0, i] = weapon1Sounds[i];
               weaponSounds[1, i] = weapon2Sounds[i];
               weaponSounds[2, i] = weapon3Sounds[i];
          }

          SwitchWeapon(0); // Ensure the first weapon is active at the start
     }
     void Update()
     {
          // Handle keyboard input to switch weapons
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
               PlayWeaponSound(index);
          }
     }

     private void PlayWeaponSound(int index)
     {
          if (index >= 0 && index < weaponSounds.GetLength(0))
          {
               audioSource.clip = weaponSounds[index, soundIndexes[index]];
               audioSource.Play();
               soundIndexes[index] = (soundIndexes[index] + 1) % weaponSounds.GetLength(1);
          }
     }
}
