using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CameraController : MonoBehaviour {

    public Transform target;
    public float CameraSpeed = 0.125f;

    public Vector3 offset;

    void Start()
    {
        offset = transform.position - target.transform.position;
    }



	void LateUpdate ()
    {

        Vector3 postion = target.position + offset;
        Vector3 smoothedPostion = Vector3.Lerp(transform.position, postion, CameraSpeed);

        
        transform.position = postion;
        transform.LookAt(target);


    }

}
