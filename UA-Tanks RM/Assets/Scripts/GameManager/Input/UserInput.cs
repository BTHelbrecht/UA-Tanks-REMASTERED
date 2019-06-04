using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UserInput : MonoBehaviour
{
    // public float for Y axis
    // public float for X axis
    // public bool to identify if space is pressed
    // public string to place hold for statment
    [HideInInspector] public float u_ForwardY;
    [HideInInspector] public float u_ReverseY;
    [HideInInspector] public float u_RotateX;
    [HideInInspector] public bool u_Activated;
    [HideInInspector] public string u_Space;

    // UPDATE
    void Update()
    {
        // Forward axis is Y 
        // Reverse axis is Y
        // Rotate axis is x
        float u_FowardY = Input.GetAxis("Vertical");
        float u_ReverseY = Input.GetAxis("Vertical");
        float u_RatateX = Input.GetAxis("Horizontal");

        // if w is pressed the the tank moves forward
        if (Input.GetButton("Forward"))
        {
            // move the tank forward
            GameManager.instance.moveDrive.Forward();
            Debug.Log("w");
        }
        // if s is pressed then the tank move in reverse 
        if (Input.GetButton("Reverse"))
        {
            // moves the take in reverse
            GameManager.instance.moveDrive.Reverse();
            Debug.Log("s");
        }
        if (Input.GetButton("Horizontal"))
        {
            // turn the tank left or right at the same speed
            GameManager.instance.moveDrive.Turn();
            Debug.Log("turn");
        }

        /*
        if (Input.GetButtonDown(u_Space) && !u_Activated)
        {
            u_Activated = true;
        }
        else
        {
            u_Activated = false;
        }
        */
    }
}
