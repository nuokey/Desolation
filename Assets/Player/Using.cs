using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Using : MonoBehaviour
{
    public int activeSlot = -1;
    public GameObject slot1;

    void Slots()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {   
            if (activeSlot != 0) 
            {
                transform.GetComponent<Using>().activeSlot = 0;
                slot1.SetActive(true);
            }
            else 
            {
                transform.GetComponent<Using>().activeSlot = -1;
                slot1.SetActive(false);
            }
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
            if(Input.GetKeyDown(KeyCode.Mouse0))
            {
                transform.GetChild(activeSlot).GetChild(0).GetComponent<ItemUsing>().UseLeftMouseDown();
            }
        }
    }

    void Update()
    {
        Slots();
        Use();
    }
}
