using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyBehaviour : MonoBehaviour {
    public RemoveWall flag;
    public Object Key_Object;
    private bool status = false;

    private void OnCollisionEnter(Collision collision)
    {
        flag.setFlag();
        Destroy(Key_Object);
    }
}
