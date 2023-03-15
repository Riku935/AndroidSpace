using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MedalSpawner : MonoBehaviour
{
    public GameObject medalPrefab;
    private void Update()
    {
        SpawnMedal();
    }
    private void SpawnMedal()
    {
        if(ScoreManager.obj.currentScore > ScoreManager.obj.maxScore)
        {
            Instantiate(medalPrefab, transform.position, Quaternion.identity);
        }
    }
}
