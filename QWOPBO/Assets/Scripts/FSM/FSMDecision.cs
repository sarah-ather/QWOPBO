using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class FSMDecision : ScriptableObject
{
    public abstract bool Decide (FSMStateController controller);
}