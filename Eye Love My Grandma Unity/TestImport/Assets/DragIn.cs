using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragIn : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D col)
    {
        Debug.Log("kuy");
        col.gameObject.transform.position = new Vector2(1.29f, 3.34f);
    }
}
