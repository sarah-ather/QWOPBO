using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPunching : MonoBehaviour {

    public int m_PlayerNumber = 2;              // Used to identify the different players.

    public new Animator animation;
    public Rigidbody r;

    private bool punchStatus;
    [HideInInspector] public bool punchStatusLeft;
    [HideInInspector] public bool punchStatusRight;

    private void OnEnable()
    {

    }


    private void Start()
    {
        animation = GetComponent<Animator>();
        r = GetComponent<Rigidbody>();
        animation = GetComponent<Animator>();
    }


    private void Update()
    {
        /*if (Input.GetButtonDown("Fire1"))
        {
            punchStatusLeft = true;
        }
        else if (Input.GetButtonDown("Fire2"))
        {
            punchStatusRight = true;
        }
        else
        {
            punchStatusLeft = false;
            punchStatusRight = false;
        }
        if (Input.GetKeyDown("u"))
        {
            animation.SetTrigger("Punch Left Trigger");
        }
        if (Input.GetKeyDown("i"))
        {
            animation.SetTrigger("Punch Right Trigger");
        }

        animation.SetBool("Punch Left", punchStatusLeft);
        animation.SetBool("Punch Right", punchStatusRight);*/
    }

    public void Punch()
    {
        //print("Punch");
        animation.SetTrigger("Punch Right");
        animation.SetTrigger("Punch Left");
    }
}
