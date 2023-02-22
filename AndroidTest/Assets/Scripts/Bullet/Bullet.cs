using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 20f;
    public float damage = 100f;
    public GameObject impactEffect;
    Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        //BulletMovement();
    }

    void Update()
    {
        BulletMovement();
        BulletLimit();
    }
    void BulletMovement()
    {
        rb.velocity = transform.right * speed;
    }
    void BulletLimit()
    {
        if (this.transform.position.x >= 12 )
        {
            gameObject.SetActive(false);
        }
    }
    void BulletImpact()
    {
        Instantiate(impactEffect, transform.position, transform.rotation);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemy"))
        {
            BulletImpact(); 
            gameObject.SetActive(false);
        }
    }
}

