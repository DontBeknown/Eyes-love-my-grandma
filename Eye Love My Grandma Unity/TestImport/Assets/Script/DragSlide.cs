using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class DragSlide : MonoBehaviour
{
    private float startPosX;
    private float startPosY;
    private bool isBeingHold = false;
    public GameObject WhiteLight, FrontLight, BlueLight,GoRight,GoLeft;
    public AudioClip OpenFlash,OffFlash;
    public AudioSource Source;
    void Start()
    {
        GoRight.SetActive(false);
        GoLeft.SetActive(false);
    }
    private void Update()
    {
       if(isBeingHold == true)
        {
            Vector3 mousePos;
            mousePos = Input.mousePosition;
            mousePos = Camera.main.ScreenToWorldPoint(mousePos);
            FrontLight.SetActive(false);
            WhiteLight.SetActive(false);
            BlueLight.SetActive(false);
            this.gameObject.transform.localPosition = new Vector3(mousePos.x, -4.03f, 0);
            if(mousePos.x > 6.09f )
            {
                //isBeingHold = false;
                this.gameObject.transform.localPosition = new Vector3(6.08f, -4.03f, 0);
            }else if(mousePos.x < -6.42f )
            {
                //isBeingHold = false;
                this.gameObject.transform.localPosition = new Vector3(-6.41f, -4.03f, 0);
            }

        }
        else
        {
            var ObjPos = this.transform.position.x;
            /*WhiteLight.SetActive(false);*/
            BlueLight.SetActive(true);
            FrontLight.SetActive(true);
            if (ObjPos > 5.68f && ObjPos < 6.09f )
            {
                this.gameObject.transform.localPosition = new Vector3(6.08f, -4.03f, 0);
                WhiteLight.SetActive(true);
                BlueLight.SetActive(false);
                GoRight.SetActive(true);
                GoLeft.SetActive(true);
            }
            else if (ObjPos > 2.08f && ObjPos < 3.33f)
            {
                this.gameObject.transform.localPosition = new Vector3(2.77f, -4.03f, 0);
                WhiteLight.SetActive(true);
                BlueLight.SetActive(false);
                GoRight.SetActive(true);
                GoLeft.SetActive(true);
            }
            else if (ObjPos > -3.29f && ObjPos < -1.78f)
            {
                this.gameObject.transform.localPosition = new Vector3(-2.56f, -4.03f, 0);
                WhiteLight.SetActive(false);
                BlueLight.SetActive(true);
            }
            else if (ObjPos > -6.42f && ObjPos < -5.55f)
            {
                this.gameObject.transform.localPosition = new Vector3(-6.39f, -4.03f, 0);
                WhiteLight.SetActive(false);
                BlueLight.SetActive(true);
            }
            
        }
        
    }

    private void OnMouseDown()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 mousPos;
            mousPos = Input.mousePosition;
            mousPos = Camera.main.ScreenToWorldPoint(mousPos);

            Source.PlayOneShot(OffFlash);
            isBeingHold = true;
            print("isBeingHold = true");
            
        }
    }

    private void OnMouseUp()
    {
        isBeingHold = false;
        print("isBeingHold = false");
        Source.PlayOneShot(OpenFlash);
    }
}

