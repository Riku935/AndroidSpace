using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MedalSpawner : MonoBehaviour
{
    public GameObject medalPrefab;
    private bool _canSpawn = false;
    private void Start()
    {
        _canSpawn = true;
    }
    private void Update()
    {
        SpawnMedal();
    }
    private void SpawnMedal()
    {
        if(ScoreManager.obj.currentScore > ScoreManager.obj.maxScore && _canSpawn == true)
        {
            Instantiate(medalPrefab, transform.position, Quaternion.identity);
            _canSpawn = false;
        }
    }
}
