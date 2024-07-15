using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Manager : MonoBehaviour
{
    public void ToGame()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Level1Game");
    }

    public void ToMenu()
    {
        SceneManager.LoadScene("Title Screen");
    }

    public void QuitGame()
    {
        Application.Quit();
    }

}
