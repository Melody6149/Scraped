using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PictureGrabingScript : MonoBehaviour
{
    private float _distanceToScreen;
    private Vector3 _move;
    public GameObject Layers;
    [HideInInspector]
    public bool isGrabed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    }
    void OnMouseDrag() // this is called as long as the left mouse button is held down on the object
    {
        _distanceToScreen = Camera.main.WorldToScreenPoint(gameObject.transform.position).z;
        _move = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, _distanceToScreen));
        transform.position = new Vector3(_move.x, _move.y,0 ); // moves the object to the mouse

        if (isGrabed == true)
        {
            gameObject.transform.Rotate(0, 0, Input.GetAxis("Mouse ScrollWheel"));
        }
    }
    void OnMouseDown()
    {
        isGrabed = true;
        Layers.GetComponent<PictureLayersScript>().oldZValue = transform.position.z;
        transform.position = new Vector3(transform.position.x, transform.position.y, 0);
        Layers.GetComponent<PictureLayersScript>().ChangeOtherPictureLayers();

        if(isGrabed == true)
        {
            gameObject.transform.Rotate(0, 0, Input.GetAxis("Mouse ScrollWheel"));
        }
    }
    private void OnMouseUp()
    {
        isGrabed = false;
    }
}