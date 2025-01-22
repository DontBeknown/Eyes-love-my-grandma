using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PopUp : MonoBehaviour
{
    public GameObject TextBox;
    public AudioClip SoundClip;
    public AudioSource Source;
    public string ScenetoGo;
    public bool CantDoThatRightNow;
    void Start()
    {
        TextBox.SetActive(false);
    }
    void Update()
    {
        CantDoThatRightNow = GameObject.Find("Gamemanager").GetComponent<SettingOnOff>().issettingOn;
    }
    void OnMouseOver()
    {
        if (!CantDoThatRightNow)
        {
            //Debug.Log("Mouse is over " + gameObject.name);
            TextBox.SetActive(true);
            if (Input.GetMouseButtonDown(0))
            {
                Source.PlayOneShot(SoundClip);
                SceneManager.LoadScene(ScenetoGo);
            }
        }
    }

    void OnMouseExit()
    {
        //Debug.Log("Mouse is no longer on " + gameObject.name);
        TextBox.SetActive(false);
    }

}
