using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotar : MonoBehaviour
{

    public Transform newPos;
    public Camera cam;
    
    bool rotar;
     void Update() {
        if(rotar) {
            if(Vector3.Distance(cam.transform.position, newPos.position) > 0.01f) {
                cam.transform.position = Vector3.Lerp(cam.transform.position, newPos.position, Time.deltaTime*8.0f);
                cam.transform.rotation = Quaternion.Lerp(cam.transform.rotation, newPos.rotation, Time.deltaTime*8.0f);
            } else {
                rotar = false;
            }
        }
    }

    private void OnTriggerEnter(Collider other) {
        rotar= true;
    }
}
