using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrashCode : MonoBehaviour
{
    public GameObject GoRight, GoLeft;
    public int sum = 0;
    // Start is called before the first frame update
    void Start()
    {
        GoRight.SetActive(false);
        GoLeft.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            sum++;
        }
        if (sum >= 3)
        {
            GoRight.SetActive(true);
            GoLeft.SetActive(true);
        }
    }
}
