using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager obj;
    private AudioSource audioSrc;

    public AudioClip burst;

    private void Awake()
    {
        obj = this;
        audioSrc = gameObject.AddComponent<AudioSource>();
    }

    public void playBurst() { Playsound(burst);}

    public void Playsound(AudioClip clip)
    {
        audioSrc.PlayOneShot(clip);
    }
    private void OnDestroy()
    {
        obj = null;
    }
}
