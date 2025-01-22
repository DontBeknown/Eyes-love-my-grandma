using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Drop4Test : MonoBehaviour, IDropHandler
{
    public int ch = 0;
    public bool Placed;
    //public GameObject Ans1, Ans2, Ans3;
    public void Start()
    {
        ch = 0;
        /*Placed1 = false;
        Placed2 = false;
        Placed3 = false;*/
    }
    public void Update()
    {
        /*if (Placed1 && Placed2 && Placed3)
        {
            if (ch1 == 1 && ch2 == 1 && ch3 == 1)
            {
                Debug.Log("Correct");
            }
            else
            {
                RePost();
                Debug.Log("False");
            }
        }*/

    }
    public void OnDrop(PointerEventData eventData)
    {
        Debug.Log("OnDrop");
        if (eventData.pointerDrag != null)
        {
            Placed = true;
            Debug.Log("OnDropSomething");
            eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = GetComponent<RectTransform>().anchoredPosition;
            if(eventData.pointerDrag.name == "Sclera" && gameObject.name == "Lock1")
            {
                ch = 1;
            }
            else
            {
                ch = 0;
            }

            if (eventData.pointerDrag.name == "pupil" && gameObject.name == "Lock2")
            {
                ch = 1;
            }
            else
            {
                ch = 0;
            }

            if (eventData.pointerDrag.name == "Iris" && gameObject.name == "Lock3")
            {
                ch = 1;
            }
            else
            {
                ch = 0;
            }
        }
        else
        {
            Placed = false;
        }
    }
    /*public void check()
    {
        if(gameObject.name == "Lock1")
        {
            Placed1 = true;
        }
        if (gameObject.name == "Lock2")
        {
            Placed2 = true;
        }
        if (gameObject.name == "Lock3")
        {
            Placed3 = true;
        }
        
    }*/
   /* public void RePost()
    {
        Ans1.GetComponent<RectTransform>().anchoredPosition = new Vector2(641.8f, 364f);
        Ans2.GetComponent<RectTransform>().anchoredPosition = new Vector2(646.5f, 158.4f);
        Ans3.GetComponent<RectTransform>().anchoredPosition = new Vector2(657.4f, -59.3f);
    }*/
}
