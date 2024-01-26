using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Logic : MonoBehaviour
{
    public int score;
    public Text scoreText;
    public GameObject gameOverScreen;
    public Bird bird;
    public AudioSource pointSFX;
    public AudioSource dieSFX;

    [ContextMenu("Increase Score")]
    public void addScore(int value)
    {   
        if (bird.isAlive)
        {
            score += value;
            scoreText.text = score.ToString();
            pointSFX.Play();
        }
    }

    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void gameOver()
    {
        if (bird.isAlive)
        {
            gameOverScreen.SetActive(true);
            bird.isAlive = false;
            dieSFX.Play();
        }
    }

}
