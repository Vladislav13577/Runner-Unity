using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public bool stopGame = true;
    public GameObject menuScreen;
    public GameObject gameOverScreen;



    public void StartGame()
    {
        stopGame = false;
        menuScreen.SetActive(false);
    }

    public void RestartGame()
    {
        SceneManager.LoadScene("Game");
    }

    public void GameOver()
    {
        stopGame = true;
        gameOverScreen.SetActive(true);
    }
}
