using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet_Speed : MonoBehaviour
{
    bool collide;
    float timeAlive;
    Rigidbody2D rb;

    public float upSpeed;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        timeAlive = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = Vector3.up * upSpeed;
        timeAlive += Time.deltaTime;

        if(timeAlive >= 3f || collide)
        {
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (!collide)
        {
            collide = true;
        }
    }
}
