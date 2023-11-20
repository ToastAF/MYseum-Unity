using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObject : MonoBehaviour
{
    //DEPRICATED CODE! Denne kode bruges ikke!
    public GameObject currentPainting;
    
    public void MoveXpos()
    {
        currentPainting.transform.position += new Vector3(0.25f, 0, 0);
    }
    public void MoveXneg()
    {
        currentPainting.transform.position += new Vector3(-0.25f, 0, 0);
    }
    public void MoveYpos()
    {
        currentPainting.transform.position += new Vector3(0, 0.25f, 0);
    }
    public void MoveYneg()
    {
        currentPainting.transform.position += new Vector3(0, -0.25f, 0);
    }
    public void MoveZpos()
    {
        currentPainting.transform.position += new Vector3(0, 0, 0.25f);
    }
    public void MoveZneg()
    {
        currentPainting.transform.position += new Vector3(0, 0, -0.25f);
    }

    // ---------------------------------------------------------------------------------------------------------------- //
    public void RotateXpos()
    {
        currentPainting.transform.Rotate(new Vector3(45, 0, 0));
    }
    public void RotateXneg()
    {
        currentPainting.transform.Rotate(new Vector3(-45, 0, 0));
    }
    public void RotateYpos()
    {
        currentPainting.transform.Rotate(new Vector3(0, 45, 0));
    }
    public void RotateYneg()
    {
        currentPainting.transform.Rotate(new Vector3(0, -45, 0));
    }
    public void RotateZpos()
    {
        currentPainting.transform.Rotate(new Vector3(0, 0, 45));
    }
    public void RotateZneg()
    {
        currentPainting.transform.Rotate(new Vector3(0, 0, -45));
    }

    public void RotationReset()
    {
        currentPainting.transform.rotation = Quaternion.identity;
    }
}
