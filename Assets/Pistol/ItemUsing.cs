using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemUsing : MonoBehaviour
{
    public GameObject bullet;

    public void UseLeftMouse()
    {
        Instantiate(bullet, transform.position, transform.rotation);
    }

    public void UseRightMouse()
    {
        Debug.Log("Right");
    }
}
