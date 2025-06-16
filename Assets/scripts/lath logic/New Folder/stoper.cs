using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stoper : MonoBehaviour
{
    public GameObject wheel;
    public automaticfeedwheelrotation wheelRotationScript;

    private void Start()
    {
        wheelRotationScript = wheel.GetComponent<automaticfeedwheelrotation>();
    }
    void OnTriggerEnter(Collider other)
{
    Debug.Log("Entered Trigger: " + other.gameObject.name);
    if (other.gameObject.CompareTag("mainMover"))
    {
        Debug.Log("mainMover entered trigger.");
        wheelRotationScript.StopWheelRotation();
    }
}

void OnTriggerExit(Collider other)
{
    Debug.Log("Exited Trigger: " + other.gameObject.name);
    if (other.gameObject.CompareTag("mainMover"))
    {
        Debug.Log("mainMover exited trigger.");
        wheelRotationScript.StartWheelRotation();
    }   
}

}
