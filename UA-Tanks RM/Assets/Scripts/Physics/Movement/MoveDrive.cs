using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveDrive : MonoBehaviour
{
    // Move FORWARD
    public void Forward()
    {
        float m_MoveForwardSpeed;
        float m_ForwardY;
        Rigidbody m_Rigidibody;

        m_MoveForwardSpeed = GameManager.instance.tankData.t_MoveForwardSpeed;
        m_ForwardY = GameManager.instance.userInput.u_ForwardY;
        m_Rigidibody = GameManager.instance.tankData.t_Rigidbody;

        // vector move = move forward in y axis by the movement speed in seconds per meter
        // move the posisiton of the rigid body by the current position + the new vector move
        Vector3 movement = transform.forward * m_ForwardY * m_MoveForwardSpeed * Time.deltaTime;
        m_Rigidibody.MovePosition(m_Rigidibody.position + movement);
    }

    // Move REVERSE
    public void Reverse()
    {
        float m_MoveReverseSpeed;
        float m_ReverseY;
        Rigidbody m_Rigidibody;

        m_MoveReverseSpeed = GameManager.instance.tankData.t_MoveReverseSpeed;
        m_ReverseY = GameManager.instance.userInput.u_ReverseY;
        m_Rigidibody = GameManager.instance.tankData.t_Rigidbody;

        // vector move = move neg.forward in y axis by the movement speed in seconds per meter
        // move the posisiton of the rigid body by the current position + the new vector move
        Vector3 movement = -transform.forward * m_ReverseY * m_MoveReverseSpeed * Time.deltaTime;
        m_Rigidibody.MovePosition(m_Rigidibody.position + movement);
    }

    // Rotate TURN
    public void Turn()
    {
        float m_RotateSpeed;
        float m_RatateX;
        Rigidbody m_Rigidibody;

        m_RotateSpeed = GameManager.instance.tankData.t_RotateSpeed;
        m_RatateX = GameManager.instance.userInput.u_RotateX;
        m_Rigidibody = GameManager.instance.tankData.t_Rigidbody;

        // Adjust the rotation of the tank based on the player's input.
        float m_turn = m_RatateX * m_RotateSpeed * Time.deltaTime;

        Quaternion qm_Rotation = Quaternion.Euler(0f, m_turn, 0f);

        m_Rigidibody.MoveRotation(m_Rigidibody.rotation * qm_Rotation);
    }
}
