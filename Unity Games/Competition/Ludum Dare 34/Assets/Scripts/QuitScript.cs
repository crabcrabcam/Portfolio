﻿using UnityEngine;
using System.Collections;

public class QuitScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    public void Quit()
    {
        Application.Quit();
        Debug.Log("Quit the game.");
    }
}
