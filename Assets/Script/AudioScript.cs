using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AudioScript : MonoBehaviour
{
    public AudioSource[] audioSources;
    public GameObject[] textObjects;
    private int currentIndex = -1;

    public void OnButtonPress(int buttonIndex)
    {

        if (currentIndex != -1)
        {
            audioSources[currentIndex].Stop();
            textObjects[currentIndex].gameObject.SetActive(false);
        }


        currentIndex = buttonIndex;
        audioSources[currentIndex].Play();
        textObjects[currentIndex].gameObject.SetActive(true);
    }


}
