using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class SettingMenu : MonoBehaviour
{
    public AudioMixer audiomixer;

    void Start()
    {

    }
    public void SetVolume(float volume)
    {
        audiomixer.SetFloat("Volume", volume);
    }


    //public Dropdown resolutionDrop;

    //public int clicked= 0;
    //Resolution[] resolutions;
    /* void Start()
    {
        resolutions = Screen.resolutions;

        resolutionDrop.ClearOptions();

        List<string> option = new List<string>();

        for(int i =0;i< resolutions.Length; i++)
        {
            string option = resolutions[i].width + "x" + resolutions[i].height;
            option.Add(option);

            if(resolutions[i].width == Screen.currentResolution.width&& resolutions[i].height == Screen.currentResolution.height)
            {
                currentResolutionIndex = i;
            }
        }

        resolutionDrop.AddOptions(options);
    }*/

    /* public void SetQuality (int qualityIndex)
     {
         QualitySettings.SetQualityLevel(qualityIndex);
     }    */

    /*public void SetFullscreen (bool isFullScreen)
    {
        Screen.fullScreen = isFullScreen;
    }
   /* public void OpenSetting(int OnOff)
    {
        if (clicked % 2 == 0) { GameObject.Find("Setting").SetActive(false); }
        else { GameObject.Find("Setting").SetActive(true); }
    }
    public void ChClick()
    {
        clicked++;
    }*/
}
