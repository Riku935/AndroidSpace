using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using EasyJoystick;

public class Player_Movement : MonoBehaviour
{
    public static Player_Movement obj;
    private Rigidbody2D rb;
    private Animator anim;
    [SerializeField] private Joystick joyStick;

    [Header("Move Settings")]
    private float currentHor;
    private float currentVer;
    public float speedHor;
    public float speedVer;

    [Header("Limit Settings")]
    public float xLimit;
    public float yLimit;

    private void Awake()
    {
        obj = this;
    }
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        currentHor = speedHor;
        currentVer = speedVer;
    }
    private void FixedUpdate()
    {
        Move();    
    }
    private void Update()
    {
        LimitUpdate();
        AnimationMove();
    }
    private void Move()
    {
        //currentHor = Input.GetAxisRaw("Horizontal");
        //currentVer = Input.GetAxisRaw("Vertical");
        float xMovement = joyStick.Horizontal();
        float yMovement = joyStick.Vertical();

        //rb.velocity = new Vector2(currentHor * speedHor, currentVer * speedVer);
        rb.velocity = new Vector2(xMovement * speedHor, yMovement * speedVer);


        if (GameManager.obj.gameReady == false)
        {
            speedHor = 0;
            speedVer = 0;
        }
        else
        {
            speedHor = currentHor;
            speedVer = currentVer;
        }
    }
    private void AnimationMove()
    {
        if (Input.GetKey("up"))
        {
            anim.Play("Rocket_Up");
        }
        if (Input.GetKey("down"))
        {
            anim.Play("Rocket_Down");
        }
    }
    private void LimitUpdate()
    {
        if (transform.position.x < xLimit) 
        {
            transform.position = new Vector2 (xLimit, transform.position.y);
        }
        if (transform.position.x > -xLimit)
        {
            transform.position = new Vector2(-xLimit, transform.position.y);
        }

        if (transform.position.y < yLimit)
        {
            transform.position = new Vector2(transform.position.x, yLimit);
        }
        if (transform.position.y > -yLimit)
        {
            transform.position = new Vector2(transform.position.x, -yLimit);
        }
    }
}
