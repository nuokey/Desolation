using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item: MonoBehaviour
{
    public string typeOfItem;

    public Vector3 slotOffset;

    public void UseLeftMouseDown()
    {
        if (typeOfItem == "Weapon")
        {
            transform.GetComponent<Weapon>().Fire();
            transform.GetComponent<Weapon>().isFire = true;
        }
    }
    public void UseLeftMouseUp()
    {
        if (typeOfItem == "Weapon")
        {
            transform.GetComponent<Weapon>().isFire = false;
        }
    }
}
