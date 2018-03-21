using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharecterControllerBoxer : MonoBehaviour {

    public Animator a;
    public Rigidbody r;

    private float H;
    private float V;
    private float speedBoost;
    private bool punchStatus;

    public float rotationRate = 60;
    public float moveSpeed = 10;


    // Use this for initialization
    void Start () {
        a = GetComponent<Animator>();
        r = GetComponent<Rigidbody>();
        //speedBoost = 1.0f;
        punchStatus = false;

    }
	
	// Update is called once per frame
	void Update () {
        Punch();
        a.SetBool("Punch", punchStatus);
        //H = Input.GetAxis("Horizontal");
        //V = Input.GetAxis("Vertical");
        //Running();

        //Turn(H);


        /*if (Input.GetKeyUp(KeyCode.W) && Input.GetKeyUp(KeyCode.S))
        {
            r.Sleep();
            r.velocity = Vector3.zero;
            r.angularVelocity = Vector3.zero;
            
        }
        else
        {
            Move(V);
        }*/

        /*

        float movex = H * 20f * Time.deltaTime;
        float movez = V * 50f * Time.deltaTime;

        r.velocity = new Vector3(movex, 0f, movez);
        */
    }

    /*void FixedUpdate()
    {
        //a.SetFloat("walk", V);
        //a.SetFloat("turn", H);
        //a.SetFloat("run", sprint);
        a.SetBool("Punch", punchStatus);

    }*/

    void Punch()
    {
        if (Input.GetButton("Fire1"))
        {
            punchStatus = true;

        }
        else
        {
            punchStatus = false;
        }
    }

    /*void Running()
    {
        if (Input.GetButton("Fire1"))
        {
            sprint = 1.0f;
            speedBoost = 1.5f;

        }
        else
        {
            sprint = 0.0f;
            speedBoost = 1.0f;
        }
    }

    private void Move(float input)
    {
        r.AddForce(transform.forward * (input * speedBoost) * moveSpeed);
    }

    private void Turn(float input)
    {
        transform.Rotate(0, input * rotationRate * Time.deltaTime, 0);
    }*/
}
