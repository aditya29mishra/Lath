using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayAudioInList : MonoBehaviour
{
    public AudioSource audioSource;
    public List<AudioClip> audioClips;

    public void PlayAudio(int no)
    {
        audioSource.Stop();
      
        if(no != 0 && no <= audioClips.Count)
        {
            audioSource.clip = audioClips[no - 1];
            audioSource.Play();
        }
    }
    public void StopAudio()
    {
        audioSource.Stop();
    }
}
