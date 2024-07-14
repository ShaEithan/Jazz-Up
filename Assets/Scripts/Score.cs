using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Score : MonoBehaviour
{   
    public Player player;
    [SerializeField] TextMeshProUGUI scoreText;

    public void setScoreText(int playerScore) {
        scoreText.text = "" + playerScore;
    }
}
