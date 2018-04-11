using UnityEngine;
using UnityEngine.UI;

public class PlayerPunching : MonoBehaviour
{
    public int m_PlayerNumber = 1;              // Used to identify the different players.
    private new Animator animation;
    //private Rigidbody r;

    private bool punchStatus;
    [HideInInspector] public bool punchStatusLeft;
    [HideInInspector] public bool punchStatusRight;

    private void OnEnable()
    {

    }


    private void Start()
    {
        animation = GetComponent<Animator>();
        //r = GetComponent<Rigidbody>();
        animation = GetComponent<Animator>();
    }


    private void Update()
    {
        if (Input.GetButtonDown("Fire1"))
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
        animation.SetBool("Punch Right", punchStatusRight);
    }
}
