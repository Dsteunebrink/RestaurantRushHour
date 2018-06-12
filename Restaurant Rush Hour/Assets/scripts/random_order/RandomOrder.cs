using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomOrder : MonoBehaviour {

    [SerializeField]
    private Transform[] pos;

    public List<ButtonManager_Register.DishType> orderedDishes;

    void Start () {

        Random_Order ();
    }

    // Update is called once per frame
    void Update () {
    }

    private void Random_Order () {
        int orderSize = Random.Range (1, ButtonManager_Register.instance.dishTypes.Count+1);
        orderedDishes = new List<ButtonManager_Register.DishType> ();
        List<int> randNum = new List<int>();
        int randPrefab = 0;
        for (int i = 0; i < orderSize; i++) {
            do {
                randPrefab = Random.Range (0, ButtonManager_Register.instance.dishTypes.Count);
            } while (randNum.Contains (randPrefab));
            randNum.Add (randPrefab);

            orderedDishes.Add (ButtonManager_Register.instance.dishTypes[randPrefab]);
            Instantiate(ButtonManager_Register.instance.dishTypes[randPrefab].prefab, pos[i]);
        }
    }
}
