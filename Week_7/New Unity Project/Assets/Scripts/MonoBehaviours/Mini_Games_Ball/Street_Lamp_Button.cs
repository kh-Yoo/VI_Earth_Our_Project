 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Street_Lamp_Button : MonoBehaviour
{
    public GameObject Street_lamp_panel, visual_joystick;
    public void Update()
    {
        /*if (Input.GetMouseButtonDown(0))
        {
            touch_enemy();
        }*/
    }

    public void OnMouseDown()
    {
        if (Street_lamp_panel.activeSelf == false)
        {
            Debug.Log("아무말1");
            Street_lamp_panel.SetActive(true);
            visual_joystick.SetActive(false);
        }
        else
        {
            Debug.Log("아무말2");
            Street_lamp_panel.SetActive(false);
            visual_joystick.SetActive(true);
        }
    }
    /*private void touch_enemy()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);
        if (hit.collider != null)
        {
            Destroy(gameObject);
        }
    }*/


}
