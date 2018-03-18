using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AI : MonoBehaviour {
    public float moveSpeed = 3f;
    public float rotSpeet = 100f;
    public NavMeshAgent agent;


    private bool isWoundering;
    private bool isRotatingRight;
    private bool isRotatingLeft;

    // Use this for initialization
    void Start()
    {
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

        //control rotation. not actully being used by the navmesh right now
        if(isRotatingRight == true)
        {
            transform.Rotate(transform.up*Time.deltaTime * rotSpeet);
        }
        if (isRotatingLeft == true)
        {
            transform.Rotate(transform.up * Time.deltaTime * rotSpeet);
        }

        //object is moved by a function call in Wander
    }


    //This is what moves the object
    void mover()
    {
        Vector3 location = new Vector3(Random.Range(-50, 51), 0, Random.Range(-50, 51));
        agent.SetDestination(location);
        Debug.Log(location);
    }

    IEnumerator Wander()
    {
        int rotTime = Random.Range(1, 3);
        int rotateWait = Random.Range(3, 4);
        int rotateLorR = Random.Range(0, 3);
        int walkWait = Random.Range(9, 15);
        int walkTime = Random.Range(9, 15);

        isWoundering = true;

        //controls movment
        yield return new WaitForSeconds(walkWait);
        mover();
        yield return new WaitForSeconds(walkTime);

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

        isWoundering = false;
    }
}

