using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PresstoSkiptime : MonoBehaviour
{
    public bool Day1, Day2, Day3;
    public GameObject Crossed1,Crossed2,Crossed3;
    // Start is called before the first frame update
    void Start()
    {
        Day1 = false;
        Day2 = false;
        Day3 = false;
        Crossed1.SetActive(false);
        Crossed2.SetActive(false);
        Crossed3.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void SkipDay1()
    {
        if(Day1 == false)
        {
            Crossed1.SetActive(true);
            Day1 = true;
        }
    }
    public void SkipDay2()
    {
        if (Day2 == false && Day1 ==true)
        {
            Crossed2.SetActive(true);
            Day2 = true;
        }   
    }
    public void SkipDay3()
    {
        if (Day3 == false && Day2 == true)
        {
            Crossed3.SetActive(true);
            Day3 = true;
        }
    }
}
