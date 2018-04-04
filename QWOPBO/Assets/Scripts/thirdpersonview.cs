using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class thirdpersonview : MonoBehaviour {

    public GameObject target = null;
    public bool orbitY = false;

    private Vector3 positionOffset = Vector3.zero;

	// Use this for initialization
	private void Start () {
        positionOffset = transform.position - target.transform.position;
		
	}
	
	// Update is called once per frame
	void Update () {
        if(target != null)
        {
            transform.LookAt(target.transform);
            if (orbitY)
                transform.RotateAround(target.transform.position, Vector3.up, Time.deltaTime * 15);

            transform.position = target.transform.position + positionOffset;
        }
		
	}
}
