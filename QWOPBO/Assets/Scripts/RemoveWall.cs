using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemoveWall : MonoBehaviour {
    public Object Barrier;
    public GameObject lockTrap;
    public GameObject lockTrapUnlocked;
    private bool flag = false;
    private bool lockChange = false;

    private void Update()
    {
        if (flag == true && lockChange == false)
        {
            if (lockTrapUnlocked!=null)
            Instantiate(lockTrapUnlocked, lockTrap.transform.position, lockTrap.transform.rotation);
            Destroy(lockTrap);
            lockChange = true;
        }
    }

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
