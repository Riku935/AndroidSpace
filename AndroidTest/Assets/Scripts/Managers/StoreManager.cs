using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoreManager : MonoBehaviour
{
    public static StoreManager obj;
    private string ExtraLivesString = "CurrentExtraLives";
    public int currentExtraLives = 0;

    private void Awake()
    {
        obj = this;
    }
    private void Start()
    {
        currentExtraLives = PlayerPrefs.GetInt(ExtraLivesString);
    }

    public void AddExtraLife()
    {
        PlayerPrefs.SetInt(ExtraLivesString, PlayerPrefs.GetInt(ExtraLivesString) + 10);
    }
    public void RemoveExtraLife()
    {
        PlayerPrefs.SetInt(ExtraLivesString, PlayerPrefs.GetInt(ExtraLivesString) - 1);
    }


    private void OnDestroy()
    {
        obj = null;
    }
}
