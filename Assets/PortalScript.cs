using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalScript : MonoBehaviour
{
    public Transform spamPoint;
    private void OnTriggerEnter(Collider other) {
        other.transform.position = spamPoint.position;
    }

    private void OnTriggerExit(Collider other) {
        
    }

}
