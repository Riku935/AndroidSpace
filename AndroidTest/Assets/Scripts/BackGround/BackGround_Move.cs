using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGround_Move : MonoBehaviour
{
    Rigidbody2D rb;
    public float moveSpeed;
    public float moveForce;
    public float leftLimit;

    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        LimitInstance();
    }
    private void FixedUpdate()
    {
        if (GameManager.obj.gameReady)
        {
            transform.Translate(Vector2.left * moveSpeed * Time.deltaTime);
        }
    }
    void LimitInstance()
    {
        bool canChange = true;
        if(transform.position.x <= leftLimit && canChange == true)
        {
            transform.position = new Vector2(19, 0);
            canChange = false;
        }
        if (transform.position.x >= leftLimit && canChange == false)
        {
            canChange = true;
        }
    }
}
