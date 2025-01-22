using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckIFCorrect : MonoBehaviour
{
    public bool Placed1, Placed2, Placed3;
    public GameObject Ans1, Ans2, Ans3;
    public Drop4Test Lock1, Lock2, Lock3;
    public int ch1 = 0, ch2 = 0, ch3 = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Placed1 = Lock1.Placed;
        Placed1 = Lock2.Placed;
        Placed1 = Lock3.Placed;

        
    }
}
