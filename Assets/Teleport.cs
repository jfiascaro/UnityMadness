using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    public Transform Exit;

    private void OnTriggerEnter(Collider other) {
        if(other.CompareTag("Player")) {
            other.transform.position = Exit.position;
        }
    }
}
