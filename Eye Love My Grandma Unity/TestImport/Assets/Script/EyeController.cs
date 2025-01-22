using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EyeController : MonoBehaviour
{
    public Texttrigger Quest;
    public GameObject Eyes;
    public Tutorial Tutorial;
    public SettingOnOff Setting;
    public bool OnCooldown, HaveCoolDown, KnowHow2P, DoCircle, DoReset1 = false, DoUpDown, DoReset2 = false, DoLeftRight, DoReset3 = false, DoTilted;
    public bool Up, UpRight, UpLeft, Down, DownLeft, DownRight, Left, Right;

    void Start()
    {
        KnowHow2P = false;
        DoCircle = false;
        DoUpDown = false;
        DoTilted = false;
    }

    // Update is called once per frame
    void Update()
    {
        //0.0489559
        if (!Tutorial.TutorialOn && !Setting.issettingOn)
        {
            if (Input.GetKey(KeyCode.UpArrow))
            {
                Eyes.transform.position = new Vector3(2.986287f, 0.67f, 0);
                if (!Quest.FirsttimeCloseTutorail)
                {
                    Up = true;
                }
                /* Up = true;
                 StartCoroutine(CoolDown());
                 Up = false;*/
                //StartCoroutine(CoolDown(Up));
                //Debug.Log("PushUp");
                if (Input.GetKey(KeyCode.RightArrow))
                {
                    Eyes.transform.position = new Vector3(3.836f, 0.583f, 0);
                    KnowHow2P = true;
                    if (!Quest.FirsttimeCloseTutorail)
                    {
                        UpRight = true;
                        if (Quest.Mission1Pass)
                        {
                            Up = false;
                        }
                    }
                    /* UpRight = true;
                     StartCoroutine(CoolDown());
                     UpRight = false;*/
                    //StartCoroutine(CoolDown(UpRight));
                }
                else if (Input.GetKey(KeyCode.LeftArrow))
                {
                    Eyes.transform.position = new Vector3(2.04f, 0.688f, 0);
                    KnowHow2P = true;
                    if (!Quest.FirsttimeCloseTutorail)
                    {
                        UpLeft = true;
                        if (Quest.Mission1Pass)
                        {
                            Up = false;
                        }
                    }
                    /* UpLeft = true;
                     StartCoroutine(CoolDown());
                     UpLeft = false;*/
                    // StartCoroutine(CoolDown(UpLeft));
                }
            }
            else if (Input.GetKey(KeyCode.DownArrow))
            {
                Eyes.transform.position = new Vector3(2.986287f, -0.606f, 0);
                if (!Quest.FirsttimeCloseTutorail)
                {
                    Down = true;
                }
                /*Down = true;
                StartCoroutine(CoolDown());
                Down = false;*/
                // StartCoroutine(CoolDown(Down));
                if (Input.GetKey(KeyCode.RightArrow))
                {
                    Eyes.transform.position = new Vector3(3.74f, -0.79f, 0);
                    KnowHow2P = true;
                    if (!Quest.FirsttimeCloseTutorail)
                    {
                        DownRight = true;
                        if (Quest.Mission1Pass)
                        {
                            Right = false;
                        }
                    }
                    /*DownRight = true;
                    StartCoroutine(CoolDown());
                    DownRight = false;*/
                    // StartCoroutine(CoolDown(DownRight));
                }
                else if (Input.GetKey(KeyCode.LeftArrow))
                {
                    Eyes.transform.position = new Vector3(2.13f, -0.75f, 0);
                    KnowHow2P = true;
                    if (!Quest.FirsttimeCloseTutorail)
                    {
                        DownLeft = true;
                        if (Quest.Mission1Pass)
                        {
                            Left = false;
                        }
                    }
                    /*DownLeft = true;
                    StartCoroutine(CoolDown());
                    DownLeft = false;*/
                    // StartCoroutine(CoolDown(DownLeft)); 
                }
            }
            else if (Input.GetKey(KeyCode.RightArrow))
            {
                Eyes.transform.position = new Vector3(4.2f, 0.0489559f, 0);
                if (!Quest.FirsttimeCloseTutorail)
                {
                    Right = true;
                }
                if (Input.GetKey(KeyCode.UpArrow))
                {
                    Eyes.transform.position = new Vector3(3.836f, 0.583f, 0);
                    KnowHow2P = true;
                    if (!Quest.FirsttimeCloseTutorail)
                    {
                        UpRight = true;
                        if (Quest.Mission1Pass)
                        {
                            Right = false;
                        }
                    }
                }
                if (Input.GetKey(KeyCode.DownArrow))
                {
                    Eyes.transform.position = new Vector3(3.74f, -0.79f, 0);
                    KnowHow2P = true;
                    if (!Quest.FirsttimeCloseTutorail)
                    {
                        DownRight = true;
                        if (Quest.Mission1Pass)
                        {
                            Right = false;
                        }
                    }
                    /*Right = true;
                    StartCoroutine(CoolDown());
                    Right = false;*/
                    // StartCoroutine(CoolDown(Right));
                }
            }
            else if (Input.GetKey(KeyCode.LeftArrow))
            {
                Eyes.transform.position = new Vector3(1.603f, 0.0489559f, 0);
                if (!Quest.FirsttimeCloseTutorail)
                {
                    Left = true;
                }
                if (Input.GetKey(KeyCode.UpArrow))
                {
                    Eyes.transform.position = new Vector3(2.04f, 0.688f, 0);
                    KnowHow2P = true;
                    if (!Quest.FirsttimeCloseTutorail)
                    {
                        UpLeft = true;
                        if (Quest.Mission1Pass)
                        {
                            Left = false;
                        }
                    }
                }
                if (Input.GetKey(KeyCode.DownArrow))
                {
                    Eyes.transform.position = new Vector3(2.13f, -0.75f, 0);
                    KnowHow2P = true;
                    if (!Quest.FirsttimeCloseTutorail)
                    {
                        DownLeft = true;
                        if (Quest.Mission1Pass)
                        {
                            Left = false;
                        }
                    }
                }
                /*StartCoroutine(CoolDown());
                Left = true;
                StartCoroutine(CoolDown());
                Left = false;*/
                // StartCoroutine(CoolDown(Left));
            }
            else
            {
                //StartCoroutine(Delay());
                Eyes.transform.position = new Vector3(2.986287f, 0.0489559f, 0);
            }

                if (Up && UpRight && UpLeft && Down && DownLeft && DownRight && Left && Right)
                {
                    DoCircle = true;
                }
                if (Quest.Mission1Pass && !DoReset1)
                {
                    Down = false;
                    Up = false;
                    DoReset1 = true;
                }
                if (DoReset1 && Quest.Mission1Pass && Up && Down)
                {
                    DoUpDown = true;
                }
                if (Quest.Mission2Pass && !DoReset2)
                {
                    Left = false;
                    Right = false;
                    DoReset2 = true;
                }
                if (DoReset2 && Quest.Mission2Pass && Left && Right)
                {
                    DoLeftRight = true;
                }
                if (Quest.Mission3Pass && !DoReset3)
                {
                    UpRight = false;
                    UpLeft = false;
                    DownLeft = false;
                    DownRight = false;
                    DoReset3 = true;
                }
                if (DoReset3 && Quest.Mission3Pass)
                {
                    if (DownLeft && UpRight) { DoTilted = true; }
                    else if (DownRight && UpLeft) { DoTilted = true; }
                }
                /*
                            if (Input.GetKey(KeyCode.LeftArrow) && Input.GetKey(KeyCode.UpArrow)) //
                            {
                                Eyes.transform.position = new Vector3(2.04f, 0.688f, 0);
                            }
                            else if (Input.GetKey(KeyCode.LeftArrow) && Input.GetKey(KeyCode.DownArrow)) //
                            {
                                Eyes.transform.position = new Vector3(2.13f, -0.75f, 0);
                            }
                            else if (Input.GetKey(KeyCode.RightArrow) && Input.GetKey(KeyCode.UpArrow)) //
                            {
                                Eyes.transform.position = new Vector3(3.836f, 0.583f, 0);
                            }
                            else if (Input.GetKey(KeyCode.RightArrow) && Input.GetKey(KeyCode.DownArrow)) // 
                            {
                                Eyes.transform.position = new Vector3(3.9f, -0.75f, 0);
                            }
                            else
                            {
                                //StartCoroutine(Delay());
                                Eyes.transform.position = new Vector3(2.986287f, 0.0489559f, 0);
                            }*/
            
        }
        /*IEnumerator CoolDown(bool CD)
        {
           // Debug.Log("In");
            CD = true;
            yield return new WaitForSeconds(5);
            CD = false;
        }*/
    }
}
