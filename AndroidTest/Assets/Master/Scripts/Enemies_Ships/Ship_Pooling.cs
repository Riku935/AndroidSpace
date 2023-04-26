using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ship_Pooling : MonoBehaviour
{
    public static Ship_Pooling instance;
    private List<GameObject> pooledObjects = new List<GameObject>(); //Objetos que voy a reciclar
    private int amountToPool = 10; //Cantidad de objetos disponibles para reciclar
    [SerializeField] private GameObject ShipPrefab;


    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }
    void Start()
    {
        for (int i = 0; i < amountToPool; i++)
        {
            GameObject obj = Instantiate(ShipPrefab);
            obj.SetActive(false);
            pooledObjects.Add(obj);
        }
    }

    public GameObject GetPooledObject()
    {
        for (int i = 0; i < pooledObjects.Count; i++)
        {
            if (!pooledObjects[i].activeInHierarchy)
            {
                return pooledObjects[i];
            }
        }
        return null;
    }
}
