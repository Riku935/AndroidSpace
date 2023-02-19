using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ship_Main : MonoBehaviour
{
    public int shipLife = 100;
    public bool isDead = false;
    public GameObject destroyEffect;
    void Start()
    {
        
    }

    void Update()
    {
        ShipDeath();
    }
    void ShipDeath()
    {
        if (shipLife == 0)
        {
            ShipDestroy();
        }
    }
    void ShipDestroy()
    {
        Destroy(gameObject);
        Instantiate(destroyEffect, transform.position, transform.rotation);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            ShipDestroy();
        }
        if(collision.CompareTag("Bullet"))
        {
            shipLife -= 100;
            GameManager.obj.score += 100;
        }
    }
}
