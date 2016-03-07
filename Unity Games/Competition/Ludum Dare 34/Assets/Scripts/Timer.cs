using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.IO;
using System;

public class Timer : MonoBehaviour {

    public float levelTime;
    public double levelTimeDouble;

    
    private Text theText;

	// Use this for initialization
	void Start () {
        theText = GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {


        levelTime += Time.deltaTime;

        theText.text = "" + Mathf.Round(levelTime);
	}


}
