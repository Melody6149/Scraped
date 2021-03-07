using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class ScreenShot : MonoBehaviour
{
    int screenshot = 0;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            ScreenCapture.CaptureScreenshot("ScreenShots/" + DateTime.Now.ToString("MM,dd,yyyy HH/mm") +" Picture" + ".png");
            screenshot++;
            Debug.Log("saved");
        }
    }
}
