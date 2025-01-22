using DigitalRuby.SimpleLUT;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tutorial : MonoBehaviour
{
    public GameObject Hint,Wall,Hint2;
    public bool TutorialOn,IsPhoneScene,Have2Hint;
    public SimpleLUT brightness;
    public float LastBrightness;
    // Start is called before the first frame update
    void Start()
    {
        OnTutorail();
        if (Have2Hint)
        {
            Hint2.SetActive(false);
            //Wall.setActive(true);
        }
        if (IsPhoneScene)
        {
            Hint2.SetActive(false);
            LastBrightness = -0.85f;
        }

    }

    // Update is called once per frame
    void Update()
    {
        if (IsPhoneScene)
        {

            if (TutorialOn)
            {
                brightness.Brightness = 0;
            }
        }
    }
    
    public void OnTutorail()
    {
        Hint.SetActive(true);
        Wall.SetActive(true);
        TutorialOn = true;
        if (IsPhoneScene)
        {
            LastBrightness = brightness.Brightness;
        }

    }
    public void OffTutorail()
    {
        Hint.SetActive(false);
        Wall.SetActive(false);
        TutorialOn = false;
        if (IsPhoneScene)
        {
            brightness.Brightness = LastBrightness;
        }
    }
    public void SwapHint()
    {
        Hint.SetActive(false);
        Hint2.SetActive(true);
    }
    public void ClearAlltutorial()
    {
        Hint2.SetActive(false);
        Wall.SetActive(false);
        TutorialOn = false;
        if (IsPhoneScene)
        {
            brightness.Brightness = LastBrightness;
        }

    }
}
