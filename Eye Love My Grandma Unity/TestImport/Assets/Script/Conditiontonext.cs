using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Conditiontonext : MonoBehaviour
{
    public bool IsPhone;
    public ZoomINOut zoom;
    public GameObject GoRight;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (zoom.Num2 >= 50 && zoom.Num2 <= 70 && IsPhone)
        {
                if (Input.GetMouseButtonUp(0))
                {
                    Debug.Log("Up");

                }
            

        }
    }
}
