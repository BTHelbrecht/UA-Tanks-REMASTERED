using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersonalityPatrol : EnemyInput
{
    // list of Waypoints spwaned by GAME MANAGER
    public List<GameManager> p_WayPoints;
    public bool p_Player;
    public int p_WayPointNumber;
    public float p_DistanceToWayPoint;
    public bool p_Chase;

    private void Update()
    {
        if(p_Chase == !p_Player)
        {
            // randomized way point select
            // rotate and move to it
        }
        if(p_Chase == p_Player)
        {
            // Chase player
        }
    }

}
