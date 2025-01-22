using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

public class ButtonSkip : MonoBehaviour
{
    public void Goto(string Scenename)
    {
        SceneManager.LoadScene(Scenename);
    }

    public void SkippIntro()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void GotoIntro()
    {
        SceneManager.LoadScene("Intro");
    }

    public void GotoMenu()
    {
        SceneManager.LoadScene("Menu");
    }
    public void GotoSetting()
    {
        SceneManager.LoadScene("Setting");
    }
    public void ExitdaGame()
    {
        Application.Quit();
        Debug.Log("Exit");
    }
    public void GoVR()
    {
        SceneManager.LoadScene("VRMode");
    }


}
