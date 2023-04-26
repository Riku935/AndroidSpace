using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GooglePlayGames;
using UnityEngine.SocialPlatforms;

public class ReportManager : MonoBehaviour
{
    void Start()
    {
    }

    private void ShowTrophy()
    {
        if (PlayerPrefs.GetInt("EnemyCount") == 50)
        {

        }
    }
    public void Reporting(string archievement)
    {
        Social.ReportProgress(archievement, 100.0f, (bool success) =>
        {

        });
    }
}
