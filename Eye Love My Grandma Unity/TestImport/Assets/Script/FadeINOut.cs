using DigitalRuby.SimpleLUT;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeINOut : MonoBehaviour
{
    public SimpleLUT maincamera;
    public GameObject GoRight, GoLeft;
    void Start()
    {
        GoRight.SetActive(false);
        GoLeft.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        maincamera = GetComponent<SimpleLUT>();
    }

    public void FadeInOut(float brightness)
    {
        maincamera.Brightness = brightness;
        if(brightness >= 0)
        {
            GoRight.SetActive(true);
            GoLeft.SetActive(true);
        }
    }
}
