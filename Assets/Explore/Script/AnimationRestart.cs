using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationRestart : MonoBehaviour
{
    public GameObject explore; 
    public GameObject close;

    public void OnButtonPress()
    {
        explore.SetActive(true);
        close.SetActive(false);
    }
}
