using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.IO;

public class MedalManager : MonoBehaviour
{
    public static MedalManager obj;
    private int currenMedal = -1;
    public string medal = "MedalID";
    public bool canChange = true;
    private void Awake()
    {
        obj = this;
    }
    private void Start()
    {
        currenMedal = PlayerPrefs.GetInt(medal);
    }
    public void Medal()
    {
        string json = File.ReadAllText(Application.streamingAssetsPath + "/GameData.json");
        GameData[] datas = JsonHelper.FromJson<GameData>(json);
        var currentData = datas[currenMedal].id;
        PlayerPrefs.SetInt(medal,currenMedal);
        Debug.Log(currentData);
        CanChange();
    }

    private void CanChange()
    {
        if (canChange == true)
        {
            currenMedal++;
            canChange = false;
        }
    }
    private void OnDestroy()
    {
        obj = null;
    }
}

