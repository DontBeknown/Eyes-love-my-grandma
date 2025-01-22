using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EachFruit : MonoBehaviour
{
    public GameObject TextBox;
    public bool CantDoThatRightNow;
    void Start()
    {
        TextBox.SetActive(false);
    }
       
    // Update is called once per frame
    void Update()
    {
        CantDoThatRightNow = GameObject.Find("GameManager").GetComponent<SettingOnOff>().issettingOn;
    }

    public void OnMouseOver()
    {
        if (!CantDoThatRightNow)
        {
            TextBox.SetActive(true);
        }
    }
    public void OnMouseExit()
    {
        TextBox.SetActive(false);
    }
}
