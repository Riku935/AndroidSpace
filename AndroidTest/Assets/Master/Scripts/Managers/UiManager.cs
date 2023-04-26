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
    public TMP_Text storeLife;
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
        UpdateStoreLifes();
    }

    public void updateLives()
    {
        life.text = "" + Player_Main.obj.currentLife;
    }

    public void updateScore()
    {
        score.text = "" + ScoreManager.obj.currentScore;
    }
    public void UpdateStoreLifes()
    {
        storeLife.text = "" + PlayerPrefs.GetInt("CurrentExtraLives");
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
    public void RetryExtra()
    {
        gameOverMenu.SetActive(false);
        gameMenu.SetActive(true);
    }
    public void GameOver()
    {
        gameMenu.SetActive(false);
        gameOverMenu.SetActive(true);
        if (StoreManager.obj.currentExtraLives == 0)
        {
            gameOverMenu.transform.GetChild(3).gameObject.SetActive(false);
        }
    }

    private void OnDestroy()
    {
        obj = null;
    }
}
