using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;
using Vector3 = UnityEngine.Vector3;

public class BeastHolder : MonoBehaviour
{
    public float beastTempo;

    public bool hasStarted;
    // Start is called before the first frame update
    void Start()
    {
        beastTempo = beastTempo / 60f;
    }

    // Update is called once per frame
    void Update()
    {
        if (!hasStarted)
        {
            /*if (Input.anyKeyDown)
            {
                hasStarted = true;
            }*/
        }else
        {
            transform.position -= new Vector3(0f, beastTempo * Time.deltaTime, 0f);
        }
    }
}
