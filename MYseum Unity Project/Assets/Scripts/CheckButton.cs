using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckButton : MonoBehaviour
{
    public GameObject painting, infoText;
    public void UnclickPainting()
    {
        painting.GetComponent<PaintingScript>().isClicked = false;
        Destroy(gameObject);
        Destroy(infoText);
    }
}
