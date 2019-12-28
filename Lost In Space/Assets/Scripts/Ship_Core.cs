using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ship_Core : MonoBehaviour
{

    Rigidbody2D rb;

    public float horizontalSpeed;
    public float moveUp;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float moveHor = Input.GetAxisRaw("Horizontal") * horizontalSpeed;

        rb.velocity = new Vector2(moveHor * Time.fixedDeltaTime, moveUp);
    }
}
