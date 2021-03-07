using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Slide : MonoBehaviour
{
    private Vector3 down;
    private Vector3 up;
    bool isThere = false;
    float a = -14f;

    // Start is called before the first frame update
    void Start()
    {
        if (isThere == false)
        {
            transform.position = new Vector3(7.41f, -14f, 27.01f);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (isThere == false)
        {
            while (a < -14f)
            {
                transform.position = new Vector3(7.41f, a, 27.01f);
                a = a + 0.01f;
            }
            isThere = true;
        }
    }
}
