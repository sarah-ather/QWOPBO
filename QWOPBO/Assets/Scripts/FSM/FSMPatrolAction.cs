using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu (menuName = "Scripts/FSM/FSMActions/Patrol")]
public class FSMPatrolAction : FSMAction
{
    public override void Act(FSMStateController controller)
    {
        Patrol (controller);
    }

    private void Patrol(FSMStateController controller)
    {
        controller.navMeshAgent.destination = controller.wayPointList [controller.nextWayPoint].position;
        controller.navMeshAgent.isStopped = false;

        if (controller.navMeshAgent.remainingDistance <= controller.navMeshAgent.stoppingDistance && !controller.navMeshAgent.pathPending) 
        {
            controller.nextWayPoint = (controller.nextWayPoint + 1) % controller.wayPointList.Count;
        }
    }
}