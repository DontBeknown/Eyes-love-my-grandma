using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.VR;

public class Changescene : MonoBehaviour
{
    public void Goto2D()
    {
        SceneManager.LoadScene("2Dscene");
    }

    public void GotoVR()
    {
        SceneManager.LoadScene("3DVrScene");
    }
}
