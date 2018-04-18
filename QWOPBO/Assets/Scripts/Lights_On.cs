using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lights_On : MonoBehaviour {
    private WaitForSeconds m_StartWait;         // Used to have a delay whilst the round starts.
    public float m_StartDelay = 3f;             // The delay between the start of RoundStarting and RoundPlaying phases.
    //public AudioClip audio;
    //public float m_EndDelay = 3f;               // The delay between the end of RoundPlaying and RoundEnding phases.

    // Use this for initialization
    void Start () {
        m_StartWait = new WaitForSeconds(m_StartDelay);
        Lights();     
    }

    void Lights()
    {
        StartCoroutine(Wait());
    }

    private IEnumerator Wait()
    {
        yield return m_StartWait;
        GetComponent<AudioSource>().Play();
        GetComponent<Light>().enabled = true;
    }
}
