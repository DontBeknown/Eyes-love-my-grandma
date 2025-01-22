using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OnOffEYE : MonoBehaviour
{
    public GameObject Open, Close;
    public int Sum = 10;
    public Text Counttext;
    public Tutorial IsTutorialOn;
    public SettingOnOff Setting;
    public GameObject GoRight, GoLeft;
    public AudioClip SoundClip;
    public AudioSource Source;
    // Start is called before the first frame update
    void Start()
    {
        Close.SetActive(false);
        GoRight.SetActive(false);
        GoLeft.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (!IsTutorialOn.TutorialOn && !Setting.issettingOn)
        {
            if (Sum <= 0)
            {
                GoRight.SetActive(true);
                GoLeft.SetActive(true);
                Sum = 0;
            }
            if (Input.GetMouseButtonDown(0))
            {
                Source.PlayOneShot(SoundClip);
                Close.SetActive(true);
                Sum--;
            }
            if (Input.GetMouseButtonUp(0))
            {
                Close.SetActive(false);
            }
            Counttext.text = "" + Sum;
        }
    }

}
