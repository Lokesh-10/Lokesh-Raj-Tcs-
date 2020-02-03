using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{


    public Transform vrCamera;
    public float toggleAngle = 22.0f;
    public float speed = 3.0f;
    public bool moveForward;
    private CharacterController cc;



    // Use this for initialization
    void Start()
    {
        cc = GetComponent<CharacterController>();

    }

    // Update is called once per frame
    void Update()
    {
        if (vrCamera.eulerAngles.x >= toggleAngle && vrCamera.eulerAngles.x < 90f)
        {
            moveForward = true;




        }
        else
        {
            moveForward = false;
        }
        if (moveForward)
        {
            Vector3 forward = vrCamera.TransformDirection(Vector3.left);
            cc.SimpleMove(forward * speed);


        }

    }
   
}

