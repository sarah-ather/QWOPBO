using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class FSM_Script : MonoBehaviour
{
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
    void Update()
    {

        if (isWoundering == false)
        {
            StartCoroutine(Wander());
        }
    }


    //This is what moves the object
    void mover()
    {
        int counter = 0;
        //First Corner Location
        Vector3 location = new Vector3((-22), 0, (-152));
        agent.SetDestination(location);
        Wander();
        counter++;
        //Move to object so it moves between 4 corners
        for (int i = 0; i < 0; i++)
        {
            if (counter == 1)
            {
                //Second Corner Location
                Vector3 location2 = new Vector3((-36), 0, (-152));
                agent.SetDestination(location2);
                Wander();
                counter++;
            }
            if (counter == 2)
            {
                //Third Corner Location
                Vector3 location3 = new Vector3((-36), 0, (-122));
                agent.SetDestination(location3);
                Wander();
                counter++;
            }
            if (counter == 3)
            {
                //Fourth Corner Location
                Vector3 location4 = new Vector3((-10), 0, (-122));
                agent.SetDestination(location4);
                Wander();
                counter++;

            }

        }
        Debug.Log(location);
    }

    IEnumerator Wander()
    {
        int rotateWait = 3;
        int walkWait = 10;
        // int walkTime = 10;

        isWoundering = true;

        //controls movment
        yield return new WaitForSeconds(walkWait);
        mover();
        // yield return new WaitForSeconds(walkTime);

        //controls rotation. this block of code is not used right now
        //possibly could be used for AI when they see player
        yield return new WaitForSeconds(rotateWait);



        isWoundering = false;
    }
}
