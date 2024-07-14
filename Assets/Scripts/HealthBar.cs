using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class HealthBar : MonoBehaviour 
{
    public Slider slider; 
    [SerializeField] TextMeshProUGUI healthNumber;

    public void setHealth(int health) {
        slider.value = health;
    }

    public void setMaxHealth(int health) {
        slider.maxValue = health;
        slider.value = health;
    }

    public void setHealthText(int currentHealth) {
        healthNumber.text = currentHealth + " / " + slider.maxValue;
    }
}