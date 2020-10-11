using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class Map_Script : MonoBehaviour
{
    public GameObject Map, visual_joystick;
    public void OnMouseDown(){
        if(Map.activeSelf == false)
        {
            Debug.Log("아무말1");
            Map.SetActive(true);
            visual_joystick.SetActive(false);
        }
        else if(Map.activeSelf == true)
        {
            Debug.Log("아무말2");
            Map.SetActive(false);
            visual_joystick.SetActive(true);
        }
    }   

}
