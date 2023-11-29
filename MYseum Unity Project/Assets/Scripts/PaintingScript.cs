using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaintingScript : MonoBehaviour
{
    //Vi vælger de to vægge og gulvet til at have 3 forskellige lag
    public LayerMask wall, wall2, floor;

    public bool isClicked, isViewed;
    public GameObject checkButton, infoText, linkedCamera;
    SpawnMaleri scriptHandler;

    GameObject closeButton;
    GameObject canvas;
    float h, w;

    private void Start()
    {
        isClicked = false;
        isViewed = false;
        if(linkedCamera != null)
        {
            linkedCamera.SetActive(false);
        }
        scriptHandler = GameObject.FindGameObjectWithTag("GameController").GetComponent<SpawnMaleri>();
        canvas = GameObject.FindGameObjectWithTag("Canvas");
        h = canvas.GetComponent<RectTransform>().rect.height;
        w = canvas.GetComponent<RectTransform>().rect.width;
    }

    //OnMouseDrag kaldes, når man har musen over objektets collider, holder musen inde og ikke slipper
    private void OnMouseDrag()
    {
        if(isClicked == true)
        {
            //Der bliver kastet en ray fra kameraet ind i 3D verdenen gennem musens position på skærmen
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit; //En variabel der holder information om, hvor en ray rammer

            //Her tjekker vi for, om vores ray rammmer noget
            if (Physics.Raycast(ray, out hit, 100, wall)) //De to første parametre er vores Ray og RaycastHit. Tallet '100' er hvor langt i Unity-units den tjekker, og 'wall' er det lag vi tjekker på
            {
                //Siden scriptet sidder på hvert GameObject, sætter vi bare transform.position(dens position) til at være lig med hit.point,
                //som er der hvor vores Ray fra kamera til 3D verden gennem mus rammer objekter der er på 'wall' laget
                transform.position = hit.point;
                transform.rotation = Quaternion.identity; //Rotation reset           
            }
            if (Physics.Raycast(ray, out hit, 100, wall2))
            {
                transform.position = hit.point;
                transform.eulerAngles = new Vector3(0, 90, 0); //Drejet rotation fordi væggen vender den anden vej
            }
            if (Physics.Raycast(ray, out hit, 100, floor))
            {
                transform.position = new Vector3(hit.point.x, hit.point.y+(transform.localScale.y/2), hit.point.z);
                if (Input.GetKey(KeyCode.R))
                {
                    transform.Rotate(0, 90*Time.deltaTime, 0); //Den her er bare for sjov. Den drejer objektet, hvis man holder den nede på gulvet og holder R nede :)
                }
            }
        }
    }

    private void OnMouseDown()
    {
        if(scriptHandler.editMode == false && isViewed == false)
        {
            scriptHandler.editMode = true;
            if (isClicked == false)
            {
                isClicked = true;
                closeButton = Instantiate(checkButton, canvas.transform);
                closeButton.GetComponent<RectTransform>().anchoredPosition = new Vector2(-w*0.43f, h*0.43f); //(-410, 190)
                closeButton.GetComponent<CheckButton>().painting = gameObject;
            }
        }

    }

    private void OnMouseOver()
    {
        
        if (Input.GetMouseButtonDown(1))
        {
            if(linkedCamera != null && infoText != null)
            {
                if(isViewed == false && isClicked == false)
                {
                    linkedCamera.SetActive(true);
                    isViewed = true;
                    GameObject tempText = Instantiate(infoText, canvas.transform);
                    closeButton = Instantiate(checkButton, canvas.transform);
                    closeButton.GetComponent<RectTransform>().anchoredPosition = new Vector2(-w * 0.43f, h * 0.43f); //(-410, 190)
                    tempText.GetComponent<RectTransform>().anchoredPosition = new Vector2(w*0.25f, h*0.25f);
                    closeButton.GetComponent<CheckButton>().painting = gameObject;
                    closeButton.GetComponent<CheckButton>().infoText = tempText;
                    closeButton.GetComponent<CheckButton>().paintingCam = linkedCamera;
                }
            }
        }
    }
}
