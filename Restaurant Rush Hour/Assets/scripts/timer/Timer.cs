using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour {

    public float startingTime;

    private Text theText;

    public GameObject Order;
    public GameObject Buttons;

	// Use this for initialization
	void Start () {

        theText = GetComponent<Text> ();
	}
	
	// Update is called once per frame
	void Update () {
        if(startingTime >= 0) {
            startingTime -= Time.deltaTime;
        } else {
            Order.SetActive (false);
            Buttons.SetActive (true);
        }

        if (Input.GetKeyDown (KeyCode.Return)) {
            startingTime = 0;
        }

        theText.text = "" + Mathf.Round (startingTime);
	}
}
