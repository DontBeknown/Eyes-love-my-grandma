using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanMove : MonoBehaviour
{
    public Animator anim;
    public GameObject SaltAction;
    void Start()
    {
        StartCoroutine(Wait4Sec());
        anim = anim.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    IEnumerator Wait4Sec()
    {
        yield return new WaitForSeconds(1);
        Destroy(anim);
        SaltAction.SetActive(true);
    }
}
