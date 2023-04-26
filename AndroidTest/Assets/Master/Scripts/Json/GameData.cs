using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class GameData 
{
    public string name;
    public string description;
    public int id;
    public bool getCard;
    public GameData (int id, string name, string description, bool getCard)
    {
        this.id = id;
        this.name = name;
        this.description = description;
        this.getCard = getCard;
    }
}
