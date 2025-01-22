using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sound : MonoBehaviour
{
    public AudioClip SoundClip;
    static AudioSource Source;
    void Start()
    {
        Source = GetComponent<AudioSource>();
    }
    void Update()
    {
        /*if(Input.GetMouseButtonDown(0))
        {
            Source.PlayOneShot(SoundClip);
        }*/
    }
    public  void PlaySound()
    {
        Source.PlayOneShot(SoundClip);
    }
}
