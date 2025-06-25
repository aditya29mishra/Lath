using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class ReverseAnimation : MonoBehaviour
{
    public GameObject startAnimation;
    public GameObject reverseAnimation;

    public void OnButtonPress()
    {
        startAnimation.SetActive(false);
        reverseAnimation.SetActive(true);

      //  Invoke("OnButtonRelease", 4f);
    }

    public void OnButtonRelease()
    {
        reverseAnimation.SetActive(false);
        startAnimation.SetActive(true);
    }
}
