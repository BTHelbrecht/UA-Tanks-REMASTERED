using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersonalityPatrol : EnemyInput
{
    // list of Waypoints spwaned by GAME MANAGER
    


    public void Start()
    {
        //TODO: get waypoints from game manger
    }

    private void Update()
    {
        if (p_CurrentDirective == p_Directive.PatrolRoutine)
        {
            PatrolModeRoutine();

            //isBlocked(); 

            if(p_CurrentAwareness == p_Awarness.SeeObsturcion)
            {
                AvoidMode();
            }
            else
            {
                RotateMode();
                MoveMode();
            }

           

        }
        else if(p_CurrentDirective == p_Directive.Chase)
        {
            // move to player
        }
    }

}
