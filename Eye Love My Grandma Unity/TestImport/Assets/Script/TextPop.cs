using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextPop : MonoBehaviour
{
    public GameObject TextBox;
    public bool Pop = false, isPop= false;
    void Start()
    {
        TextBox.GetComponent<SpriteRenderer>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Pop)
        {
            TextBox.GetComponent<SpriteRenderer>().enabled = true;
        }
        else
        {
            TextBox.GetComponent<SpriteRenderer>().enabled = false;
        }
        /*if( !isPop && Pop )
        StartCoroutine(PopText());*/

    }
    /*IEnumerator PopText()
    {
        isPop = true;
        TextBox.GetComponent<SpriteRenderer>().enabled = true;
        yield return new WaitForSeconds(1);
        TextBox.GetComponent<SpriteRenderer>().enabled = false;
        isPop = false;
    }*/

    /*IEnumerator PopText()
    {
        isPop = true;
        TextBox.GetComponent<SpriteRenderer>().enabled = false;
        yield return new WaitForSeconds(1);
        TextBox.GetComponent<SpriteRenderer>().enabled = true;
        isPop = false;
    }*/
}
