using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenCloseMenu : MonoBehaviour
{
    bool menuOpened = false;
    public GameObject menu;

    void Start()
    {
        menu.SetActive(false);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if(menuOpened == true)
            {
                menu.SetActive(false);
                menuOpened = false;
            }else if(menuOpened == false)
            {
                menu.SetActive(true);
                menuOpened = true;
            }
        }
    }
}
