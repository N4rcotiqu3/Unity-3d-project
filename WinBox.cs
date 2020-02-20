using System.Collections;
using UnityEngine;

public class WinBox : MonoBehaviour
{
    private void OnTriggerEnter(Collider other) {
        GameObject.Find("Player").SendMessage("Finnish");
    }
}
