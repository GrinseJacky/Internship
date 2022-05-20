using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gate : MonoBehaviour {
    public Canvas myCanvas;
    public GameObject dog;
    public ParticleSystem part,part2;
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
            part.Play();
            Instantiate(dog, new Vector3(336, 0, 176), Quaternion.identity);
            part2.Play();
        }
        
        myCanvas.enabled = false;
        
        
    }
}
