using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class Street_lamp_script : MonoBehaviour
{
    public GameObject Street_lamp_panel, visual_joystick, Street_lamp_button;
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
	Street_lamp_button.GetComponent<Button>().enabled = false;
        }
        else
        {
            Debug.Log("아무말2");
            Street_lamp_panel.SetActive(false);
            visual_joystick.SetActive(true);
	Street_lamp_button.GetComponent<Button>().enabled = true;
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
