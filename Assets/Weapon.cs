using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public bool automatical;
    public float coolDown;
    public float recoil;

    public GameObject bullet;
    public bool canShoot = true;
    public float bulletSpawnOffset;

    public bool isFire;

    private float rotation;

    void ReadyToFire()
    {
        canShoot = true;
        if (automatical & isFire)
        {
            Fire();
        }
    }

    public void Fire()
    {
        if (canShoot)
        {
            Instantiate(bullet, transform.position + transform.up * bulletSpawnOffset, transform.rotation);
            canShoot = false;
            Invoke("ReadyToFire", coolDown);

            rotation = transform.parent.parent.localEulerAngles.z;
            rotation += recoil * Random.Range(-1f, 1f);
            transform.parent.parent.localRotation = Quaternion.Euler(0, 0, rotation);
        }
    }
}
