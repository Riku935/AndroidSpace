using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MedalFunction : MonoBehaviour
{
    public float moveSpeed;
    void Start()
    {
        
    }

    void Update()
    {
        MedalMove();
    }

    void MedalMove()
    {
        if (GameManager.obj.gameReady)
        {
            transform.Translate(Vector2.left * moveSpeed * Time.deltaTime);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            gameObject.SetActive(false);
        }
    }
}
