using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using static Assets.Scripts.SDK;

public class Gate : MonoBehaviour {
    public Canvas myCanvas;
    public GameObject dog;
    public ParticleSystem part,part2;



    // Use this for initialization
    void Start() {
        
        myCanvas.enabled = false;
        TMPro.TextMeshPro[] obj = GameObject.Find("True or False").GetComponentsInChildren<TMPro.TextMeshPro>();
        obj[0].text = enscape(Read())[0];
        obj[1].text = enscape(Read())[1];
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
