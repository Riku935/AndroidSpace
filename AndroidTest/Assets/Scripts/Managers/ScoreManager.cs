using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager obj;
    public int currentScore;
    public int score = 0;
    public int maxScore ;
    public int scoreChange = 200;
    public float difficultyMult = 1;
    public string maxScoreString = "MaxScore";
    private void Awake()
    {
        obj = this;
    }
    private void Start()
    {
        currentScore = score;
        maxScore = PlayerPrefs.GetInt(maxScoreString);
    }
    private void Update()
    {
        IncreasedDifficulty();
        MaxScore();
    }
    public void MaxScore()
    {
        
        if (currentScore > maxScore)
        {
            maxScore = currentScore;
            PlayerPrefs.SetInt("MaxScore", maxScore);
        }
    }
    public void IncreasedDifficulty()
    {
        if (currentScore > scoreChange || Time.deltaTime > 120)
        {
            difficultyMult *= 1.2f;
            scoreChange *= 2;
        }
    }
    private void OnDestroy()
    {
        obj = null;
    }
}
