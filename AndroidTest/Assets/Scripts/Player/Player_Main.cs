using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Main : MonoBehaviour
{
    public static Player_Main obj;
    public int currentLife;
    public int life = 3;
    [Header("Inmune Settings")]
    public bool isInmune = false;
    public float inmuneTime = 0.5f;
    public float inmuneTimeCount = 0f;

    private SpriteRenderer spr;

    public GameObject deathEffect;
    private void Awake()
    {
        obj = this;
    }
    void Start()
    {
        spr = GetComponent<SpriteRenderer>();
        currentLife = life;
    }

    void Update()
    {
        if (currentLife == 0)
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
        currentLife--;
        Inmune();
        AudioManager.obj.playDamage();
    }
    void PlayerDeath()
    {
        GameManager.obj.gameOver = true;
        Instantiate(deathEffect, transform.position, transform.rotation);
        spr.enabled = false;
        ScoreManager.obj.MaxScore();
    }
    public void PlayerAlive()
    {
        spr.enabled = true;
        currentLife = life;
        Inmune() ;
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
