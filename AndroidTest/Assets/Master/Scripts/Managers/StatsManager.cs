using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatsManager : MonoBehaviour
{
    public static StatsManager obj;

    public int enemyCount;
    public int shootCount;
    public int GameCount;
    public int scoreCount;
    public int medalCount;
    public int totalLifeCount;

    public string enemy = "EnemyCount";   //Cantidad de enemigos muertos
    public string shoot = "ShootCount";   //Cantidad de disparos hechos
    public string game = "GameCount";     //Cantidad de juegos jugados
    public string score = "ScoreCount";   //Cantidad de score
    public string medal = "MedalCount";   //Cantidad de medallas
    public string life = "TotalLifeCount";//Cantidad de vidas gastadas 

    private void Awake()
    {
        obj = this;
    }

    public void SetStats()
    {
        PlayerPrefs.SetInt(enemy, PlayerPrefs.GetInt(enemy) + enemyCount);
        PlayerPrefs.SetInt(shoot, PlayerPrefs.GetInt(shoot) + shootCount);
        PlayerPrefs.SetInt(game, PlayerPrefs.GetInt(game) + GameCount);
        PlayerPrefs.SetInt(score, PlayerPrefs.GetInt(score) + scoreCount);
        PlayerPrefs.SetInt(medal, PlayerPrefs.GetInt(medal) + medalCount);
        PlayerPrefs.SetInt(life, PlayerPrefs.GetInt(life) + totalLifeCount);

    }

    private void OnDestroy()
    {
        obj = null;
    }
}
