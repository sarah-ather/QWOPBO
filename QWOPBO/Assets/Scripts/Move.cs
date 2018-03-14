using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour {

    private string moveInputAxis = "Vertical";

    public Animator anim;

    public float moveSpeed = 0.2f;

    #region MonoBehaviour API
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float moveAxis = Input.GetAxis(moveInputAxis);

        ApplyInput(moveAxis);
        if (Input.GetKeyDown("i"))
        {
            anim.CrossFade("Punch", 0.1f);
        }
    }

    private void ApplyInput(float moveInput)
    {
        move(moveInput);

    }

    private void move(float input)
    {
        transform.Translate(Vector3.forward * input * moveSpeed);
    }

    #endregion
}
