using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Cursors : MonoBehaviour
{
    public GameObject CursorObject;
    public Sprite CursorBasic;
    public Sprite CursorHand;
    public Image CursorImage;
    void Start()
    {
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        CursorObject.transform.position = Input.mousePosition;

        if (Input.GetMouseButton(1))
        {
            CursorImage.sprite = CursorHand;
        }
        else
        {
            CursorImage.sprite = CursorBasic;
        }
    }
}
