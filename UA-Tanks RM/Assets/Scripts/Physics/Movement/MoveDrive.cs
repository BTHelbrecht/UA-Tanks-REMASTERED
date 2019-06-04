using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveDrive : MonoBehaviour
{
    public TankData m_tankData;

    private void Start()
    {
        m_tankData = GetComponent<TankData>();
    }

    // Move FORWARD
    public void Forward()
    {
        float m_MoveForwardSpeed;
        Rigidbody m_Rigidibody;

        m_MoveForwardSpeed = m_tankData.t_MoveForwardSpeed;
        m_Rigidibody = m_tankData.t_Rigidbody;

        // vector move = move forward in y axis by the movement speed in seconds per meter
        // move the posisiton of the rigid body by the current position + the new vector move
        Vector3 movement = transform.forward * m_MoveForwardSpeed * Time.deltaTime;
        m_Rigidibody.MovePosition(m_Rigidibody.position + movement);
    }

    // Move REVERSE
    public void Reverse()
    {
        float m_MoveReverseSpeed;
        Rigidbody m_Rigidibody;

        m_MoveReverseSpeed = m_tankData.t_MoveReverseSpeed;
        m_Rigidibody = m_tankData.t_Rigidbody;

        // vector move = move neg.forward in y axis by the movement speed in seconds per meter
        // move the posisiton of the rigid body by the current position + the new vector move
        Vector3 movement = -transform.forward * m_MoveReverseSpeed * Time.deltaTime;
        m_Rigidibody.MovePosition(m_Rigidibody.position + movement);
    }

    // Rotate TURN
    public void Turn(float m_RotateX)
    {
        float m_RotateSpeed;
        Rigidbody m_Rigidibody;

        m_RotateSpeed = m_tankData.t_RotateSpeed;
        m_Rigidibody = m_tankData.t_Rigidbody;

        // Adjust the rotation of the tank based on the player's input.
        float m_turn = m_RotateX * m_RotateSpeed * Time.deltaTime;

        Quaternion qm_Rotation = Quaternion.Euler(0f, m_turn, 0f);

        m_Rigidibody.MoveRotation(m_Rigidibody.rotation * qm_Rotation);
    }
}
