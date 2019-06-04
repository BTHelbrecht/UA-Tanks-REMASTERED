using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankData : MonoBehaviour
{
    // player number for futer use
    // forward speed
    // reverse speed
    // turn/rotate speed
    // health of the tank for future use
    // access to rigidbody of game object attached to
    public int t_PlayerNumber;
    public float t_MoveForwardSpeed;
    public float t_MoveReverseSpeed;
    public float t_RotateSpeed;
    public float t_Health;
    public Rigidbody t_Rigidbody;

    //awake
    void Awake()
    {
        t_Rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
