﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager_Cooking : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKeyDown(KeyCode.Return)) {
            SceneManager.LoadSceneAsync ("PlateScene");
        }
        if (Input.GetKeyDown (KeyCode.Escape)) {
            SceneManager.LoadSceneAsync ("main");
        }
	}

    public void QuitButton () {
        Application.Quit ();
    }
}
