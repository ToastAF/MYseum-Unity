using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestDrag : MonoBehaviour
{
    public LayerMask wall, wall2, floor;

    private void OnMouseDrag()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit, 100, wall))
        {
            transform.position = hit.point;
            transform.rotation = Quaternion.identity;            
        }
        if (Physics.Raycast(ray, out hit, 100, wall2))
        {
            transform.position = hit.point;
            transform.eulerAngles = new Vector3(0, 90, 0);
        }
        if (Physics.Raycast(ray, out hit, 100, floor))
        {
            transform.position = hit.point;
            transform.Rotate(0, 90*Time.deltaTime, 0);
        }
    }
}
