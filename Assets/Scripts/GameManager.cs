using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class GameManager : MonoBehaviour
{
    [Header("ScoreElements")]
    public int score;
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI bestScoreText;
    
    [Header("GameOver")]
    public GameObject gameOverPanel;
    public TextMeshProUGUI finalScoreText;

    public void Awake()
    {
        PlayerPrefs.SetInt("bestScore", 0);
        gameOverPanel.SetActive(false);
    }
    public void IncreaseScore()
    {
        score += 1;
        scoreText.text = score.ToString();
    }

    public void OnBombTrigger()
    {
        finalScoreText.text = "Your score is: " + score.ToString();
        if (score > PlayerPrefs.GetInt("bestScore") ){
            PlayerPrefs.SetInt("bestScore",score);
        }
        gameOverPanel.SetActive(true);
        Time.timeScale = 0;
       // Application.Quit();
    }

    public void Restart()
    {
        score = 0;
        bestScoreText.text = PlayerPrefs.GetInt("bestScore").ToString();
        scoreText.text = score.ToString();
        gameOverPanel.SetActive(false);
        Time.timeScale = 1;
        foreach(GameObject g in GameObject.FindGameObjectsWithTag("Interactivo")){
            Destroy(g);
        }

    }
}
