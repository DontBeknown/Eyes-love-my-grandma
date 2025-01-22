using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenFridge : MonoBehaviour
{
    public GameObject AllFruit,FruitBox,ExitFridge,RealExit;
    public SettingOnOff Setting;
    public Animator FirstTimeAnim,PotAnim;
    public bool IsOn;
    public AudioClip SoundClip;
    public AudioSource Source;
    void Start()
    {
        AllFruit.SetActive(false);
        FruitBox.SetActive(false);
        RealExit.SetActive(true);
        ExitFridge.SetActive(false);
        FirstTimeAnim.SetBool("FirstTime?", false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseOver()
    {
        if (!Setting.issettingOn && !IsOn)
        {
            gameObject.GetComponent<SpriteRenderer>().color = new Color(1f, 1f, 1f, 0.95f);
            if (Input.GetMouseButtonDown(0))
            {
                FirstTimeAnim.SetBool("FirstTime?", true);
                AllFruit.SetActive(true);
                FruitBox.SetActive(true);
                ExitFridge.SetActive(true);
                IsOn = true;
                Source.PlayOneShot(SoundClip);
            }
        }
    }

    private void OnMouseExit()
    {
        gameObject.GetComponent<SpriteRenderer>().color = new Color(1f, 1f, 1f, 1f);
    }

    public void ExitFridgeButton()
    {
        AllFruit.SetActive(false);
        FruitBox.SetActive(false);
        ExitFridge.SetActive(false);
        PotAnim.SetBool("FridgeOpen", true);
        IsOn = true;
    }
}
