using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR;

public class ZoomINOut : MonoBehaviour
{
    Camera maincamera;
    public Text DisplayNum;
    public float Num1;
    public int Num2;
    int x ;
    public float zoomAMT = 5f;
    public GameObject ConGratz,GoRight;
    // Start is called before the first frame update
    void Start()
    {
        maincamera = GetComponent<Camera>();
        DisplayNum.text = " 0";
        ConGratz.SetActive(false);
        GoRight.SetActive(false);
        StartCoroutine(SwitchTo2D());
    }

    // Update is called once per frame
    void Update()
    {
        maincamera.orthographicSize = zoomAMT;   

        Num1 = zoomAMT*100; 
        Num2 = ((int)Num1-100)+30;
        DisplayNum.text = " " + Num2;
        
    }

    public void sliderZoom(float zoom)
    {
        zoomAMT = zoom;
        if(Num2 >= 50 && Num2 <= 70)
        {
            DisplayNum.color = Color.green;
            GoRight.SetActive(true);
            //ConGratz.SetActive(true);
        }
        else
        {
            DisplayNum.color = Color.black;
            //print("Black");
        }
    }
    IEnumerator SwitchTo2D()
    {
        // Empty string loads the "None" device.
        XRSettings.LoadDeviceByName("None");

        // Must wait one frame after calling `XRSettings.LoadDeviceByName()`.
        yield return null;

        // Not needed, since loading the None (`""`) device takes care of th
        XRSettings.enabled = false;


    }
    // 1   1.1 1.2 1.3 1.4 1.5
    // 30  40  50  60  70  80

    // 100 110
    // 0
}
