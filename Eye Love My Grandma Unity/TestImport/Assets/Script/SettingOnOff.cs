using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingOnOff : MonoBehaviour
{
    public GameObject Wall,Setting;
    public bool issettingOn,ThisisInMiniGame;
    public GameObject Continue,Pause;
    void Start()
    {
        //Wall.SetActive(false);
        Setting.SetActive(false);
        if (ThisisInMiniGame)
        {
            Pause.SetActive(true);
            Continue.SetActive(false);
        }
    }
    // Update is called once per frame
    void Update()
    {
        
        if (ThisisInMiniGame)
        {
            if (issettingOn)
            {
                Continue.SetActive(true);
                Pause.SetActive(false);
            }
            else
            {
                Continue.SetActive(false);
                Pause.SetActive(true);
            }
            
        }
    }
    public void OpenSetting()
    {
        Wall.SetActive(true);
        Setting.SetActive(true);
        issettingOn = true;
    }
    public void CloseSetting()
    {
        Wall.SetActive(false);
        Setting.SetActive(false);
        issettingOn = false;
    }
}
