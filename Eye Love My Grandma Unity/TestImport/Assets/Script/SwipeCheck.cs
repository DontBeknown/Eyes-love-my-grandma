using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwipeCheck : MonoBehaviour
{
    public int sum = 0, sum2 = 0, Swipeto = 3;
    public float XonPress, XonRelease;
    public bool SaltFisnished = false, isSwipeLeft, isSwipeRight, GoToTheEnd = false, nextPhase = false;
    public GameObject LeftSign, RightSign, OldSaltR, OldSaltL, NewSaltR, NewSaltL;
    public GameObject Salmon, Dish, Old, InteractAbleSalmon, OldSalmon;
    public HintButton Hint;
    //public Animator LeftSaltAnim, RightSaltAnim;
    void Start()
    {
        /*LeftSaltAnim = LeftSaltAnim.GetComponent<Animator>();
        RightSaltAnim = RightSaltAnim.GetComponent<Animator>();*/
        Salmon.SetActive(false);
        Dish.SetActive(false);
        LeftSign.SetActive(false);
        RightSign.SetActive(false);
        InteractAbleSalmon.SetActive(false);
        /*isSwipeLeft = false;
        isSwipeRight = false;*/
    }

    void Update()
    {
        SaltFisnished = gameObject.GetComponent<InteractSalt>().isFinish;
        if (SaltFisnished)
        {


            StartCoroutine(PadRight());
            if (sum >= 1)
            {
                StartCoroutine(PadLeft());
            }
            if (Input.GetMouseButtonDown(0))
            {
                XonPress = Input.mousePosition.x;
            }

            if (Input.GetMouseButtonUp(0))
            {
                XonRelease = Input.mousePosition.x;

                if (XonPress < XonRelease && XonRelease - XonPress >= 200 && !isSwipeLeft && !isSwipeRight)
                {
                    Debug.Log("SwipeRight");
                    //StartCoroutine(CheckRight());
                    Swipeto = 0;
                }

                if (XonRelease < XonPress && XonPress - XonRelease >= 200 && !isSwipeLeft && !isSwipeRight)
                {
                    Debug.Log("SwipeLeft");
                    //StartCoroutine(CheckLeft());
                    Swipeto = 1;
                }
            }

        }
    }

    /*IEnumerator CheckRight()
    {
        isSwipeRight = true;
        yield return new WaitForSeconds(0.5f);
        isSwipeRight = false;
    }
    IEnumerator CheckLeft()
    {
        isSwipeLeft = true;
        yield return new WaitForSeconds(0.5f);
        isSwipeLeft = false;
    }*/
    IEnumerator PadRight()
    {
        yield return new WaitForSeconds(1);
        if (sum < 1)
        {

            RightSign.SetActive(true);
            if (Swipeto == 0)
            {
                sum++;
                OldSaltR.SetActive(false);
                NewSaltR.SetActive(true);
                RightSign.SetActive(false);
                isSwipeRight = false;

                LeftSign.SetActive(true);

            }

        }
    }
    IEnumerator PadLeft()
    {
        //Debug.Log("1");
        yield return new WaitForSeconds(1);
        if (Swipeto == 1 && !nextPhase)
        {
            //Debug.Log("2");
            sum2++;
            OldSaltL.SetActive(false);
            NewSaltL.SetActive(true);
            LeftSign.SetActive(false);
            nextPhase = true;
            StartCoroutine(NextPhase());
        }
    }

    IEnumerator NextPhase()
    {
        yield return new WaitForSeconds(1);

        Destroy(Old);
        Destroy(NewSaltL);
        Destroy(NewSaltR);

        
        
        Salmon.SetActive(true);
        Dish.SetActive(true);
        yield return new WaitForSeconds(1);
        OldSalmon.SetActive(false);
        InteractAbleSalmon.SetActive(true);
        Hint.kuykang = 5 ;
    }
}
