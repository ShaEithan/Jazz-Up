using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Player : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth;
    public int score = 0;
    
    public HealthBar healthBar;
    public Score scoreText;
    public GameObject playerObject;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        healthBar.setMaxHealth(maxHealth);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void takeDamage(int damage) {
        currentHealth -= damage;
        healthBar.setHealth(currentHealth);
        healthBar.setHealthText(currentHealth);
        healthBar.setHealthText(currentHealth);
    }

    public void updateScore(int addScore) {
        score += addScore;
        scoreText.setScoreText(score);
    }

    //  public void ToEndScreen()
    //  {
    //       if (currentHealth <= 0)
    //       {
    //            SceneManager.LoadScene("EndScene");
    //       }
    //  }
}
