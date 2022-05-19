using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gate : MonoBehaviour {
    public Canvas myCanvas;
    public GameObject dog;
    // Use this for initialization
    void Start() {
        
        myCanvas.enabled = false;
    }

    private void OnTriggerEnter(Collider collider) {
        if (collider.gameObject.tag == "Player") {
            myCanvas.enabled = true;
        }
        
    }

    void OnTriggerExit(Collider collider) {
       if (collider.gameObject.tag == "Player") {
            Instantiate(dog, new Vector3(338, 0, 176), Quaternion.identity);
            Instantiate(dog, new Vector3(336, 0, 176), Quaternion.identity);
        }
        
        myCanvas.enabled = false;
        
        
    }
}
