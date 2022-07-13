using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemUsing : MonoBehaviour
{
    public GameObject bullet;
    public float coolDown;
    public bool canShoot;
    public float bulletSpawnOffset;

    void ReadyToFire()
    {
        canShoot = true;
    }

    public void UseLeftMouse()
    {   
        if (canShoot)
        {
            Instantiate(bullet, transform.position + transform.up * bulletSpawnOffset, transform.rotation);
            canShoot = false;
            Invoke("ReadyToFire", coolDown);
        }
        
    }

    public void UseLeftMouseDown()
    {

    }

    public void UseRightMouse()
    {
        
    }
    public void UseRightMouseDown()
    {
        
    }
}
