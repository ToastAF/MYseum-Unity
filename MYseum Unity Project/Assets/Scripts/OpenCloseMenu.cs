using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenCloseMenu : MonoBehaviour
{
    //Variabel til at tjekke, om menuen er �ben eller ej
    bool menuOpened = false;
    public GameObject menu; //Vores UI GameObject

    void Start()
    {
        //Menuen lukkes til at starte med
        menu.SetActive(false);
    }

    void Update()
    {
        //N�r der klikkes p� ecape
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            //tjekker den, om menuen er �ben. Og hvis den er,
            if(menuOpened == true)
            {
                //lukkes den igen
                menu.SetActive(false);
                menuOpened = false;
            //og omvendt :)
            }else if(menuOpened == false)
            {
                menu.SetActive(true);
                menuOpened = true;
            }
        }
    }

    public void CloseMenu()
    {
        menu.SetActive(false);
    }
}
