using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Ship_Movement : MonoBehaviour
{
    public float moveSpeed;
    public float moveForce;
    public Transform[] movePoints;
    private Transform currentTarget;
    private float timer;
    Rigidbody2D rb;
    Animator anim;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        randomPoint();
    }
    private void Update()
    {
        DestroyShip();
        timer += Time.deltaTime;
        if(timer > 5f ) 
        {
            randomPoint();
            timer = 0;
        }
    }
    private void FixedUpdate()
    {
        ShipMove();
    }
    private void DestroyShip()
    {
        if (transform.position.x <= -12)
        {
            gameObject.SetActive(false);
        }
    }
    private void ShipMove() 
    {
        if (GameManager.obj.gameReady)
        {
            transform.Translate(Vector2.left * moveSpeed * ScoreManager.obj.difficultyMult * Time.deltaTime);
            //transform.position = Vector2.MoveTowards(transform.position,currentTarget.position, moveSpeed * Time.deltaTime);
            anim.enabled = true;
        }
        else
        {
            anim.enabled = false;
        }
    }
    private void randomPoint()
    {
        int amount = Random.Range(0, movePoints.Length);
        currentTarget = movePoints[amount];
    }
}
