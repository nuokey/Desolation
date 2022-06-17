using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemUsing : MonoBehaviour
{
    public GameObject bullet;
    public float coolDown;
    public bool canShoot;

    void ReadyToFire()
    {
        canShoot = true;
    }

    public void UseLeftMouse()
    {   
        if (canShoot)
        {
            Instantiate(bullet, transform.position, transform.rotation);
            canShoot = false;
            Invoke("ReadyToFire", coolDown);
        }
        
    }

    public void UseRightMouse()
    {
        Debug.Log("Right");
    }
}
