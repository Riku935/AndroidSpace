using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager obj;
    public bool gameWin = false;
    public bool gameOver = false;
    public bool gamePaused = false;
    public bool gameReady = true;
    public int score;

    private void Awake()
    {
        obj = this;
    }
    private void Update()
    {
        GameOver();
    }
    public void GameOver()
    {
        if (gameOver == true)
        {
            gameReady = false;
            UiManager.obj.GameOver();
        }
    }
    public void GameRetry()
    {
        gameOver = false;
        gameReady = true;
        ScoreManager.obj.MaxScore();
        Player_Main.obj.PlayerAlive();
        UiManager.obj.RetryExtra();
    }
    public void GamePaused()
    {
        gamePaused = true;
        gameReady = false;
    }
    
    private void OnDestroy()
    {
        obj = null;
    }
}
