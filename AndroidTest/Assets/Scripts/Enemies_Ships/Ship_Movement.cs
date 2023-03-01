using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Ship_Movement : MonoBehaviour
{
    public float moveSpeed;
    public float moveForce;
    Rigidbody2D rb;
    Animator anim;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }
    private void Update()
    {
        DestroyShip();
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
            anim.enabled = true;
        }
        else
        {
            anim.enabled = false;
        }
    }
    private void IncreasedDifficulty()
    {

    }
}
