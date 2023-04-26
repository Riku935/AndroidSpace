using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Ship_Movement : MonoBehaviour
{
    public float moveSpeed;
    public float moveForce;
    private float timer;
    Rigidbody2D rb;
    Animator anim;
    public int randomNumber;
    public float yLimit;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        StartCoroutine("changeMove");
    }
    private void Update()
    {
        DestroyShip();
        LimitUpdate();  
        timer += Time.deltaTime;
        if(timer > 5f ) 
        {
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
            VerticalMove();

            //transform.position = Vector2.MoveTowards(transform.position,currentTarget.position, moveSpeed * Time.deltaTime);
            anim.enabled = true;
        }
        else
        {
            anim.enabled = false;
        }
    }
    IEnumerator changeMove()
    {
        while (true)
        {
            yield return new WaitForSeconds(1);
            randomNumber = Random.Range(0, 2);
        }
    }
    private void VerticalMove()
    {
        if (randomNumber == 0)
        {
            transform.Translate(Vector2.down * moveSpeed * ScoreManager.obj.difficultyMult * Time.deltaTime);
            if(transform.position.y <= yLimit)
            {
                randomNumber = 1;
            }
        }
        else
        {
            transform.Translate(Vector2.up * moveSpeed * ScoreManager.obj.difficultyMult * Time.deltaTime);
            if (transform.position.y >= -   yLimit)
            {
                randomNumber = 0;
            }
        }
    }
    private void LimitUpdate()
    {
                  
    }

}
