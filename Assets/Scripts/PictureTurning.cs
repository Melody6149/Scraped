using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PictureTurning : MonoBehaviour
{
    public CharacterController turning;

    bool turnRight = false;
    bool turnLeft = false;
    private GameObject cube1;
    public float xAngle, yAngle, zAngle;

    Vector3 playerTurn;

    // Start is called before the first frame update
    void Start()
    {
        cube1.transform.Rotate(90.0f, 0.0f, 0.0f, Space.Self);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("Mouse ScrollWheel Right"))
        {
            turnRight = true;
            yAngle++;
            playerTurn.Set(xAngle, yAngle, zAngle);
            cube1.transform.Rotate(0.0f, yAngle, 0.0f, Space.Self);
        }
        if (Input.GetKeyDown("Mouse ScrollWheel Left"))
        {
            turnLeft = true;
            yAngle--;
            playerTurn.Set(xAngle, yAngle, zAngle);
            cube1.transform.Rotate(0.0f, yAngle, 0.0f, Space.Self);
        }
    }

    void FixedUpdate()
    {
        cube1.transform.Rotate(xAngle, yAngle, zAngle, Space.Self);
        turning.Move(playerTurn);
    }
}
