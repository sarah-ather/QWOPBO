using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CharecterController : MonoBehaviour {

    public Animator a;
    public Rigidbody r;
    public float sprint;
	public float frontRoll;

    private float H;
    private float V;
    private float speedBoost;

    public float rotationRate = 60;
    public float moveSpeed = 10;


    // Use this for initialization
    void Start () {
        a = GetComponent<Animator>();
        r = GetComponent<Rigidbody>();
        speedBoost = 1.0f;


    }

    // Update is called once per frame
    void Update () {
        H = Input.GetAxis("Horizontal");
        V = Input.GetAxis("Vertical");
        Running();
		FRoll ();

        Turn(H);


        if (Input.GetKeyUp(KeyCode.W) && Input.GetKeyUp(KeyCode.S))
        {
            r.Sleep();
            r.velocity = Vector3.zero;
            r.angularVelocity = Vector3.zero;
           


        }
        else
        {
            Move(V);
            GetComponent<AudioSource>().Play();

        }

        /*

        float movex = H * 20f * Time.deltaTime;
        float movez = V * 50f * Time.deltaTime;

        r.velocity = new Vector3(movex, 0f, movez);
        */
    }

    void FixedUpdate()
    {
        a.SetFloat("walk", V);
        //a.SetFloat("turn", H);
        a.SetFloat("run", sprint);
		a.SetFloat ("fRoll", frontRoll);

    }

    void Running()
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

	void FRoll()
	{
		if (Input.GetKey("space"))
		{
			frontRoll = 1.0f;


		}
		if (Input.GetKeyUp("space"))
		{
			frontRoll = 0.0f;
		}
	}
		

    private void Move(float input)
    {
        r.AddForce(transform.forward * (input * speedBoost) * moveSpeed);
    }

    private void Turn(float input)
    {
        transform.Rotate(0, input * rotationRate * Time.deltaTime, 0);
    }

	private void OnCollisionEnter(Collision collision)
	{
		Debug.Log ("trap");
		if(collision.gameObject.name == "FSM1"){
			SceneManager.LoadScene("texturedmap Fight Scene resized");
		}
		if(collision.gameObject.name == "LockTrap"){
			SceneManager.LoadScene("texturedmap Fight Scene resized");
		}
		if(collision.gameObject.name == "Trap"){
			
			SceneManager.LoadScene("texturedmap Fight Scene resized");
		}
        if (collision.gameObject.name == "Fan(Clone)")
        {
            SceneManager.LoadScene("texturedmap Fight Scene resized");
        }
        if (collision.gameObject.name == "Fan 2(Clone)")
        {
            SceneManager.LoadScene("texturedmap Fight Scene resized");
        }
    }
}
