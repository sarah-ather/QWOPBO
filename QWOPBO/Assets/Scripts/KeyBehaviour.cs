using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyBehaviour : MonoBehaviour {
    public RemoveWall flag;
    public Object Key_Object;
    public GameObject ItemNotification;

    private void OnCollisionEnter(Collision collision)
    {
        flag.setFlag();
        Destroy(Key_Object);
        ItemNotification.SetActive(true);
    }
}
