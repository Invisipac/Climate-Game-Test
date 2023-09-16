using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.UI;
using UnityEngine.SceneManagement;

public class GameOverButtons : MonoBehaviour
{
    public void playAgainButton()
    {
        SceneManager.LoadScene("Game");
    }

    public void exitButton()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void startGame()
    {
        SceneManager.LoadScene("Game");
    }

    public void instructions()
    {
        SceneManager.LoadScene("Instructions");
    }

    public void backButton()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void exitGame()
    {
        Application.Quit();
        Debug.Log("Game Closed.");
    }
}
