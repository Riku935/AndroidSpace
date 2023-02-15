using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movement : MonoBehaviour
{
    public static Player_Movement obj;
    private Rigidbody2D rb;
    private Animator anim;
    private float moveHor;
    private float moveVer;
    public float speedHor;
    public float speedVer;
    private void Awake()
    {
        obj = this;
    }
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }
    private void FixedUpdate()
    {
        Move();
        AnimationMove();
    }
    private void Move()
    {
        moveHor = Input.GetAxisRaw("Horizontal");
        moveVer = Input.GetAxisRaw("Vertical");
        rb.velocity = new Vector2(moveHor * speedHor, moveVer * speedVer);
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
}
