using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class IsmouseoverUi : MonoBehaviour
{
    public GameObject Textbox;
    // Start is called before the first frame update
    void Start()
    {
        Textbox.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (EventSystem.current.IsPointerOverGameObject())
        {
            Debug.Log("Mouse is On " + gameObject.name);
            Textbox.SetActive(true);
        }
    }

}
