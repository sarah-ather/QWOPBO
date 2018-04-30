using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class timer : MonoBehaviour {
    public string levelToLoad;
    private float timerv = 70f;
    private Text timerSeconds;
  
	// Use this for initialization
	void Start () {
        timerSeconds = GetComponent<Text>();
		
	}
	
	// Update is called once per frame
	void Update () {
        timerv -= Time.deltaTime;
        timerSeconds.text = timerv.ToString("f0");
        if(timerv <= 0)
        {
			SceneManager.LoadScene("End");
        }
	}
}
