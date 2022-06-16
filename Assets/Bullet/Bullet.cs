using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public Rigidbody2D rb;
    public float speed;

    private void Start()
    {
        rb = transform.GetComponent<Rigidbody2D>();
        rb.AddForce(transform.forward * speed);
    }

    void FixedUpdate()
    {
        
    }
}
