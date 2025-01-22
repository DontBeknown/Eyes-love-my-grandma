using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.SceneManagement;

public class VrOnOff : MonoBehaviour
{
    public bool ThisVrScene,ThisIs2D,ColorBlind;
    public string Scenename,ColorBlindName;
 
    // Start is called before the first frame update
    void Start()
    {
        if (ThisVrScene)
        {
            OnVr();
            if (Input.GetKey("f"))
            {
                SceneManager.LoadScene(Scenename);
                OffVr();
            }

        }
        if (ThisIs2D)
        {
            OffVr();
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (ThisVrScene)
        {
            if (Input.GetKey("f"))
            {
                SceneManager.LoadScene(Scenename);
                OffVr();
            }
        }
        if (ColorBlind)
        {
            if (Input.GetKey("r"))
            {
                Debug.Log("1");
                SceneManager.LoadScene(ColorBlindName);
            }

        }
    }
    
    public void OnVr()
    {
        StartCoroutine(SwitchToVR());
    }
    public void OffVr()
    {
        StartCoroutine(SwitchTo2D());
    }
    public void GotoVrScene(string VrScene)
    {
        SceneManager.LoadScene(VrScene);
        StartCoroutine(SwitchToVR());
    }
    IEnumerator SwitchToVR()
    {
        XRSettings.LoadDeviceByName("OpenVR");

        yield return null;

        XRSettings.enabled = true;
    }

    // Call via `StartCoroutine(SwitchTo2D())` from your code. Or, use
    // `yield SwitchTo2D()` if calling from inside another coroutine.
    IEnumerator SwitchTo2D()
    {
        // Empty string loads the "None" device.
        XRSettings.LoadDeviceByName("None");

        // Must wait one frame after calling `XRSettings.LoadDeviceByName()`.
        yield return null;

        // Not needed, since loading the None (`""`) device takes care of this.
        // XRSettings.enabled = false;

        // Restore 2D camera settings.
        //ResetCameras();
    }

    // Resets camera transform and settings on all enabled eye cameras.
    void ResetCameras()
    {
        // Camera looping logic copied from GvrEditorEmulator.cs
        for (int i = 0; i < Camera.allCameras.Length; i++)
        {
            Camera cam = Camera.allCameras[i];
            if (cam.enabled && cam.stereoTargetEye != StereoTargetEyeMask.None)
            {

                // Reset local position.
                // Only required if you change the camera's local position while in 2D mode.
                cam.transform.localPosition = Vector3.zero;

                // Reset local rotation.
                // Only required if you change the camera's local rotation while in 2D mode.
                cam.transform.localRotation = Quaternion.identity;

                // No longer needed, see issue github.com/googlevr/gvr-unity-sdk/issues/628.
                // cam.ResetAspect();

                // No need to reset `fieldOfView`, since it's reset automatically.
            }
        }
    }
    
}
