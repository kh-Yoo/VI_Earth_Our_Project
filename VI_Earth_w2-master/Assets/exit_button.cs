using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class exit_button : MonoBehaviour
{
    public GameObject cube, visual_joystick;
    // Start is called before the first frame update
    void Start()
    {

    }

    public void exit_OnClick()
    {
        Debug.Log("ass");

        cube.SetActive(false);
        visual_joystick.SetActive(true);
    }

}
