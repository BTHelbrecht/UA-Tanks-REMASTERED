using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyInput : MonoBehaviour
{
    public TankData e_tankData;
   

    public void UseMove()
    {
        e_tankData.t_MoveDrive.Forward();
    }




}
