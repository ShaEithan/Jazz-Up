using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int enemyHealth;
    public int damagedealt;
    public Player player;

    // Update is called once per frame
    void Update()
    {
        if (enemyHealth <= 0) {
            player.score += 2;
            Destroy(gameObject);
        }
    }

    void OnCollisionEnter2D(Collision2D col){
        if (col.gameObject.name == "Bullet") {
            enemyHealth -= 1;
        }
    }
}
