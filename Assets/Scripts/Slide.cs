using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Slide : MonoBehaviour
{
    private Vector3 down;
    private Vector3 up;
    bool isThere = false;
    float a = -9.18f;

    // Start is called before the first frame update
    void Start()
    {
        if (isThere == false)
        {
            transform.position = new Vector3(2.27f, -9.18f, -7);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (isThere == false)
        {
            while (a < 0.64f)
            {
                transform.position = new Vector3(2.27f, a, -7);
                a = a + 0.01f;
            }
            isThere = true;
        }
    }
}
