using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Pickup : MonoBehaviour
{
    public int number;
    public bool redMushroom = false;
    public bool purpleMushroom = false;
    public bool brownMushroom = false;
    public bool blueFlower = false;
    public bool redFlower = false;
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (redMushroom == true)
            {
                if(InventoryItems.redMushroom == 0)
                {
                    DisplayIcons();
                }
                InventoryItems.redMushroom++;
                Destroy(gameObject);
            }
            else if(blueFlower == true)
            {
                if (InventoryItems.blueFlower == 0)
                {
                    DisplayIcons();
                }
                InventoryItems.blueFlower++;
                Destroy(gameObject);
            }
            else
            {
                DisplayIcons();
                Destroy(gameObject);
            }

        }
    }

    private void DisplayIcons()
    {
        InventoryItems.newIcon = number;
        InventoryItems.iconUpdate = true;

    }
}
