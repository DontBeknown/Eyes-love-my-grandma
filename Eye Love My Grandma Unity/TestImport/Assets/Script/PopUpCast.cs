using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopUpCast : MonoBehaviour
{
    private GameObject obj;
    public bool isPop=false;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);

        if (hit.collider != null)
        {
            Debug.Log("Hit: " + hit.collider.gameObject.name);
            obj = hit.collider.gameObject;

            //obj.GetComponent<TextPop>().Pop = true;

            if (!isPop)
            {
                StartCoroutine(PopText());
            }
        }

    }

    IEnumerator PopText()
    {
        isPop = true;
        obj.GetComponent<TextPop>().Pop = true;
        yield return new WaitForSeconds(1);
        obj.GetComponent<TextPop>().Pop = false;
        isPop = false;
    }
}
