using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gate : MonoBehaviour {
    private Canvas myCanvas;
    public GameObject dog;
    // Use this for initialization
    void Start() {
        myCanvas = FindObjectOfType<Canvas>();
        Debug.Log(myCanvas);
        myCanvas.enabled = false;
    }

    private void OnTriggerEnter(Collider other) {
        myCanvas.enabled = true;
    }

    void OnTriggerExit() {
        myCanvas.enabled = false;
        Instantiate(dog,new Vector3(338,0,167),Quaternion.identity);
        Instantiate(dog, new Vector3(336, 0, 167), Quaternion.identity);
    }
}
