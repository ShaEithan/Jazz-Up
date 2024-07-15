using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class EndScene : MonoBehaviour
{
    public GameObject gameOverPanel;
    public GameObject HealthBar;
    public GameObject ScoreObject;
    public GameObject playerObject;
    public Player player;
    public bool gameEnded = false;

    [SerializeField] TextMeshProUGUI playerScoreText;
    [SerializeField] TextMeshProUGUI gameOverScoreText;
    
    // Start is called before the first frame update
    void Start()
    {

    }

    void Update() {
        if (player.currentHealth <= 0 && !gameEnded) {
            Debug.Log("Game Ended");
            gameOverPanel.SetActive(true);   
            Debug.Log("Enabled Game Over Panel");
            gameOverScoreText.text = playerScoreText.text;
            HealthBar.SetActive(false);
            ScoreObject.SetActive(false);
            playerObject.SetActive(false);
            Time.timeScale = 0f;
        }
    }
}