using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryItems : MonoBehaviour
{
    public GameObject inventoryMenu;
    public GameObject openBook;
    public GameObject closedBook;

    public Image[] emptySlots;
    public Sprite[] icons;
    public Sprite emptyIcon;
     
    public static int blueFlower = 0;
    public static int bluePotion = 0;
    public static int bread = 0;
    public static int brownMushroom = 0;
    public static int cheese = 0;
    public static int greenPotion = 0;
    public static int key = 0;
    public static int leafDew = 0;
    public static int meat = 0;
    public static int pinkEgg = 0;
    public static int purpleMushroom = 0;
    public static int purplePotion = 0;
    public static int redFlower = 0;
    public static int redMushroom = 0;
    public static int redPotion = 0;
    public static int roots = 0;

    public static int newIcon = 0;
    public static bool iconUpdate = false;
    private int max;

    void Start()
    {
        CloseMenu();
        max = emptySlots.Length;

        blueFlower = 0;
        bluePotion = 0;
        bread = 0;
        brownMushroom = 0;
        cheese = 0;
        greenPotion = 0;
        key = 0;
        leafDew = 0;
        meat = 0;
        pinkEgg = 0;
        purpleMushroom = 0;
        purplePotion = 0;
        redFlower = 0;
        redMushroom = 0;
        redPotion = 0;
        roots = 0;
    }

    void Update()
    {
        if (iconUpdate == true)
        {
            for (int i = 0; i < max; i++)
            {
                if (emptySlots[i].sprite == emptyIcon)
                {
                    max = i;
                    emptySlots[i].sprite = icons[newIcon];
                    emptySlots[i].transform.gameObject.GetComponent<HintMessage>().objectType = newIcon;
                }
            }

            StartCoroutine(Reset());

        }
    }

    public void OpenMenu()
    {
        inventoryMenu.SetActive(true);
        openBook.SetActive(true);
        closedBook.SetActive(false);
        Time.timeScale = 0;
    }
    
    public void CloseMenu()
    {
        inventoryMenu.SetActive(false);
        openBook.SetActive(false);
        closedBook.SetActive(true);
        Time.timeScale = 1;
    }

    private IEnumerator Reset()
    {
        yield return new WaitForSeconds(0.1f);
        iconUpdate = false;
        max = emptySlots.Length;
    }
}
