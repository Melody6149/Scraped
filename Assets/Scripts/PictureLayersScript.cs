using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PictureLayersScript : MonoBehaviour
{
    private int _zTransform;
    [HideInInspector]
    public float oldZValue; // stores the object moved to the fronts z value
    public List<GameObject> picturepieces; // used to store references to each piece
    // Start is called before the first frame update
    void Start()
    {
        _zTransform = 0;
        for (int i = 0; i <= picturepieces.Capacity - 1; i++)
        {
           picturepieces[i].transform.position = new Vector3(picturepieces[i].transform.position.x, picturepieces[i].transform.position.y, _zTransform);
            _zTransform++;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangeOtherPictureLayers()
    {
        //_zTransform = 1;
        for (int i = 0; i <= picturepieces.Capacity - 1; i++) 
        {
            if (picturepieces[i].transform.position.z < oldZValue && picturepieces[i].GetComponent<PictureGrabingScript>().isGrabed == false)
            {
                picturepieces[i].transform.position = new Vector3(picturepieces[i].transform.position.x, picturepieces[i].transform.position.y,picturepieces[i].transform.position.z + 1);
                //_zTransform++;
            }
        }
    }
}
