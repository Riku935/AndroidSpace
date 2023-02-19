using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ship_Spawner : MonoBehaviour
{
    public Transform[] spawnPoints;
    public GameObject shipPrefab;
    public float timeBetweenSpawn = 1f;
    public float timeToSpawn = 2f;
    void Start()
    {
        
    }

    void Update()
    {
        if (GameManager.obj.gameReady)
        {
            if (Time.time >= timeToSpawn)
            {
                SpawnBlocks();
                timeToSpawn = Time.time + timeBetweenSpawn;
            }
        } 
    }
    void SpawnBlocks()
    {
        int randomList = Random.Range(0, spawnPoints.Length); //Obtenemos un numero aleatorio entre 0 y la cantidad de objetos en la lista

        for (int i = 0; i < spawnPoints.Length; i++) //Se ejecuta mientras i sea menor a la cantidad de objetos en la lista
        {
            if (randomList != i) //Si el numero aleatorio y el valor de i(osea el numero del ciclo en el que nos encontramos) son diferentes entre si, se realiza la funcion
            {
                Instantiate(shipPrefab, spawnPoints[i].position, Quaternion.identity); //Crea un objeto en la posicion del objeto asignado en la lista, dependiendo del valor de i
            }
        }
    }
}
