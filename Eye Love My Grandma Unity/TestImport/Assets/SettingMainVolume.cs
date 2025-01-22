using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class SettingMainVolume : MonoBehaviour
{
    public AudioMixer audiomixer;

    void Start()
    {

    }
    public void SetVolume(float volume)
    {
        audiomixer.SetFloat("Volume", volume);
    }
}
