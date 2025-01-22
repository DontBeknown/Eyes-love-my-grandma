using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeEyeState : MonoBehaviour
{
    public int ch = 0;
    public GameObject NormalState,State1, State2, State3;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void NextState(int statenum)
    {
        ch++;
        if(statenum == 1)
        {
            if(ch%2 != 0)
            {
                NormalState.SetActive(false);
                State1.SetActive(true);
                State2.SetActive(false);
                State3.SetActive(false);
            }
            else
            {
                ResetState();
            }
        }
        else if(statenum == 2)
        {
            if(ch % 2 != 0)
            {
                NormalState.SetActive(false);
                State1.SetActive(false);
                State2.SetActive(true);
                State3.SetActive(false);
            }
            else
            {
                ResetState();
            }
        }
        else if (statenum == 3)
        {
            if (ch % 2 != 0)
            {
                NormalState.SetActive(false);
                State1.SetActive(false);
                State2.SetActive(false);
                State3.SetActive(true);
            }
            else
            {
                ResetState();
            }
        }
    }

    public void ResetState()
    {
        NormalState.SetActive(true);
        State1.SetActive(false);
        State2.SetActive(false);
        State3.SetActive(false);
    }
}
