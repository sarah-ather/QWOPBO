using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu (menuName = "Scripts/FSM/FSMDecisions/Scan")]
public class FSMScanDecision : FSMDecision 
{
    public override bool Decide (FSMStateController controller)
    {
        bool noEnemyInSight = Scan (controller);
        return noEnemyInSight;
    }

    private bool Scan(FSMStateController controller)
    {
        controller.navMeshAgent.Stop ();
        controller.transform.Rotate (0, controller.enemyStats.searchingTurnSpeed * Time.deltaTime, 0);
        return controller.CheckIfCountDownElapsed (controller.enemyStats.searchDuration);
    }
}