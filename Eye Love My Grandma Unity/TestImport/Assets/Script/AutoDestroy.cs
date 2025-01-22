using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoDestroy : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Boom());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator Boom()
    {
        yield return new WaitForSeconds(1);
        Destroy(gameObject);
    }
}
