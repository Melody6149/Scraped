using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
        if (Input.GetKey(KeyCode.Space))
        {
            ScreenCapture.CaptureScreenshot("ScreenShots/picture" + screenshot + ".png");
            screenshot++;
            Debug.Log("saved");
        }
    }
}
