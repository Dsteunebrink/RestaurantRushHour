using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCMovement : MonoBehaviour {

    public float moveSpeed;

    private bool NPC_Stop;

    private Rigidbody2D myRigidbody;

    // Use this for initialization
    void Start () {
        myRigidbody = GetComponent<Rigidbody2D> ();
        NPC_Stop = false;
    }

    // Update is called once per frame
    void Update () {
        NpcMovement ();
    }

    private void NpcMovement () {
        if(NPC_Stop == false) {
            myRigidbody.velocity = new Vector2 (0, -moveSpeed);
        }
        if (NPC_Stop == true) {
            myRigidbody.velocity = new Vector2 (0, 0);
        }
    }

    private void OnTriggerEnter2D (Collider2D collision) {
        if (collision.CompareTag ("NPC_Stop")) {
            NPC_Stop = true;
        }
    }
}
