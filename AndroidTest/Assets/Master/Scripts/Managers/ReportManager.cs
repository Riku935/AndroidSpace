using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GooglePlayGames;
using GooglePlayGames.BasicApi;
using UnityEngine.SocialPlatforms;

public class ReportManager : MonoBehaviour
{
    public static ReportManager obj;
    private void Awake()
    {
        obj = this;
    }
    void Start()
    {
        PlayGamesPlatform.Instance.Authenticate(ProcessAuthentication);
    }

    public void ShowTrophy()
    {
        if (PlayerPrefs.GetInt("GameCount") == 1)
        {
            Reporting(GPGSIds.achievement_welcome);
        }
        if (PlayerPrefs.GetInt("GameCount") == 50)
        {
            Reporting(GPGSIds.achievement_you_liked_my_game);
        }
        if (PlayerPrefs.GetInt("GameCount") == 200)
        {
            Reporting(GPGSIds.achievement_you_liked_my_game_a_lot);
        }
        //Logros de matar enemigos
        if (PlayerPrefs.GetInt(StatsManager.obj.enemy) >= 1)
        {
            Reporting(GPGSIds.achievement_go_ahead_with_all);
        }
        if (PlayerPrefs.GetInt(StatsManager.obj.enemy) >= 1)
        {
            Reporting(GPGSIds.achievement_break_ships);
        }
        if (PlayerPrefs.GetInt(StatsManager.obj.enemy) >= 1000)
        {
            Reporting(GPGSIds.achievement_ship_champion);
        }
        //Aqui estan los logros de score
        if (PlayerPrefs.GetInt(StatsManager.obj.score) >= 500)
        {
            Reporting(GPGSIds.achievement_500_champion);
        }
        if (PlayerPrefs.GetInt(StatsManager.obj.score) >= 5000)
        {
            Reporting(GPGSIds.achievement_5000_champion);
        }
        if (PlayerPrefs.GetInt(StatsManager.obj.score) >= 10000)
        {
            Reporting(GPGSIds.achievement_10000_champion);
        }
        //Coleccionables
        if (PlayerPrefs.GetInt(StatsManager.obj.medal) >= 150)
        {
            Reporting(GPGSIds.achievement_collector);
        }

    }
    public void Reporting(string archievement)
    {
        Social.ReportProgress(archievement, 100.0f, (bool success) =>
        {

        });
    }

    internal void ProcessAuthentication(SignInStatus status)
    {
        if (status == SignInStatus.Success)
        {
            // Continue with Play Games Services
        }
        else
        {
            // Disable your integration with Play Games Services or show a login button
            // to ask users to sign-in. Clicking it should call
            // PlayGamesPlatform.Instance.ManuallyAuthenticate(ProcessAuthentication).
        }
    }
    private void OnDestroy()
    {
        obj = null;
    }
}
