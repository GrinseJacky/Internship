using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NegGate : MonoBehaviour
{
    private Canvas myCanvas;
    // Use this for initialization
    void Start() {
        //myCanvas = FindObjectOfType<Canvas>();
        //myCanvas.enabled = false;
    }

    private void OnTriggerEnter(Collider collider) {
        if (collider.gameObject.tag == "Player") {
            //myCanvas.enabled = true;
        }
    }

    void OnTriggerExit(Collider collider) {
        if (collider.gameObject.tag == "Player") {

        
        GameObject[] test = GameObject.FindGameObjectsWithTag("Clones");
        for (int i = 0; i < test.Length; i++) {
            Destroy(test[i]);
        }
        //myCanvas.enabled = false;
    }
    }
}
