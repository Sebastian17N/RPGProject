using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System;
using static TMPro.SpriteAssetUtilities.TexturePacker_JsonArray;
using UnityEditor;

public class HintMessage : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerClickHandler
{
    public GameObject hintBox;
    public Text message;
    public int objectType;

    private Vector3 screenPoint;

    public void OnPointerEnter(PointerEventData eventData)
    {
        hintBox.SetActive(true);
        screenPoint.x = Input.mousePosition.x + 400;
        screenPoint.y = Input.mousePosition.y;
        screenPoint.z = 1f;

        hintBox.transform.position = Camera.main.ScreenToWorldPoint(screenPoint);
        MessageDisplay();
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        hintBox.SetActive(false);
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        hintBox.SetActive(false);
    }

    void Start()
    {
        hintBox.SetActive(false);
    }

    private void MessageDisplay()
    {
        switch (objectType)
        {
            case 0:
                message.text = "Empty";
                break;
            case 1:
                message.text = InventoryItems.blueFlower.ToString() + " blue flower to be use in potions";
                break;
            case 2:
                message.text = InventoryItems.bluePotion.ToString() + " blue potion to be use in potions";
                break;
            case 3:
                message.text = InventoryItems.bread.ToString() + " bread to be use in potions";
                break;
            case 4:
                message.text = InventoryItems.brownMushroom.ToString() + " brown mushroom to be use in potions";
                break;
            case 5:
                message.text = InventoryItems.cheese.ToString() + " cheese to be use in potions";
                break;
            case 6:
                message.text = InventoryItems.greenPotion.ToString() + " green potion to be use in potions";
                break;
            case 7:
                message.text = "key to open chest";
                break;
            case 8:
                message.text = InventoryItems.leafDew.ToString() + " leaf dew to be use in potions";
                break;
            case 9:
                message.text = InventoryItems.meat.ToString() + " meat to be use in potions";
                break;
            case 10:
                message.text = InventoryItems.pinkEgg.ToString() + " pink egg to be use in potions";
                break;
            case 11:
                message.text = InventoryItems.purpleMushroom.ToString() + " purple mushroom to be use in potions";
                break;
            case 12:
                message.text = InventoryItems.purplePotion.ToString() + " purple potion to be use in potions";
                break;
            case 13:
                message.text = InventoryItems.redFlower.ToString() + " red flower to be use in potions";
                break;
            case 14:
                message.text = InventoryItems.redMushroom.ToString() + " red mushroom to be use in potions";
                break;
            case 15:
                message.text = InventoryItems.redPotion.ToString() + " red potion to be use in potions";
                break;
            case 16:
                message.text = InventoryItems.roots.ToString() + " roots to be use in potions";
                break;
        }
    }
}
