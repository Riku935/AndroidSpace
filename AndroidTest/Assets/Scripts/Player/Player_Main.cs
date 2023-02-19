using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Main : MonoBehaviour
{
    public static Player_Main obj;
    public int life = 3;

    [Header("Inmune Settings")]
    public bool isInmune = false;
    public float inmuneTime = 0.5f;
    public float inmuneTimeCount = 0f;

    private SpriteRenderer spr;
    private void Awake()
    {
        obj = this;
    }
    void Start()
    {
        spr = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        if (life == 0)
        {
            PlayerDeath();
        }
        if (isInmune)
        {
            spr.enabled = !spr.enabled;
            inmuneTimeCount -= Time.deltaTime;
            if (inmuneTimeCount <= 0)
            {
                isInmune = false;
                spr.enabled = true;
            }
        }
    }
    void Inmune()
    {
        isInmune = true;
        inmuneTimeCount = inmuneTime;    
    }
    void PlayerDamage()
    {
        life--;
        Inmune();
    }
    void PlayerDeath()
    {
        GameManager.obj.gameOver = true;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemy"))
        {
            PlayerDamage();
        }
    }
    private void OnDestroy()
    {
        obj = null;
    }
}
