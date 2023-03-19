using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    [SerializeField] GameObject mainMenu;
    [SerializeField] GameObject storeMenu;
    [SerializeField] GameObject extraMenu;
    [SerializeField] GameObject medalMenu;

    public void Play()
    {
        SceneManager.LoadScene("MainScene");
    }
    public void Store()
    {
        mainMenu.SetActive(false);
        storeMenu.SetActive(true);
    }
    public void Extra()
    {
        mainMenu.SetActive(false);
        extraMenu.SetActive(true);
    }
    public void ReturnMenuStore()
    {
        storeMenu.SetActive(false);
        mainMenu.SetActive(true);
    }
    public void ReturnMenuExtra()
    {
        extraMenu.SetActive(false);
        mainMenu.SetActive(true);
    }
    public void EraseData()
    {
        PlayerPrefs.SetInt("MaxScore",0);
        PlayerPrefs.SetInt("MedalID", 0);
    }
    public void MedalPanel()
    {
        medalMenu.SetActive(true);
        extraMenu.SetActive(false);
    }
    public void MedalPanelClose()
    {
        medalMenu.SetActive(false);
        extraMenu.SetActive(true);
    }
}
