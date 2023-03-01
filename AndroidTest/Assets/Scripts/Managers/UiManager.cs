using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class UiManager : MonoBehaviour
{
    public static UiManager obj;

    public TMP_Text life;
    public TMP_Text score;
    public TMP_Text maxScore;
    [SerializeField] GameObject pauseMenu;
    [SerializeField] GameObject gameOverMenu;
    [SerializeField] GameObject gameMenu;

    private void Awake()
    {
        obj = this;
    }
    private void Update()
    {
        updateLives();
        updateScore();
        MaxScore();
    }

    public void updateLives()
    {
        life.text = "" + Player_Main.obj.life;
    }

    public void updateScore()
    {
        score.text = "" + ScoreManager.obj.currentScore;
    }
    public void MaxScore()
    {
        maxScore.text = "" + ScoreManager.obj.maxScore;
    }
    
    public void Pause()
    {
        pauseMenu.SetActive(true);
        GameManager.obj.gameReady = false;
        GameManager.obj.gamePaused = true;
    }
    public void Resume()
    {
        pauseMenu.SetActive(false);
        GameManager.obj.gameReady = true;
        GameManager.obj.gamePaused = false;
    }
    public void Home()
    {
        SceneManager.LoadScene("MainMenu");
        ScoreManager.obj.MaxScore();
    }
    public void Retry()
    {
        SceneManager.LoadScene("MainScene");
        ScoreManager.obj.MaxScore();
    }
    public void GameOver()
    {
        gameMenu.SetActive(false);
        gameOverMenu.SetActive(true);
    }

    private void OnDestroy()
    {
        obj = null;
    }
}
