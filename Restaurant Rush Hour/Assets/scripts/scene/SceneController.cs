using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour {

    // Use this for initialization
    void Start () {

    }

    // Update is called once per frame
    void Update () {
        ChangeScene ();
    }

    public void ChangeScene () {
        if (Input.GetKeyDown (KeyCode.Return)) {
            SceneManager.LoadSceneAsync ("RegisterScene");
        }
    }
}
