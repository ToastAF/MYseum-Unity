using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragPainting : MonoBehaviour
{
    Vector3 offset;
    float zCoord;
    Rigidbody rb;

    private void OnMouseDown()
    {
        zCoord = Camera.main.WorldToScreenPoint(gameObject.transform.position).z;
        rb = GetComponent<Rigidbody>();
        offset = gameObject.transform.position - getMousePos();
    }

    Vector3 getMousePos()
    {
        Vector3 mousePoint = Input.mousePosition;

        mousePoint.z = zCoord;

        return Camera.main.ScreenToWorldPoint(mousePoint);
    }

    private void OnMouseDrag()
    {
        transform.position = getMousePos() + offset;
        rb.velocity = Vector3.zero;
    }
}
