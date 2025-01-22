using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class KitchenButton : MonoBehaviour
{
    public SettingOnOff Setting;
    public GameObject Wall, CookingMenu, ExitCookingMenu, ExitFridge, RealExit;
    public Animator PotAnim;
    public AudioClip SoundClip;
    public AudioSource Source;
    //public GameObject Obj1, Obj2, Obj3, Obj4, Obj5, Obj6, Obj7, Obj8, Obj9, Obj10, Obj11, Obj12,Box;
    void Start()
    {
        Wall.SetActive(false);
        ExitCookingMenu.SetActive(false);
        CookingMenu.SetActive(false);
        //Delete(false);
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnMouseOver()
    {
        if (!Setting.issettingOn)
        {
            gameObject.GetComponent<SpriteRenderer>().color = new Color(1f, 1f, 1f, 0.95f);
            if (Input.GetMouseButtonDown(0))
            {
                OpenCookingMenu();
                Source.PlayOneShot(SoundClip);
            }
        }
    }

    private void OnMouseExit()
    {
        gameObject.GetComponent<SpriteRenderer>().color = new Color(1f, 1f, 1f, 1f);
    }

    public void OpenCookingMenu()
    {
        PotAnim.SetBool("FridgeOpen", false);
        Wall.SetActive(true);
        ExitCookingMenu.SetActive(true);
        CookingMenu.SetActive(true);
       // Delete(true);
    }
    public void CloseCookingMenu()
    {
        Wall.SetActive(false);
        ExitCookingMenu.SetActive(false);
        CookingMenu.SetActive(false);
        //Delete(false);
    }

    public void OpenFridge()
    {
        ExitFridge.SetActive(true);
        RealExit.SetActive(false);
        //Delete(true);
    }

    public void CloseFridge()
    {
        ExitFridge.SetActive(false);
        RealExit.SetActive(true);
        //Delete(false);
    }



}
