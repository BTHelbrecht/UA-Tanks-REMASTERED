using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyInput : MonoBehaviour
{
    public TankData e_tankData;
    public Transform[] e_WayPoints;
    public float e_DistanceToWayPoint;
    public int e_IndexOfWayPoint;


    public enum p_Directive
    {
        PatrolRoutine, PatrolRandom, Avoid, Chase, Move, Rotate
    }
    public p_Directive p_CurrentDirective;

    public enum p_Awarness
    {
        SeeObsturcion, SeePlayer, SeeEnemies, SeeNothing,
        NearWayPoint
    }
    public p_Awarness p_CurrentAwareness;



    public void MoveMode()
    {
        e_tankData.t_MoveDrive.Forward();
    }

    public void RotateMode()
    {
      //  e_tankData.t_MoveDrive.RotateTorward(Transform m_Target);
    }

    public void IdleMode()
    {

    }

    public bool PatrolModeRoutine()
    {
        if (Vector3.Distance(e_WayPoints[e_IndexOfWayPoint].transform.position, transform.position) < e_DistanceToWayPoint)
        {
            e_IndexOfWayPoint++;
            if (e_IndexOfWayPoint >= e_WayPoints.Length)
            {
                e_IndexOfWayPoint = 0;
            }
        }
        return false;
    }

    public void PatrolModeRandom()
    {

    }

    public void ChaseMode()
    {

    }

    public void AvoidMode()
    {

    }

   /* public bool isBlocked()
    {
        if(Physics.Raycast(pawn.tf.posistion, pawn.tf.forward, feelerDistance))
        {
            return true;
        }
        return false;
    }

    public bool isNear()
    {
       
        
    }*/
}
