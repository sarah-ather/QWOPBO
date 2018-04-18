using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class ShockwaveScript : MonoBehaviour
{
    void Update()
    {
        transform.localScale += new Vector3(0.01f, 0.01f, 0.01f);
        if (transform.localScale.x > 0.5f)
        {
            transform.localScale = new Vector3(0.01f, 0.01f, 0.01f);
        }
    }
}