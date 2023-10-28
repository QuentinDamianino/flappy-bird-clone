using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicScript : MonoBehaviour
{
    public int playerScore;
    public Text scoreText;
    public GameObject gameOverScreen;
    public AudioSource gameOverSound;
    public AudioSource pauseMusic;
    public GameObject mainMusic;

    [ContextMenu("Increase Score")]
    public void addScore(int scoreToAdd)
    {
        playerScore += scoreToAdd;
        scoreText.text = playerScore.ToString();
    }

    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void gameOver()
    {
        if (!gameOverScreen.activeSelf)
        {
            gameOverSound.Play();
            pauseMusic.Play();
            mainMusic.GetComponent<AudioSource>().Stop();
            gameOverScreen.SetActive(true);
        }
    }
}
