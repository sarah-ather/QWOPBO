using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu (menuName = "Scripts/FSM/FSMActions/Chase")]
public class FSMChaseAction : FSMAction 
{
    public override void Act (FSMStateController controller)
    {
        Chase (controller); 
    }

    private void Chase(FSMStateController controller)
    {
        controller.navMeshAgent.destination = controller.chaseTarget.position;
        controller.navMeshAgent.Resume ();
    }
}