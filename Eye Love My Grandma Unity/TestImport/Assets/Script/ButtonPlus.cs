using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonPlus : MonoBehaviour
{
    public int Now = 1;
    public GameObject Scene1, Scene2, Scene3, Scene4,GoRight,GoLeft,VrLong,VrShort;
    public string ScenetoGo,ScenetoVR;
    public bool ThisIsIDcard;
    void Start()
    {
        Scene1.SetActive(false);
        Scene2.SetActive(false);
        Scene3.SetActive(false);
        Scene4.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(Now == 1)
        {
            ScenetoGo = "";
            GoLeft.SetActive(false);
            Scene1.SetActive(true);
            Scene2.SetActive(false);
            if (ThisIsIDcard)
            {
                VrShort.SetActive(true);
                VrLong.SetActive(false);
            }
        }
        else if(Now == 2)
        {
            ScenetoGo = "";
            GoLeft.SetActive(true);
            Scene1.SetActive(false);
            Scene2.SetActive(true);
            Scene3.SetActive(false);
            if (ThisIsIDcard)
            {
                VrShort.SetActive(false);
                VrLong.SetActive(true);
            }
        }
        else if(Now == 3)
        {
            ScenetoGo = "";
            Scene2.SetActive(false);
            Scene3.SetActive(true);
            Scene4.SetActive(false);
            GoRight.SetActive(true);
            if (ThisIsIDcard)
            {
                VrShort.SetActive(false);
                VrLong.SetActive(false);
            }
        }
        else if(Now == 4)
        {
            ScenetoGo = "";
            Scene3.SetActive(false);
            Scene4.SetActive(true);
            GoRight.SetActive(false);
            if (ThisIsIDcard)
            {
                VrShort.SetActive(false);
                VrLong.SetActive(false);
            }
        }
    }
    public void PlusNow()
    {
        Now++;
    }
    public void MinusNow()
    {
        Now--;
    }

    public void ChangeScene()
    {
        SceneManager.LoadScene(ScenetoGo);
        Debug.Log("Goto" + Now);
    }

    public void ChangeVR()
    {
        SceneManager.LoadScene(ScenetoVR);
        Debug.Log("GotoVR" + Now);
    }
}
