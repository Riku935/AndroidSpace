using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MedalsManager : MonoBehaviour
{
    public GameObject[] collectibles;
    public GameObject[] containers;
    public int currentMedal = -1;
    public string name;
    public SaveSystem obj;
    void Start()
    {
        Collectibles();
        Container();
        currentMedal = PlayerPrefs.GetInt("MedalID");

    }
    void Collectibles()
    {
        collectibles = GameObject.FindGameObjectsWithTag("Medal");
        foreach (var x in collectibles)
        {
            x.SetActive(false);
        }
    }
    void Container()
    {
        containers = GameObject.FindGameObjectsWithTag("Container");
        foreach (var x in containers)
        {
            x.SetActive(false);
        }
    }
    [ContextMenu("ShowModel")]
    void UnlockMedal()
    {
        currentMedal++;
    }
    
    void Update()
    {
        for (int i = 0; i < currentMedal; i++)
        {
            currentMedal--;
            collectibles[currentMedal].SetActive(true);
            name = obj.datas[currentMedal].description;
            GameObject childName = collectibles[currentMedal].transform.GetChild(1).gameObject;
            TextMeshProUGUI nameText = childName.GetComponent<TextMeshProUGUI>();
            nameText.text = name;
        }
    }
}
