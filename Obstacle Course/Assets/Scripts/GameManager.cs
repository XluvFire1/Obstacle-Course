using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public bool IsGameActive;
    public int Score = 0;
    public TextMeshProUGUI ScoreText;
    public TextMeshProUGUI GameOverText;
    //public TextMeshProUGUI GameTitleText;
    //public Button StartButton;
    public GameObject StartScene;
    public Button RestartButton;
  
    // Start is called before the first frame update
    void Start()
    {
        IsGameActive = false;
    }

    public void StartGame()
    {
        //GameTitleText.gameObject.SetActive(false);
        //StartButton.gameObject.SetActive(false);
        StartScene.gameObject.SetActive(false);
        ScoreText.gameObject.SetActive(true);
        IsGameActive = true;
        ScoreText.text = "Score: " + Score;
    }
    public void UpdateScore(int addToScore)
    {
        Score += addToScore;
        Debug.Log("Score: " + Score.ToString());
        ScoreText.text = "Score: " + Score.ToString();
    }

    public void GameOver()
    {
        IsGameActive = false;
        GameOverText.gameObject.SetActive(true);
        RestartButton.gameObject.SetActive(true);
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
