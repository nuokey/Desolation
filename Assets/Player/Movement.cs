using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public Rigidbody2D rb;
    public float speed;
    public Transform mouse;

    public float mouseHorizontalSens;
    float zRotation;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Walking()
    {
        if (Input.GetKey(KeyCode.W))
        {
            rb.AddForce(transform.up * speed);
        }
        if (Input.GetKey(KeyCode.D))
        {
            rb.AddForce(transform.right * speed);
        }
        if (Input.GetKey(KeyCode.S))
        {
            rb.AddForce(-transform.up * speed);
        }
        if (Input.GetKey(KeyCode.A))
        {
            rb.AddForce(-transform.right * speed);
        }
    }

    void Turning()
    {
        zRotation = transform.localEulerAngles.z;

        float mouseX = Input.GetAxis("Mouse X") * mouseHorizontalSens * Time.deltaTime;
        zRotation -= mouseX;
        transform.localRotation = Quaternion.Euler(0f, 0f, zRotation);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Walking();
        Turning();
    }
}
