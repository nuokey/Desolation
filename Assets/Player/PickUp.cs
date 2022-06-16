using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    public bool canPickUp = false;

    void FixedUpdate()
    {
        canPickUp = false;
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.transform.GetComponent<Item>())
        {
            canPickUp = true;

            if (Input.GetKey(KeyCode.E))
            {
                collision.transform.SetParent(transform.parent.GetChild(0));
                collision.transform.localPosition = new Vector3(0f, 0f, 0f);
                collision.transform.localEulerAngles = new Vector3(0f, 0f, -90f);
            }
        }
    }
}
