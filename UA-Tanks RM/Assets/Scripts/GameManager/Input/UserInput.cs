using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UserInput : MonoBehaviour
{

    // public float for Y axis
    // public float for X axis
    // public bool to identify if space is pressed
    // public string to place hold for statment
    [HideInInspector] public bool u_Activated;
    [HideInInspector] public string u_Space;
    [HideInInspector] public TankData u_tankData;


    // UPDATE
    void Update()
    {
        // if w is pressed the the tank moves forward
        if (Input.GetKey(KeyCode.W))
        {
            // move the tank forward
            u_tankData.t_MoveDrive.Forward();
            Debug.Log("w");
        }
        // if s is pressed then the tank move in reverse 
        if (Input.GetKey(KeyCode.S))
        {
            // moves the take in reverse
            u_tankData.t_MoveDrive.Reverse();
            Debug.Log("s");
        }
        
        // turn the tank left or right at the same speed
        u_tankData.t_MoveDrive.Turn(Input.GetAxis("Horizontal"));
        

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
