using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGround_Move : MonoBehaviour
{
    Rigidbody2D rb;
    public float moveSpeed;
    public float moveForce;
    public GameObject backGroundLimit;
    public float leftLimit;
    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        
    }
    private void FixedUpdate()
    {
        rb.AddForce(Vector2.left * moveForce);
    }
    void LimitInstance()
    {
        if(backGroundLimit.transform.position.x == leftLimit)
        {
            print("H");
        }
    }
}
