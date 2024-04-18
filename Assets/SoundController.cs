using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundController : MonoBehaviour
{
    //Design pattern:Singleton khai bao cho toan bo project
    public static SoundController instance;
    private void Awake()
    {
        instance = this;
    }
    public void PlaySound(string clipName,float volumeMultipiler)
    {
        AudioSource audioSource = this.gameObject.AddComponent<AudioSource>();
        audioSource.volume *= volumeMultipiler;
        audioSource.PlayOneShot((AudioClip)Resources.Load("audio/" + clipName, typeof(AudioClip)));
    }

}
