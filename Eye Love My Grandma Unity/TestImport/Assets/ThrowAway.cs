using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrowAway : MonoBehaviour
{
    private bool isDraging;
    public int speed = 10;
    public GameObject AlreadyThrow,End;
    public PresstoSkiptime Calender;
    //public Animator Throw;
    void Start()
    {
        AlreadyThrow.SetActive(false);
        End.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Calender.Day3)
        {
            if (isDraging)
            {
                Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
                transform.Translate(mousePosition);
                if (gameObject.transform.position.x <= -6)
                {
                    AlreadyThrow.SetActive(true);
                    End.SetActive(true);
                    gameObject.SetActive(false);

                    // Throw.SetBool("ThrowNow", true);
                }
            }
        }
    }

    public void OnMouseDown()
    {
        isDraging = true;
    }
    public void OnMouseUp()
    {
        isDraging = false;
    }
}
