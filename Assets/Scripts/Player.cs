using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameManager gameManager;
    public float velocity = 2.4f;
    public float speed = 2f;
    public bool isDead = false;
    private Rigidbody2D rigidbody;
    public bool isGo;
    public bool isStart;

    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (isDead)
        {
            GetComponent<Animator>().enabled = false;
        }

        if (Input.GetMouseButtonDown(0) && !isGo)
        {
            if (!isStart)
            {

                isStart = true;
                rigidbody.gravityScale = 1;
            }
            rigidbody.velocity = Vector2.up * velocity;
            rigidbody.velocity = new Vector2(speed, rigidbody.velocity.y);


        }


    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag == "DeathZone")
        {
            isDead = true;
        }
        else
        if (collision.transform.tag == "Obstical")
        {
            isDead = true;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "DeathZone")
        {
            isDead = true;
        }
        if (collision.gameObject.CompareTag("CoinPoint")) Debug.Log("Win 1 point");
    }
}


































