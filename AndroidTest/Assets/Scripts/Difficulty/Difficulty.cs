using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Difficulty : MonoBehaviour
{
    int score = 0;
    int scoreChange = 1000;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(score > scoreChange)
        {
            changeDifficulty();
        }
    }
    void changeDifficulty()
    {
        scoreChange *= 2;
    }
}
