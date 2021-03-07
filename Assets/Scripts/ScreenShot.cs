using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class ScreenShot : MonoBehaviour
{
    //public PictureLayersScript picturelayers;
    int screenshot = 0;
    // Start is called before the first frame update
    void Start()
    {
        //picturelayers = gameObject.GetComponent<PictureLayersScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //for(int i = 0; i <= picturelayers.picturepieces.Count - 1; i++)
            //{
            //    if(picturelayers.picturepieces[i].transform.position.y <= - 6 || picturelayers.picturepieces[i].transform.position.y >= 2)
            //    {
            //        picturelayers.picturepieces[i].GetComponent<SpriteRenderer>().enabled = false;
            //    }
            //}
            ScreenCapture.CaptureScreenshot("ScreenShots/" + DateTime.Now.ToString("MM,dd,yyyy HH,mm") +" Picture" + ".png");
            screenshot++;
            Debug.Log("saved");
        }
    }
}
