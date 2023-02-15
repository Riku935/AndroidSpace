using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Ship_Movement : MonoBehaviour
{
    public float moveSpeed;
    public float moveForce;
    Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        DestroyShip();
    }
    private void FixedUpdate()
    {
        transform.Translate(Vector2.left * moveSpeed * Time.deltaTime);
    }
    private void DestroyShip()
    {
        if (transform.position.x <= -12)
        {
            Destroy(gameObject);
        }
    }
}
