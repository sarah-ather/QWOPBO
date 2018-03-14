using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour {

    private string moveInputAxis = "Vertical";


    public float moveSpeed = 2;

    #region MonoBehaviour API


    // Update is called once per frame
    void Update()
    {
        float moveAxis = Input.GetAxis(moveInputAxis);


        ApplyInput(moveAxis);
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
