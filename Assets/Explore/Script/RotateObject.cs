using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class RotateObject : MonoBehaviour
{
    public Slider rotationSlider; 
    public Transform objectToRotate1;
    public Transform objectToRotate2;


    void Start()
    {
        rotationSlider.onValueChanged.AddListener(UpdateRotation);
    }

    void UpdateRotation(float value)
    {
        objectToRotate1.rotation = Quaternion.Euler(0, value * 360, 0);
        objectToRotate2.rotation = Quaternion.Euler(0, value * 360, 0);
         
    }
}
