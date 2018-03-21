using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemoveWall : MonoBehaviour {
    public Object Barrier;
    private bool flag = false;

    private void OnCollisionEnter(Collision collision)
    {
        if (flag == true)
        {
            Destroy(Barrier);
        }
    }

    public void setFlag()
    {
        flag = true;
    }

}
