using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundController : MonoBehaviour
{
    public AudioClip[] clips;
    public AudioSource audioSource;
    private void Start()
    {
        audioSource.clip = clips[0];
    }

}
