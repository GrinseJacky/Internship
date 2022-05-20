using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gate2 : MonoBehaviour
{
    public ParticleSystem part, part2;
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
        Instantiate(dog, new Vector3(346, 0, 239), Quaternion.identity);
            part.Play();
            Instantiate(dog, new Vector3(344, 0, 239), Quaternion.identity);
            part2.Play();
        }

    myCanvas.enabled = false;


}
}
