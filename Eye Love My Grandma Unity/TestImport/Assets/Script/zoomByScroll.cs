using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class zoomByScroll : MonoBehaviour
{
    public float MinZoom = 1f,MaxZoom = 1.5f,Sensitivity = 10f,RealZoom;
    public Camera MainCamera;
    public float Num1;
    public int Num2;
    public Text DisplayNum;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MainCamera = GetComponent<Camera>();
        RealZoom += Input.GetAxis("Mouse ScrollWheel") * Sensitivity;
        RealZoom = Mathf.Clamp(RealZoom, MinZoom, MaxZoom);
        MainCamera.orthographicSize = RealZoom;

        Num1 = RealZoom * 100;
        Num2 = ((int)Num1 - 100) + 30;
        DisplayNum.text =  " " + Num2 ;

        if (Num2 >= 50 && Num2 <= 70)
        {
            DisplayNum.color = Color.green;
        }
        else
        {
            DisplayNum.color = Color.black;
        }
    }
}
