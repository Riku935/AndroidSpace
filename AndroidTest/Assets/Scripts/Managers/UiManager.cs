using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UiManager : MonoBehaviour
{
    public static UiManager obj;

    public TMP_Text life;
    public TMP_Text score;

    private void Awake()
    {
        obj = this;
    }
    private void Update()
    {
        updateLives();
        updateScore();
    }

    public void updateLives()
    {
        life.text = "" + Player_Main.obj.life;
    }

    public void updateScore()
    {
        score.text = "" + GameManager.obj.score;
    }

    private void OnDestroy()
    {
        obj = null;
    }
}
