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
            isDead = true;
        }
    }
    void ShipDestroy()
    {
        gameObject.SetActive(false);
        Instantiate(destroyEffect, transform.position, transform.rotation);
        shipLife = 100;
        AudioManager.obj.playHit();
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
            ScoreManager.obj.currentScore += 100;
        }
    }
}
