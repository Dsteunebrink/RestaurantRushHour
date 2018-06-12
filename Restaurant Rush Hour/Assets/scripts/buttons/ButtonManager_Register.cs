using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonManager_Register : MonoBehaviour {

    public static ButtonManager_Register instance;

    [SerializeField]
    public List<DishType> dishTypes;

    [System.Serializable]
    public class DishType {
        public string name;
        public GameObject prefab;
        public bool clicked;
        public Button button;

        public void setDone () {
            this.clicked = true;
        }
    }

    private RandomOrder order;

    // Use this for initialization
    void Start () {
        instance = this;
        order = GameObject.FindGameObjectWithTag ("RandomOrder").GetComponent<RandomOrder> ();

        foreach (DishType dish in dishTypes) {
            dish.button.onClick.AddListener (dish.setDone);
        }
	}
	
	// Update is called once per frame
	void Update () {

        bool isDone = true;
        foreach (DishType dish in dishTypes) {
            if (!dish.clicked) {
                isDone = false;
                break;
            }
        }

        if (isDone) {
            SceneManager.LoadSceneAsync ("StoveScene");
        }
        //Todo check wrong buttons

        if (Input.GetKeyDown (KeyCode.Escape)) {
            SceneManager.LoadSceneAsync ("main");
        }
    }

    public void QuitButton () {
        Application.Quit ();
    }
}
