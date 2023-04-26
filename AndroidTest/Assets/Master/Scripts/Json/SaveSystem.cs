using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.IO;
using Unity.VisualScripting;

public class SaveSystem : MonoBehaviour
{
    public GameData[] datas;
    void Start()
    {
        TextAsset jsonAsset = Resources.Load<TextAsset>("GameData");
        string json = jsonAsset.text;

        //string json = File.ReadAllText(Application.streamingAssetsPath + "/GameData.json");
        
        datas = JsonHelper.FromJson<GameData>(json);
        
        var currentData = datas[0].description;
    }

    void obtainMedal()
    {

    }
    void Write()
    {
        GameData[] datas = new GameData[150];
        int ids = -1;
        int currentData = -1;
        int ship = 0;
        int currentColor = 0;
        List<string> colors = new List<string>
        {
            "Red",
            "Orange",
            "Yellow",
            "Green",
            "Blue",
            "Purple",
            "Brown",
            "Gray",
            "Pink",
            "Beige"
        };

        for (int i = 0; i < 150; i++)
        {
            ids++;
            currentData++;
            ship++;
            if (ship == 16)
            {
                ship = 1;
                currentColor++;
            }
            //print(ids);
            //datas[currentData] = new GameData(ids, colors[currentColor] + " Ship " + ship, "Card with a " + colors[currentColor] + " ship", false);
            //string json = JsonHelper.ToJson(datas, true);
            //File.WriteAllText(Application.streamingAssetsPath + "/GameData.json", json);
        }
        foreach (var x in colors)
        {
            //Debug.Log(x);
        }
    }

    void Update()
    {
        
    }
}
public static class JsonHelper
{
    public static T[] FromJson<T>(string json)
    {
        Wrapper<T> wrapper = JsonUtility.FromJson<Wrapper<T>>(json);
        return wrapper.Items;
    }

    public static string ToJson<T>(T[] array)
    {
        Wrapper<T> wrapper = new Wrapper<T>();
        wrapper.Items = array;
        return JsonUtility.ToJson(wrapper);
    }

    public static string ToJson<T>(T[] array, bool prettyPrint)
    {
        Wrapper<T> wrapper = new Wrapper<T>();
        wrapper.Items = array;
        return JsonUtility.ToJson(wrapper, prettyPrint);
    }

    [Serializable]
    private class Wrapper<T>
    {
        public T[] Items;
    }
}
