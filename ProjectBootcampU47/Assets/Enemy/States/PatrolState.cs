using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PatrolState : BaseState
{
    //track which waypoint we are currently targeting
    public int waypointIndex;
    public override void Enter()
    {

    }
    public override void Perform()
    {
        PatrolCycle();
    }
    public override void Exit()
    {

    }

    public void PatrolCycle()
    {
        //implement our patrol logic.
        if (enemy.Agent.remainingDistance < 0.2f)
        {
            if (waypointIndex < enemy.path.waypoints.Count - 1)
                waypointIndex++;

            else
                enemy.Agent.SetDestination(enemy.path.waypoints[waypointIndex].position);
        }
    }
}
