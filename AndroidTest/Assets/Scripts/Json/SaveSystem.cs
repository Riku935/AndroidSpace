using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.IO;

public class SaveSystem : MonoBehaviour
{
    void Start()
    {
        GameData[] datas = new GameData[150];
        int ids = 0;
        int currentData = 0;
        for (int i = 0; i <150 ; i++)
        {
            ids++;
            currentData++;
            print(ids);
            datas[currentData] = new GameData("Pikachu", "Rata amarilla", ids);
            string json = JsonHelper.ToJson(datas, true);
            File.WriteAllText(Application.streamingAssetsPath + "/GameData.json", json);
        }
        
        //print(datas[0].name);
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
