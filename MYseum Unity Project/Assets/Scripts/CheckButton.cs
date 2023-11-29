using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckButton : MonoBehaviour
{
    public GameObject painting, infoText, paintingCam;
    public void UnclickPainting()
    {
        if(painting != null)
        {
            painting.GetComponent<PaintingScript>().isClicked = false;
            painting.GetComponent<PaintingScript>().isViewed = false;
        }
        if (infoText != null) 
        {
            Destroy(infoText);
        }
        GameObject.FindGameObjectWithTag("GameController").GetComponent<SpawnMaleri>().editMode = false;
        if(paintingCam != null)
        {
            paintingCam.SetActive(false);
        }
        Destroy(gameObject);
    }
}
