using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class FSMTransition 
{
    public FSMDecision decision;
    public FSMState trueState;
    public FSMState falseState;
}