using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnterDoor : MonoBehaviour
{
    public Text enterDoor;

    private void OnTriggerEnter(Collider other) {
        enterDoor.text = "Presione E para abrir";
    }

    private void OnTriggerExit(Collider other) {
        enterDoor.text = "";
    }

}
