using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchBlindMode : MonoBehaviour
{
    public GameObject Cam1, Cam2, Cam3, Cam4;
    void Start()
    {
        
    }


    void Update()
    {
        if (Input.GetKey("1"))
        {
            Cam1.SetActive(true);
            Cam2.SetActive(false);
            Cam3.SetActive(false);
            Cam4.SetActive(false);
        }
        if (Input.GetKey("2"))
        {
            Cam1.SetActive(false);
            Cam2.SetActive(true);
            Cam3.SetActive(false);
            Cam4.SetActive(false);
        }
        if (Input.GetKey("3"))
        {
            Cam1.SetActive(false);
            Cam2.SetActive(false);
            Cam3.SetActive(true);
            Cam4.SetActive(false);
        }
        if (Input.GetKey("4"))
        {
            Cam1.SetActive(false);
            Cam2.SetActive(false);
            Cam3.SetActive(false);
            Cam4.SetActive(true);
        }
    }
}
