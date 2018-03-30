using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WonderAI : MonoBehaviour {

	public float moveSpeed = 3f;
	public float rotSpeet = 100f;
	public UnityEngine.AI.NavMeshAgent agent;


	private bool isWoundering;
	private bool isRotatingRight;
	private bool isRotatingLeft;
	private int counter;

	// Use this for initialization
	void Start()
	{
		counter = 1;
		isWoundering = false;
		isRotatingRight = false;
		isRotatingLeft = false;
	}

	// Update is called once per frame
	void Update () {

		if(isWoundering == false)
		{
			StartCoroutine(Wander());
		}

		/*
		//control rotation. not actully being used by the navmesh right now
		if(isRotatingRight == true)
		{
			transform.Rotate(transform.up*Time.deltaTime * rotSpeet);
		}
		if (isRotatingLeft == true)
		{
			transform.Rotate(transform.up * Time.deltaTime * rotSpeet);
		}
		*/
		//object is moved by a function call in Wander
	}


	//This is what moves the object
	void mover()
	{
		Vector3 location;

		if (counter == 1) {
			location =new Vector3((-36), 0, (-152));
			counter++;
		} else if (counter == 2) {
			location = new Vector3((-36), 0, (-122));
			counter++;
		} else if (counter == 3) {
			location = new Vector3((-22), 0, (-122));
			counter++;
		} else {
			location = new Vector3((-22), 0, (-152));
			counter = 1;
		}



		agent.SetDestination(location);
		Debug.Log(location);
	}

	IEnumerator Wander()
	{
		//int rotTime = Random.Range(1, 3);
		//int rotateWait = Random.Range(3, 4);
		//int rotateLorR = Random.Range(0, 3);
		int walkWait = 2;
		int walkTime = 5;

		isWoundering = true;

		//controls movment
		yield return new WaitForSeconds(walkWait);
		if (counter == 2 || counter == 4) {
			walkTime = 8;
		} 
		else {
			walkTime = 5;
		}
		mover();

		yield return new WaitForSeconds(walkTime);
		/*
		//controls rotation. this block of code is not used right now
		//possibly could be used for AI when they see player
		yield return new WaitForSeconds(rotateWait);
		if(rotateLorR == 1)
		{
			isRotatingRight = true;
			yield return new WaitForSeconds(rotTime);
			isRotatingRight = false;
		}
		if (rotateLorR == 2)
		{
			isRotatingLeft = true;
			yield return new WaitForSeconds(rotTime);
			isRotatingLeft = false;
		}
		*/
		isWoundering = false;
	}
}
