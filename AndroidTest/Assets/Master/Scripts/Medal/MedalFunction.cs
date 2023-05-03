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
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            gameObject.SetActive(false);
            MedalManager.obj.Medal();
            StatsManager.obj.medalCount++;
        }
    }
}
