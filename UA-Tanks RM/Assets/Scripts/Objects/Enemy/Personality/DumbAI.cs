using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DumbAI : AIController
{
    private void Update()
    {
        a_tankData.t_MoveDrive.Forward();
    }
}
