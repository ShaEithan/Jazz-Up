using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int enemyHealth;
    public int damagedealt;
    public Player player;
    public GameObject enemy; 

    void Start() {

    }

    // Update is called once per frame
    void Update()
    {
        if (enemyHealth <= 0) {
            player.score += 2;
            player.updateScore(player.score);
            Destroy(enemy);
        }

        if (player.currentHealth == 0) {
            enemy.SetActive(false);
        }
    }

    void OnCollisionEnter2D(Collision2D col){
        Debug.Log("Collision is Recognized");
        if (col.gameObject.name == "Bullet(Clone)") {
            Debug.Log("Bullet has Hit");
            enemyHealth -= 1;
        }

        else if (col.gameObject.name == "Player") {
            Debug.Log("Player has been hit");
            player.takeDamage(damagedealt);
        }
    }
}
