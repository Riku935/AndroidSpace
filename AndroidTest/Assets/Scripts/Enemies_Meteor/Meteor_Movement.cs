using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Meteor_Movement : MonoBehaviour
{
    public float rotationSpeed;
    public float moveSpeed;
    public GameObject destroyEffect;
    Rigidbody2D rb;
    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (GameManager.obj.gameReady)
        {
            transform.Rotate(0, 0, -rotationSpeed);
            rb.WakeUp();
            rb.gravityScale = 0.02f;
        }
        if (GameManager.obj.gameReady == false)
        {
            rb.gravityScale = 0;
            rb.Sleep();
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player") || collision.CompareTag("Bullet"))
        {
            Destroy(gameObject);
            Instantiate(destroyEffect, transform.position, transform.rotation);
            GameManager.obj.score += 100;
        }
    }
}
