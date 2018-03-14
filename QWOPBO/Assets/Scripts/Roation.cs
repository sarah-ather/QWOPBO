using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Roation : MonoBehaviour {

    private string turnInputAxis = "Horizontal";

    public float rotationRate = 360;
    public float moveSpeed = 2;

    #region MonoBehaviour API


    // Update is called once per frame
    void Update()
    {
        float turnAxis = Input.GetAxis(turnInputAxis);

        ApplyInput(turnAxis);
    }

    private void ApplyInput(float turnInput)
    {
        Turn(turnInput);
    }

    private void Turn(float input)
    {
        transform.Rotate(0, input * rotationRate * Time.deltaTime, 0);
    }
    #endregion
}
