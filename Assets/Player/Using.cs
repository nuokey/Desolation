using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Using : MonoBehaviour
{
    public int activeSlot = -1;

    void Slots()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            transform.GetComponent<Using>().activeSlot = 0;
        }
    }

    void Use()
    {
        if (activeSlot != -1)
        {
            if (Input.GetKey(KeyCode.Mouse0))
            {
                transform.GetChild(activeSlot).GetChild(0).GetComponent<ItemUsing>().UseLeftMouse();
            }
            if (Input.GetKey(KeyCode.Mouse1))
            {
                transform.GetChild(activeSlot).GetChild(0).GetComponent<ItemUsing>().UseRightMouse();
            }
        }
    }

    void Update()
    {
        Slots();
        Use();
    }
}
